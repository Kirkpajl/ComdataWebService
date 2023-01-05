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
        const bool UseProductionServer = false;

        static void Main()
        {
            // Configure the window
            Console.WindowWidth = Console.LargestWindowWidth - 10;

            // Retrieve service settings
            var serviceSettings = UseProductionServer ? BuildProductionSettings() : BuildTestSettings();

            // Retrieve the user-specified Import file
            var request = GetRequest();

            ConsoleWriteTimestampLine($"Request file loaded -- Job #: {request.JobNumber} -- {request.Transactions.Count:N0} transactions => {request.TransactionTotal:C}");
            Console.WriteLine();

            // Attempt to process the Request file via the Comdata web service
            ProcessRequestFileAsync(request, serviceSettings).GetAwaiter().GetResult();
            Console.WriteLine();

            // Pause before cancelling the Load request
            ConsoleWriteTimestampLine("Pausing execution for 10-secs for Comdata processing...");
            Thread.Sleep(10000);
            Console.WriteLine();

            // Attempt to cancel the Request payments via the Comdata web service
            CancelRequestAsync(request, serviceSettings).GetAwaiter().GetResult();
            Console.WriteLine();

            // Pause before exiting
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
            SecurityCardNumber = "5567362213081480",

            DelayMinutes = 10
        };



        static ComdataRequest GetRequest()
        {
            // Retrieve the list of Sage request files
            var requestFiles = FileManager.RequestsDirectory.GetFiles().OrderByDescending(f => f.LastWriteTime).ToArray();
            int padLength = requestFiles.Length.ToString().Length;

            // Prompt the user to select a file
            int selectedFileIndex = -1;

            do
            {
                // Display a list of Sage request files
                Console.Clear();
                Console.WriteLine("Select a Timberline/Sage request file to process:");
                Console.WriteLine();

                Console.WriteLine($"  {"*".PadLeft(padLength)}) Automatically-generated Sage test file");
                for (int i = 0; i < requestFiles.Length; i++)
                {
                    var file = requestFiles[i];
                    Console.WriteLine($"  {(i + 1).ToString().PadLeft(padLength)}) {file.Name}");
                }
                Console.WriteLine();
                Console.Write("Enter File #:  ");

                // Wait for the user to select a file
                string input = Console.ReadLine();

                // Generate a test Request if the user selected '*'
                if (input == "*")
                {
                    Console.Clear();
                    return BuildTestRequest();
                }

                // Attempt to resolve the user input as a cached Request file
                if (int.TryParse(input, out int fileNumber) && fileNumber >= 0 && fileNumber <= requestFiles.Length)
                {
                    selectedFileIndex = fileNumber - 1;
                }
            } while (selectedFileIndex < 0 || selectedFileIndex >= requestFiles.Length);

            // Select the file
            var selectedFile = requestFiles[selectedFileIndex];

            // Output the file properties
            Console.Clear();
            var headerLine = $"Timberline/Sage request file:  {selectedFile.Name}";
            Console.WriteLine(headerLine);
            Console.WriteLine(new string('-', headerLine.Length));
            Console.WriteLine();

            // Prompt user to supply job number
            Console.Write("Job Number:  ");
            string jobNumber = Console.ReadLine().Trim();
            Console.WriteLine();

            // Load the ComdataRequest file
            var doc = ComdataRequestDocument.LoadFromFile(selectedFile.FullName);

            string initials = selectedFile.Name[..2];

            // Initialize the Request item
            var request = new ComdataRequest
            {
                JobNumber = jobNumber,
                ScheduleTime = DateTime.UtcNow.AddHours(1),

                //CreatedByUserId = appUser?.Id,
                CreatedByUser = new ApplicationUser { FirstName = initials.FirstOrDefault().ToString().ToUpper(), LastName = initials.LastOrDefault().ToString().ToUpper() },
                DateCreated = DateTime.UtcNow,

                //ModifiedByUserId = appUser?.Id,
                DateModified = DateTime.UtcNow,

                ImportFileName = selectedFile.Name,
                Transactions = doc.Transactions.Select(t => t.ToEntity()).ToList()
            };

            foreach (var transaction in request.Transactions)
            {
                if (request.ScheduleTime.HasValue)
                    transaction.DateAvailable = request.ScheduleTime.Value;
            }

            // Return the Request record
            Console.Clear();
            return request;
        }

        static ComdataRequest BuildTestRequest(DateTime? dateAvailable = null)
        {
            dateAvailable ??= DateTime.Now.AddHours(-1);  //dateAvailable ??= DateTime.UtcNow.AddHours(1);
            string jobNumber = $"TEST-{DateTime.Now:yyyyMMdd-HHmmss}";

            Random random = new();

            var request = new ComdataRequest()
            {
                JobNumber = jobNumber,
                ScheduleTime = dateAvailable,

                //ImportFileName = $"NB012.NB012.MM00000.{DateTime.Now:MMddYYYY}.{DateTime.Now:HHmmss}",

                CreatedByUser = new ApplicationUser { FirstName = "Test", LastName = "Admin", ComdataCodeword = "EXCASH" },
                DateCreated = DateTime.UtcNow, //DateTime.Parse("03-18-2021 04:03 am"),

                //UploadStatus = RequestUploadStatusType.Transmitted,
                //UploadTime = DateTime.Parse("03-18-2021 04:03 am"),

                //ResponseStatus = RequestResponseStatusType.Error,

                Transactions = new[]
                {
                    // CustomerId = 39170
                    BuildTestTransaction("5567362201185434", "CHIP2022 LOADTEST", null, dateAvailable, jobNumber, random),  //1.11m
                    BuildTestTransaction("5567362201185442", "CHIP2023 LOADTEST", null, dateAvailable, jobNumber, random),  //2.22m
                    BuildTestTransaction("5567362201185459", "CHIP2024 LOADTEST", null, dateAvailable, jobNumber, random),  //3.33m
                    BuildTestTransaction("5567362201185467", "CHIP2025 LOADTEST", null, dateAvailable, jobNumber, random),  //4.44m
                    BuildTestTransaction("5567362201185475", "CHIP2026 LOADTEST", null, dateAvailable, jobNumber, random),  //5.55m
                    BuildTestTransaction("5567362201185483", "CHIP2027 LOADTEST", null, dateAvailable, jobNumber, random),  //6.66m
                    BuildTestTransaction("5567362201185491", "CHIP2028 LOADTEST", null, dateAvailable, jobNumber, random),  //7.77m

                    // CustomerId = 90860
                    //new ComdataTransaction { EmployeeCardNumber = "5600171620386328", IndividualName = "COMDATA SAMPLE EMPLOYEE", Amount = 1.00m, DirectDeposit = false },

                    //new ComdataTransaction { EmployeeCardNumber = "1620386328", IndividualName = "C118 LOADTEST", Amount = 1269.11m, DirectDeposit = false },
                    //new ComdataTransaction { EmployeeCardNumber = "1620386674", IndividualName = "C119 LOADTEST", Amount = 497.87m, DirectDeposit = false },
                    //new ComdataTransaction { EmployeeCardNumber = "1620386781", IndividualName = "C120 LOADTEST", Amount = 439.68m, DirectDeposit = false },
                    //new ComdataTransaction { EmployeeCardNumber = "1620386781", IndividualName = "C121 LOADTEST", Amount = 1139.08m, DirectDeposit = false },
                    //new ComdataTransaction { EmployeeCardNumber = "1620387763", IndividualName = "C122 LOADTEST", Amount = 1633.52m, DirectDeposit = false },
                }
            };

            // Persist the new Request file for future reference
            var doc = new ComdataRequestDocument(request);
            doc.SaveToFile(Path.Combine(FileManager.RequestsDirectory.FullName, jobNumber));

            // Return the new Comdata Request
            return request;
        }

        static ComdataTransaction BuildTestTransaction(string employeeCardNumber, string individualName, decimal? amount, DateTime? dateAvailable, string miscellaneous, Random random) => new()
        {
            EmployeeCardNumber = employeeCardNumber,
            IndividualName = individualName,
            Amount = amount ?? Convert.ToDecimal(random.NextDouble() * 10),
            DateAvailable = dateAvailable ?? DateTime.UtcNow,
            Miscellaneous = miscellaneous,
            TransactionType = ComdataTransactionType.AddLoadFunds,
            ChargeMethod = ComdataTransactionChargeMethod.PlusFees,

            DateCreated = DateTime.UtcNow
        };



        private static async Task<bool> ProcessRequestFileAsync(ComdataRequest request, ComdataSettings settings)
        {
            bool transactionsProcessed = false;

            try
            {
                ConsoleWriteTimestampLine("Processing Request file...");
                
                //  Generate a card list that will contain the Account Code & CustID the cards is assigned to along some additional information via a WebServices request/response.
                var activeCards = await GetActiveCardsAsync(settings);

                // Initialize the WebService client
                var client = new RealTimeOnline0103Client(settings.RealTimeOnlineEndpointAddress);
                client.SetUsernameTokenCredentials(settings.WebserviceUserName, settings.WebservicePassword);
                client.SetActiveDirectoryCredentials(settings.NetworkUserName, settings.NetworkPassword);

                // Add the debug inspector
                var soapInspector = new SoapInspectorBehavior();
                client.Endpoint.EndpointBehaviors.Add(soapInspector);

                // Process the request's transactions
                foreach (var transaction in request.Transactions)
                {
                    // Process the transaction
                    _ = await ProcessTransactionAsync(client, transaction, activeCards, settings, soapInspector);
                }
                
                // Set the request's overall status
                bool allTransactionsSuccessful = request.Transactions.All(t => t.IsSuccessful == true);
                request.ResponseStatus = allTransactionsSuccessful ? RequestResponseStatusType.OK : RequestResponseStatusType.Error;

                Console.WriteLine();
                ConsoleWriteTimestampLine($"Transactions processed {(allTransactionsSuccessful ? "successfully" : "with errors")} -- {request.TransactionCount} @ {request.TransactionTotal:c} -- Job #: {request.JobNumber}");

                // Set flag to TRUE
                transactionsProcessed = true;
            }
            catch (Exception ex)
            {
                ConsoleWriteErrorLine($"An {ex.GetType().Name} occurred while processing the Request file!", ex);
            }

            return transactionsProcessed;
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

        private static async Task<bool> ProcessTransactionAsync(RealTimeOnline0103Client client, ComdataTransaction transaction, CardListingRecordV02[] activeCards, ComdataSettings settings, SoapInspectorBehavior soapInspector)
        {
            try
            {
                // Use stopwatch to time the operation
                var sw = new Stopwatch();
                sw.Start();

                // Ensure that the specified Card Number exists and is active
                var employeeCardInfo = activeCards.FirstOrDefault(c => c.CardNumber == transaction.EmployeeCardNumber);

                if (employeeCardInfo == null)
                {
                    sw.Stop();
                    ConsoleWriteTimestampLine($"The specified card {transaction.EmployeeCardNumber} for employee {transaction.IndividualName.ToUpper()} either does not exist or is not active! -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");

                    return false;
                }
                else
                {
                    // Send a Card Inquiry request (to get the initial balance)
                    var cardInquiryResult = await client.CardInquiryAsync(new CardInquiryRequestV01
                    {
                        // Network Credentials
                        SignOnName = settings.NetworkUserName,  // "NB012"
                        Password = settings.NetworkPassword,  // "NB012#52"
                        SecurityInfo = settings.SecurityCardNumber,  // "5600171620395709"

                        // Company account
                        AccountCode = settings.AccountCode,  // "NB012"
                        CustomerId = employeeCardInfo.CustomerId,  // "90860" - settings.CustomerId

                        // Transaction details
                        CardNumber = transaction.EmployeeCardNumber,
                        DiscretionaryData = "Pre-cancel",
                        TrackingNumber = transaction.TrackingNumber
                    });

                    // Card Number is valid--determine whether to DirectDeposit
                    var directDepositResult = await client.DirectDepositInquiryAsync(new DirectDepositInquiryRequest
                    {
                        // Network Credentials
                        SignOnName = settings.NetworkUserName,  // "NB012"
                        Password = settings.NetworkPassword,  // "NB012#52"
                        SecurityInfo = settings.SecurityCardNumber,  // "5600171620395709"

                        // Company account
                        AccountCode = settings.AccountCode,  // "NB012"
                        CustomerId = employeeCardInfo.CustomerId,  // "90860" - settings.CustomerId

                        // Employee details
                        EmployeeNumber = employeeCardInfo.EmployeeId,  //transaction.EmployeeCardNumber
                        EmployeeCustomerId = employeeCardInfo.CustomerId,
                        DiscretionaryData = "PPDPAYROLL",
                        TrackingNumber = 0  // 99
                    });

                    bool directDeposit = directDepositResult.ResponseCode == 0 
                        && directDepositResult.BankAccounts != null
                        && directDepositResult.BankAccounts.Any(a => a.CheckingAccountFlag == DirectDepositInquiryCheckingAccountFlag.CheckingAccount);

                    // Send the LoadMoney request to Comdata
                    var loadMoneyResult = await client.LoadMoneyAsync(new LoadMoneyRequest
                    {
                        // Network Credentials
                        SignOnName = settings.NetworkUserName,  // "NB012"
                        Password = settings.NetworkPassword,  // "NB012#52"
                        SecurityInfo = settings.SecurityCardNumber,  // "5600171620395709"

                        // Company account
                        AccountCode = settings.AccountCode,  // "NB012"
                        CustomerId = employeeCardInfo.CustomerId,  // "90860" - settings.CustomerId

                        // Transaction details
                        CardNumber = transaction.EmployeeCardNumber,
                        LoadAmount = transaction.Amount.ToDouble(),
                        DirectDeposit = directDeposit,  //transaction.DirectDeposit
                        TripNumber = transaction.TripNumber,
                        MiscellaneousData = transaction.Miscellaneous.TruncateStart(15),
                        AddSubtractFlag = transaction.TransactionType == ComdataTransactionType.SubtractFunds ? LoadMoneyAddSubtractFlag.Subtract : LoadMoneyAddSubtractFlag.Add,
                        PlusLessFlag = transaction.ChargeMethod == ComdataTransactionChargeMethod.LessFees ? LoadMoneyRequestPlusLessFlag.LessFees : LoadMoneyRequestPlusLessFlag.PlusFees,
                        AvailableDateTime = transaction.DateAvailable,                        

                        DiscretionaryData = transaction.Miscellaneous.TruncateStart(10),  //"PPDPAYROLL",
                        TrackingNumber = Convert.ToInt64(DateTime.Now.TimeOfDay.TotalSeconds)  // 99
                    });

                    // Update the Transaction properties
                    transaction.CustomerId = employeeCardInfo.CustomerId;
                    transaction.ReferenceNumber = loadMoneyResult.ReferenceNumber;
                    transaction.TrackingNumber = loadMoneyResult.TrackingNumber ?? 0;
                    transaction.TransactionType = loadMoneyResult.AddSubtractFlag == LoadMoneyAddSubtractFlag.Subtract ? ComdataTransactionType.SubtractFunds : ComdataTransactionType.AddLoadFunds;
                    transaction.ChargeMethod = loadMoneyResult.PlusLessFlag == LoadMoneyResponsePlusLessFlag.LessFees ? ComdataTransactionChargeMethod.LessFees : ComdataTransactionChargeMethod.PlusFees;
                    transaction.ProcessingResults = loadMoneyResult.ResponseCode > 0 
                        ? $"*{loadMoneyResult.ResponseCode}:  {loadMoneyResult.ResponseMessage}" 
                        : $"{transaction.Amount:c} LOADED {(directDeposit ? "TO BANK" : "TO CARD")} | BALANCE:  {cardInquiryResult.CardBalance:c} -> {loadMoneyResult.CardBalance:c}";

                    sw.Stop();
                    ConsoleWriteTimestampLine($"{transaction.IndividualName} -- {transaction.ProcessingResults} -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");

                    // Output XML debug info
                    if (loadMoneyResult.ResponseCode > 0)
                        ConsoleWriteXml(soapInspector);

                    // Return whether the request succeeded
                    return loadMoneyResult.ResponseCode == 0;
                }
            }
            catch (TimeoutException timeProblem)
            {
                transaction.ProcessingResults = "*OPERATION TIMED OUT";
                ConsoleWriteErrorLine("The service operation timed out.", timeProblem);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
            catch (FaultException unknownFault)
            {
                transaction.ProcessingResults = "*UNKNOWN EXCEPTION";
                ConsoleWriteErrorLine("An unknown exception was received.",unknownFault);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
            catch (CommunicationException commProblem)
            {
                transaction.ProcessingResults = "*COMMUNICATION PROBLEM";
                ConsoleWriteErrorLine("There was a communication problem.", commProblem);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
            catch (Exception ex)
            {
                transaction.ProcessingResults = $"*{ex.GetType().Name.ToUpper()}";
                ConsoleWriteErrorLine($"An {ex.GetType().Name} occurred while processing the Comdata transaction--{transaction.IndividualName}: {transaction.Amount}!", ex);
                
                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
        }



        private static async Task<bool> CancelRequestAsync(ComdataRequest request, ComdataSettings settings)
        {
            bool transactionsCancelled = false;

            try
            {
                ConsoleWriteTimestampLine("Cancelling Request...");

                // Initialize the WebService client
                var client = new RealTimeOnline0103Client(settings.RealTimeOnlineEndpointAddress);
                client.SetUsernameTokenCredentials(settings.WebserviceUserName, settings.WebservicePassword);
                client.SetActiveDirectoryCredentials(settings.NetworkUserName, settings.NetworkPassword);

                // Add the debug inspector
                var soapInspector = new SoapInspectorBehavior();
                client.Endpoint.EndpointBehaviors.Add(soapInspector);

                // Process the request's transactions
                foreach (var transaction in request.Transactions)
                {
                    // Cancel the transaction
                    _ = await CancelTransactionAsync(client, transaction, settings, soapInspector);
                }

                // Set the request's overall status
                bool allTransactionsSuccessful = request.Transactions.All(t => t.IsSuccessful == true);
                request.ResponseStatus = allTransactionsSuccessful ? RequestResponseStatusType.Cancelled : RequestResponseStatusType.Error;

                ConsoleWriteTimestampLine($"Transactions cancelled {(allTransactionsSuccessful ? "successfully" : "with errors")} -- {request.TransactionCount} @ {request.TransactionTotal:c} -- Job #: {request.JobNumber}");

                // Set flag to TRUE
                transactionsCancelled = true;
            }
            catch (Exception ex)
            {
                ConsoleWriteErrorLine($"An {ex.GetType().Name} occurred while cancelling the Request!", ex);
            }

            return transactionsCancelled;
        }

        private static async Task<bool> CancelTransactionAsync(RealTimeOnline0103Client client, ComdataTransaction transaction, ComdataSettings settings, SoapInspectorBehavior soapInspector)
        {
            try
            {
                bool operationResult = false;
                string cancelRequestXml = null, cancelResponseXml = null;

                // Use stopwatch to time the operation
                var sw = new Stopwatch();
                sw.Start();

                // Send a Card Inquiry request (to avoid the "202 - Please call" error)
                var cardInquiryResult = await client.CardInquiryAsync(new CardInquiryRequestV01
                {
                    // Network Credentials
                    SignOnName = settings.NetworkUserName,  // "NB012"
                    Password = settings.NetworkPassword,  // "NB012#52"
                    SecurityInfo = settings.SecurityCardNumber,  // "5600171620395709"

                    // Company account
                    AccountCode = settings.AccountCode,  // "NB012"
                    CustomerId = transaction.CustomerId,  // "90860" - settings.CustomerId

                    // Transaction details
                    CardNumber = transaction.EmployeeCardNumber,
                    DiscretionaryData = "Pre-cancel",
                    TrackingNumber = transaction.TrackingNumber
                });

                if (cardInquiryResult.ResponseCode > 0)
                {
                    transaction.ProcessingResults = "*CARD INQUIRY FAILED; UNABLE TO CANCEL";
                }
                else if (cardInquiryResult.ExpressCash == false)
                {
                    transaction.ProcessingResults = "*NOT AN EXPRESS CASH ACCOUNT; UNABLE TO CANCEL";
                }
                else
                {
                    // Attempt to cancel the transaction
                    var cancelLoadMoneyResult = await client.LoadMoneyCancelAsync(new LoadMoneyCancelRequest
                    {
                        // Network Credentials
                        SignOnName = settings.NetworkUserName,  // "NB012"
                        Password = settings.NetworkPassword,  // "NB012#52"
                        SecurityInfo = settings.SecurityCardNumber,  // "5600171620395709"

                        // Company account
                        AccountCode = settings.AccountCode,  // "NB012"
                        CustomerId = transaction.CustomerId,  // "90860" - settings.CustomerId

                        // Transaction details
                        CardNumber = transaction.EmployeeCardNumber,
                        ReferenceNumber = transaction.ReferenceNumber,
                        TrackingNumber = transaction.TrackingNumber
                    });
                    operationResult = cancelLoadMoneyResult.ResponseCode == 0;

                    cancelRequestXml = soapInspector.LastRequestXml;
                    cancelResponseXml = soapInspector.LastResponseXml;

                    // Send a Card Inquiry request (to confirm that the cancellation succeeded)
                    var cancelConfirmationCardInquiryResult = await client.CardInquiryAsync(new CardInquiryRequestV01
                    {
                        // Network Credentials
                        SignOnName = settings.NetworkUserName,  // "NB012"
                        Password = settings.NetworkPassword,  // "NB012#52"
                        SecurityInfo = settings.SecurityCardNumber,  // "5600171620395709"

                        // Company account
                        AccountCode = settings.AccountCode,  // "NB012"
                        CustomerId = transaction.CustomerId,  // "90860" - settings.CustomerId

                        // Transaction details
                        CardNumber = transaction.EmployeeCardNumber,
                        DiscretionaryData = "Cancel confirmation",
                        TrackingNumber = transaction.TrackingNumber
                    });

                    // Update the Transaction properties
                    transaction.ProcessingResults = cancelLoadMoneyResult.ResponseCode > 0
                        ? $"*{cancelLoadMoneyResult.ResponseCode}:  {cancelLoadMoneyResult.ResponseMessage} | BALANCE:  {cardInquiryResult.CardBalance:c} -> {cancelConfirmationCardInquiryResult.CardBalance:c}"
                        : $"{transaction.Amount:c} CANCELLED | BALANCE:  {cardInquiryResult.CardBalance:c} -> {cancelConfirmationCardInquiryResult.CardBalance:c}";
                }

                sw.Stop();
                ConsoleWriteTimestampLine($"{transaction.IndividualName} -- {transaction.ProcessingResults} -- Runtime:  {sw.Elapsed.TotalSeconds:N0}s");

                // Output XML debug info (if operation failed)
                if (!operationResult)
                    ConsoleWriteXml(cancelRequestXml, cancelResponseXml);

                // Return whether the request succeeded
                return operationResult;
            }
            catch (TimeoutException timeProblem)
            {
                transaction.ProcessingResults = "*OPERATION TIMED OUT";
                ConsoleWriteErrorLine("The service operation timed out.", timeProblem);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
            catch (FaultException unknownFault)
            {
                transaction.ProcessingResults = "*UNKNOWN EXCEPTION";
                ConsoleWriteErrorLine("An unknown exception was received.", unknownFault);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
            catch (CommunicationException commProblem)
            {
                transaction.ProcessingResults = "*COMMUNICATION PROBLEM";
                ConsoleWriteErrorLine("There was a communication problem.", commProblem);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
            catch (Exception ex)
            {
                transaction.ProcessingResults = $"*{ex.GetType().Name.ToUpper()}";
                ConsoleWriteErrorLine($"An {ex.GetType().Name} occurred while processing the Comdata transaction--{transaction.IndividualName}: {transaction.Amount}!", ex);

                // Output XML debug info
                ConsoleWriteXml(soapInspector);

                return false;
            }
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
    }
}
