using Comdata;
using Comdata.FleetCreditWS0200;
using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.FleetCreditWS0200.Models;
using Comdata.RealTimeOnline0103;
using Comdata.RealTimeOnline0103.Enumerations;
using Comdata.RealTimeOnline0103.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.Threading.Tasks;
using Tekdox.Prime;
using Tekdox.Prime.Data.Entities;
using Tekdox.Prime.Models;
using Tekdox.Prime.Providers;

namespace Tekdox.Prime
{
    class Program
    {
        const bool UseProductionServer = true;

        static void Main()
        {
            // Configure the window
            Console.WindowWidth = Console.LargestWindowWidth - 10;

            // Retrieve service settings
            var serviceSettings = UseProductionServer ? BuildProductionSettings() : BuildTestSettings();

            // Determine whether each Comdata card can have funds direct-deposited via the Comdata web service
            var result = GetDirectDepositInfoAsync(serviceSettings).GetAwaiter().GetResult();
            int directDepositCards = result.Item1, noDirectDepositCards = result.Item2;

            Console.WriteLine();
            ConsoleWriteTimestampLine($"Card results:  {directDepositCards:N0} direct deposit -- {noDirectDepositCards:N0} other");

            // Pause before exiting
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



        static ComdataSettings BuildTestSettings() => new()
        {
            IsEnabled = true,

            CompanyId = 1,
            CompanyName = "National Boiler",

            CustomerId = "39170",  // "90860"
            AccountCode = "NB012",
            CodeWord = "EXCASH",

            // WSSE Token Credentials
            RealTimeOnlineEndpointAddress = "https://w8cert.iconnectdata.com/cows/services/RealTimeOnline0103",
            FleetCreditEndpointAddress = "https://w8cert.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200",
            WebserviceUserName = "extnb012uat",
            WebservicePassword = "Sg58Mn57",

            // Network Credentials
            NetworkUserName = "NB012",
            NetworkPassword = "NB012#52",

            // Security Info
            SecurityCardNumber = "5600171620395709",

            DelayMinutes = 10
        };
        static ComdataSettings BuildProductionSettings() => new()
        {
            IsEnabled = true,

            CompanyId = 1,
            CompanyName = "National Boiler",

            CustomerId = "39170",  // "90860"
            AccountCode = "NB012",
            CodeWord = "EXCASH",

            // WSSE Token Credentials
            RealTimeOnlineEndpointAddress = "https://w6.iconnectdata.com/cows/services/RealTimeOnline0103",
            FleetCreditEndpointAddress = "https://w6.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200",
            WebserviceUserName = "extnb012",
            WebservicePassword = "Gh38ZL79",

            // Network Credentials
            NetworkUserName = "NB012",
            NetworkPassword = "NB012#52",

            // Security Info
            SecurityCardNumber = "5567362213081480",  //  "5600171708290129",

            DelayMinutes = 10
        };



        private static async Task<(int, int)> GetDirectDepositInfoAsync(ComdataSettings settings)
        {
            int directDepositCards = 0, noDirectDepositCards = 0;
            SoapInspectorBehavior soapInspector = null;

            try
            {
                //  Generate a card list that will contain the Account Code & CustID the cards is assigned to along some additional information via a WebServices request/response.
                var activeCards = await GetActiveCardsAsync(settings);

                // Initialize the WebService client
                var client = new RealTimeOnline0103Client(settings.RealTimeOnlineEndpointAddress);
                client.SetUsernameTokenCredentials(settings.WebserviceUserName, settings.WebservicePassword);
                client.SetActiveDirectoryCredentials(settings.NetworkUserName, settings.NetworkPassword);

                // Add the debug inspector
                soapInspector = new SoapInspectorBehavior();
                client.Endpoint.EndpointBehaviors.Add(soapInspector);

                // Query each card for DirectDeposit status
                foreach (var card in activeCards)
                {
                    // Use stopwatch to time the operation
                    var sw = new Stopwatch();
                    sw.Start();

                    if (card == null)
                    {
                        sw.Stop();
                        ConsoleWriteTimestampLine($"The specified card {card.CardNumber} for employee {card.FirstName.ToUpper()} {card.LastName.ToUpper()} either does not exist or is not active! -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");
                    }
                    else
                    {
                        // Card Number is valid--determine whether to DirectDeposit
                        var directDepositResult = await client.DirectDepositInquiryAsync(new DirectDepositInquiryRequest
                        {
                            // Network Credentials
                            SignOnName = settings.NetworkUserName,  // "NB012"
                            Password = settings.NetworkPassword,  // "NB012#52"
                            SecurityInfo = settings.SecurityCardNumber,  // "5600171620395709"

                            // Company account
                            AccountCode = settings.AccountCode,  // "NB012"
                            CustomerId = card.CustomerId,  // "90860" - settings.CustomerId

                            // Employee details
                            EmployeeNumber = card.EmployeeId,  //card.CardNumber,  // transaction.EmployeeCardNumber
                            EmployeeCustomerId = card.CustomerId,
                            DiscretionaryData = "PPDPAYROLL",
                            TrackingNumber = 0  // 99
                        });//

                        // Output if a server error occurred
                        if (directDepositResult.ResponseCode > 0)
                        {
                            sw.Stop();
                            ConsoleWriteTimestampLine($"{card.CardNumber} -- {card.FirstName.ToUpper()} {card.LastName.ToUpper()} -- Error: {directDepositResult.ResponseCode} {directDepositResult.ResponseMessage} -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");

                            // Output XML debug info
                            ConsoleWriteXml(soapInspector);

                            noDirectDepositCards++;
                            continue;
                        }

                        // Determine whether the card supports direct deposit
                        bool directDeposit = directDepositResult.ResponseCode == 0
                            && directDepositResult.BankAccounts != null
                            && directDepositResult.BankAccounts.Any(a => a.CheckingAccountFlag == DirectDepositInquiryCheckingAccountFlag.CheckingAccount);

                        if (directDeposit)
                            directDepositCards++;
                        else
                            noDirectDepositCards++;

                        // Output the results
                        sw.Stop();
                        ConsoleWriteTimestampLine($"{card.CardNumber} -- {card.FirstName.ToUpper()} {card.LastName.ToUpper()} -- {directDepositResult.BankAccounts?.Length ?? 0:N0} accounts -- DirectDeposit: {directDeposit} -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleWriteErrorLine($"An {ex.GetType().Name} occurred while processing the Request file!", ex);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);
            }

            return (directDepositCards, noDirectDepositCards);
        }



        private static async Task<CardListingRecordV02[]> GetActiveCardsAsync(ComdataSettings settings)
        {
            //ConsoleWriteTimestampLine($"Retrieving active card records...");

            // Retrieve the list of employee cards from the Maintenance WebService client
            var maintenanceClient = new FleetCreditWS0200Client(settings.FleetCreditEndpointAddress);
            maintenanceClient.SetUsernameTokenCredentials(settings.WebserviceUserName, settings.WebservicePassword);
            maintenanceClient.SetActiveDirectoryCredentials(settings.NetworkUserName, settings.NetworkPassword);

            //  Generate a card list that will contain the Account Code & CustID the cards is assigned to along some additional information via a WebServices request/response.
            var records = new List<CardListingRecordV02>();
            const int pageSize = 10000;
            int page = 1;

            var sw = new Stopwatch();
            sw.Start();

            CardListingV02Response lastResult;
            do
            {
                lastResult = await maintenanceClient.CardListingV02Async(
                    new CardListingV02Request(
                        new[] { new AccountCodeRecord(settings.AccountCode) },
                        CardListingMaskCardFlag.No,
                        CardListingStatus.Active,
                        CardListingSortOption.CardNumber,
                        pageSize,
                        page));

                if (lastResult.RecordCount > 0) records.AddRange(lastResult.Records);
                page++;
            } while (lastResult.RecordCount == pageSize);

            sw.Stop();
            ConsoleWriteTimestampLine($"{records.Count:N0} active card records retrieved in {sw.Elapsed.TotalSeconds:N0}s.");
            Console.WriteLine();

            return records
                .OrderBy(r => r.CardNumber)
                .ToArray();
        }



        private static void ConsoleWriteTimestampLine(string message) => Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}:  {message}");

        private static void ConsoleWriteErrorLine(string message, Exception ex = null)
        {
            // Retain the original console colors
            var foreground = Console.ForegroundColor;
            var background = Console.BackgroundColor;

            // Set the console colors for "error" mode
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;

            // Write the custom message (if provided)
            if (!string.IsNullOrWhiteSpace(message))
                ConsoleWriteTimestampLine(message);

            // Write the Exception details (if provided)
            if (ex != null)
            {
                Console.WriteLine(ex.Message);

                string[] lines = ex.StackTrace.Split(
                    new string[] { "\r\n", "\r", "\n" },
                    StringSplitOptions.None
                );
                foreach (var line in lines)
                    Console.WriteLine(line);
            }

            // Reset the original console colors
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        private static void ConsoleWriteXml(SoapInspectorBehavior soapInspector)
        {
            if (soapInspector == null) return;

            Console.WriteLine();

            if (!string.IsNullOrWhiteSpace(soapInspector.LastRequestXml))
            {
                Console.WriteLine("Request XML:");
                Console.WriteLine(soapInspector.LastRequestXml);
            }
            else
            {
                Console.WriteLine("Request XML:  N/A");
            }

            Console.WriteLine();

            if (!string.IsNullOrWhiteSpace(soapInspector.LastResponseXml))
            {
                Console.WriteLine("Response XML:");
                Console.WriteLine(soapInspector.LastResponseXml);
            }
            else
            {
                Console.WriteLine("Response XML:  N/A");
            }

            Console.WriteLine();
        }
    }
}
