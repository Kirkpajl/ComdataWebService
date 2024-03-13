using Comdata.FleetCreditWS0200;
using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.FleetCreditWS0200.Models;
using Comdata.RealTimeOnline0103;
using Comdata.RealTimeOnline0103.Enumerations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Comdata.Samples.DirectDeposit
{
    class Program
    {
        static async Task Main()
        {
            // Configure the window
            if (OperatingSystem.IsWindows())
            {
                Console.WindowWidth = Math.Min(150, Console.LargestWindowWidth - 10);
                Console.WindowHeight = 25;
            }

            // Retrieve the Comdata credentials from the App Secrets store
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            var settings = config.GetSection("Comdata").Get<ComdataSettings>();

            // Get all active cards from the Comdata test service
            var activeCards = await GetActiveCardsAsync(settings);

            // Determine whether each Comdata card can have funds direct-deposited via the Comdata web service
            await CheckDirectDepositStatusAsync(settings, activeCards);
            Console.WriteLine();

            // Pause before exiting
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



        /// <summary>
        /// Retrieve the list of employee cards from the Maintenance WebService client
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        private static async Task<CardListingRecordV02[]> GetActiveCardsAsync(ComdataSettings settings)
        {
            // Initialize the Maintenance WebService client
            var maintenanceClient = new FleetCreditWS0200Client(EndpointConfiguration.Certification);  //"https://w8cert.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200"
            maintenanceClient.SetServiceCredentials(settings.WebserviceUserName, settings.WebservicePassword);
            maintenanceClient.SetNetworkCredentials(settings.NetworkUserName, settings.NetworkPassword);

            //  Generate a card list that will contain the Account Code & CustID the cards is assigned to along some additional information via a WebServices request/response.
            var records = new List<CardListingRecordV02>();
            const int pageSize = 10000;
            int page = 1;

            var sw = new Stopwatch();
            sw.Start();

            PaginatedDataSet<CardListingRecordV02> lastResult;
            do
            {
                lastResult = await maintenanceClient.CardListingV02Async(
                    new[] { new AccountCodeRecord(settings.AccountCode) },
                    CardListingMaskCardFlag.No,
                    CardListingStatus.Active,
                    CardListingSortOption.CardNumber,
                    pageSize,
                    page);

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

        /// <summary>
        /// Determine whether each Comdata card can have funds direct-deposited via the Comdata web service.
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="cards"></param>
        /// <returns></returns>
        private static async Task CheckDirectDepositStatusAsync(ComdataSettings settings, CardListingRecordV02[] cards)
        {
            // Initialize the client using the Comdata test service
            var client = new RealTimeOnline0103Client(EndpointConfiguration.Certification);
            client.SetServiceCredentials(settings.WebserviceUserName, settings.WebservicePassword);
            client.SetNetworkCredentials(settings.NetworkUserName, settings.NetworkPassword);
            client.SetSecurityCard(settings.SecurityCardNumber);

            // Add the debug inspector
            var soapInspector = new SoapInspectorBehavior();
            client.Endpoint.EndpointBehaviors.Add(soapInspector);

            // Iterate through the card collection
            Random random = new();
            var sw = new Stopwatch();

            foreach (var card in cards)
            {
                try
                {
                    // Use stopwatch to time the operation
                    sw.Restart();

                    // Determine whether to DirectDeposit
                    var directDepositResult = await client.DirectDepositInquiryAsync(settings.AccountCode, card.CustomerId, card.CustomerId, card.EmployeeId, "PPDPAYROLL", 0);

                    bool directDeposit = directDepositResult.ResponseCode == 0
                        && directDepositResult.BankAccounts != null
                        && directDepositResult.BankAccounts.Any(a => a.CheckingAccountFlag == DirectDepositInquiryCheckingAccountFlag.CheckingAccount);

                    // Output the results
                    string processingResults = directDepositResult.ResponseCode > 0
                        ? $"*{directDepositResult.ResponseCode}:  {directDepositResult.ResponseMessage}"
                        : $"{directDepositResult.BankAccounts?.Length ?? 0:N0} accounts -- DirectDeposit: {directDeposit}";

                    sw.Stop();
                    ConsoleWriteTimestampLine($"CARD #{card.CardNumber} -- {processingResults} -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");
                }
                catch (TimeoutException timeProblem)
                {
                    ConsoleWriteErrorLine($"CARD #{card.CardNumber} -- The service operation timed out.", timeProblem);
                    ConsoleWriteXml(soapInspector);
                }
                catch (FaultException unknownFault)
                {
                    ConsoleWriteErrorLine($"CARD #{card.CardNumber} -- An unknown exception was received.", unknownFault);
                    ConsoleWriteXml(soapInspector);
                }
                catch (CommunicationException commProblem)
                {
                    ConsoleWriteErrorLine($"CARD #{card.CardNumber} -- There was a communication problem.", commProblem);
                    ConsoleWriteXml(soapInspector);
                }
                catch (ComdataOperationException operationProblem)
                {
                    if (operationProblem.ResponseCode == 1261)
                    {
                        ConsoleWriteTimestampLine($"CARD #{card.CardNumber} -- DIRECT DEPOSIT INFORMATION DOES NOT EXIST FOR THIS EMPLOYEE -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");
                    }
                    else
                    {
                        ConsoleWriteErrorLine($"CARD #{card.CardNumber} -- {operationProblem.ResponseCode}: {operationProblem.Message}.", operationProblem);
                        ConsoleWriteXml(soapInspector);
                    }
                }
                catch (Exception ex)
                {
                    ConsoleWriteErrorLine($"CARD #{card.CardNumber} -- An {ex.GetType().Name} occurred while performing the operation.", ex);
                    ConsoleWriteXml(soapInspector);
                }
            }
        }



        #region Console Helper Methods

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

        private static void ConsoleWriteXml(SoapInspectorBehavior soapInspector) => ConsoleWriteXml(soapInspector.LastRequestXml, soapInspector.LastResponseXml);
        private static void ConsoleWriteXml(string requestXml, string responseXml)
        {
            Console.WriteLine();

            if (!string.IsNullOrWhiteSpace(requestXml))
            {
                Console.WriteLine("Request XML:");
                Console.WriteLine(requestXml);
            }
            else
            {
                Console.WriteLine("Request XML:  N/A");
            }

            Console.WriteLine();

            if (!string.IsNullOrWhiteSpace(responseXml))
            {
                Console.WriteLine("Response XML:");
                Console.WriteLine(responseXml);
            }
            else
            {
                Console.WriteLine("Response XML:  N/A");
            }

            Console.WriteLine();
        }

        #endregion Console Helper Methods
    }
}