using Comdata.Exceptions;
using Comdata.Models.Internals;
using Comdata.RealTimeOnline0103.Enumerations;
using Comdata.RealTimeOnline0103.Models;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Comdata.RealTimeOnline0103
{
    [DebuggerStepThrough()]
    public partial class RealTimeOnline0103Client : ClientBase<IRealTimeOnline0103>
    {
        private string? _securityCardNumber;



        #region Constructors

        public RealTimeOnline0103Client() : base(GetDefaultBinding(), GetDefaultEndpointAddress())
        {
            Endpoint.Name = ComdataEndpointType.Production.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public RealTimeOnline0103Client(string remoteAddress) : base(GetDefaultBinding(), GetEndpointAddress(remoteAddress))
        {
            Endpoint.Name = ComdataEndpointType.Production.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public RealTimeOnline0103Client(ComdataEndpointType endpointConfiguration) : base(GetDefaultBinding(), GetEndpointAddress(endpointConfiguration))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public RealTimeOnline0103Client(ComdataEndpointType endpointConfiguration, string remoteAddress) : base(GetDefaultBinding(), new EndpointAddress(remoteAddress))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public RealTimeOnline0103Client(ComdataEndpointType endpointConfiguration, EndpointAddress remoteAddress) : base(GetDefaultBinding(), remoteAddress)
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public RealTimeOnline0103Client(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

        #endregion Constructors



        #region Card Webservice Methods

        /// <summary>
        /// Modifies the status of a Proprietary Card.  Alternatively, proprietary card status can also be modified by using the Proprietary Card Update 1.0 function.
        /// The requestor has the option of which function(s) they would like to use to perform proprietary card maintenance.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardNumber">This is the card that needs to be modified. Include full 10-digit card number. The 6 digit BIN '560017' is not required for proprietary cards.</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record.</param>
        /// <param name="trackingNumber">Any Number</param>
        /// <param name="cardActive">TRUE or FALSE</param>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        /// <returns></returns>
        public async Task<bool> CardBlockUnblockAsync(string accountCode, string cardNumber, string customerId,
            string discretionaryData = "", long? trackingNumber = null, bool cardActive = true)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardBlockUnblockRequest
            {
                AccountCode = accountCode,
                CardNumber = cardNumber,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,
                CardActive = cardActive,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.CardBlockUnblockAsync, new CardBlockUnblockRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }



        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.  No card updates are performed.It is an information only request.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardNumber">This is the card that needs to be inquired upon.  Include full 10-digit card number.
        /// The 6 digit BIN '560017' is not required on proprietary cards.</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit CustomerId's is optional.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardInquiryResponseV01> CardInquiryAsync(string accountCode, string cardNumber, string customerId,
            string discretionaryData = "", long? trackingNumber = null)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardInquiryRequestV01
            {
                AccountCode = accountCode,
                CardNumber = cardNumber,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.CardInquiryAsync, new CardInquiryRequestV01Body(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.  No card updates are performed.It is an information only request.
        /// Card inquiry by token has been introduced in this updated version.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardIdentifier">This is the card number, employee number, or token number that needs to be inquired upon.
        /// Include full 10-digit card number.  The 6-digit BIN '560017' is not required on proprietary cards.</param>
        /// <param name="cardIdentifierType">Value T or C or E to identify the type of card identifier.</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <param name="maskCard">If TRUE, the cardNumber value will be masked in the response.</param>
        /// <returns>current attributes of a Comdata Proprietary Card.</returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardInquiryResponseV02> CardInquiryV02Async(string accountCode, string cardIdentifier, CardIdentifierType? cardIdentifierType, string customerId,
            string discretionaryData = "", long? trackingNumber = null, bool maskCard = false)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardInquiryRequestV02
            {
                AccountCode = accountCode,
                CardIdentifier = cardIdentifier,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,
                MaskCardFlag = maskCard ? "Y" : "N",
                CardIdentifierType = cardIdentifierType,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.CardInquiryV02Async, new CardInquiryRequestV02Body(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.  No card updates are performed.It is an information only request.
        /// Card inquiry by token has been introduced in this updated version.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardIdentifier">This is the card number, employee number, or token number that needs to be inquired upon.
        /// Include full 10-digit card number.  The 6-digit BIN '560017' is not required on proprietary cards.</param>
        /// <param name="cardIdentifierType">Value T or C or E to identify the type of card identifier.</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <param name="maskCard">If TRUE, the cardNumber value will be masked in the response.</param>
        /// <returns>current attributes of a Comdata Proprietary Card.</returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardInquiryResponseV03> CardInquiryV03Async(string accountCode, string cardIdentifier, CardIdentifierType cardIdentifierType, string customerId,
            string discretionaryData = "", long? trackingNumber = null, bool maskCard = false)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardInquiryRequestV03
            {
                AccountCode = accountCode,
                CardIdentifier = cardIdentifier,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,
                MaskCardFlag = maskCard ? "Y" : "N",
                CardIdentifierType = cardIdentifierType,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.CardInquiryV03Async, new CardInquiryRequestV03Body(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }



        /// <summary>
        /// Transfers a card from one customer ID to another.
        /// </summary>
        /// <param name="accountCode">5-digit alphanumeric account code</param>
        /// <param name="cardNumber"></param>
        /// <param name="customerId">4- or 5-digit customer ID under which the card was assigned</param>
        /// <param name="moveFromAccountCode"></param>
        /// <param name="moveFromCustomerId"></param>
        /// <param name="moveToAccountCode"></param>
        /// <param name="moveToCustomerId"></param>
        /// <param name="discretionaryData"></param>
        /// <param name="trackingNumber"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<bool> CardMoveMaintenanceAsync(string accountCode, string cardNumber, string customerId,
            string moveFromAccountCode, string moveFromCustomerId, string moveToAccountCode, string moveToCustomerId,
            string discretionaryData = "", long? trackingNumber = null)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardMoveMaintenanceRequest
            {
                AccountCode = accountCode,
                CardNumber = cardNumber,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,

                MoveFromAccountCode = moveFromAccountCode,
                MoveFromCustomerId = moveFromCustomerId,
                MoveToAccountCode = moveToAccountCode,
                MoveToCustomerId = moveToCustomerId,
                MoveSecurityCode = _securityCardNumber,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.CardMoveMaintenanceAsync, new CardMoveMaintenanceRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        /// <summary>
        /// Transfers card values from one card to an unassigned card under the same account code and customer ID.
        /// </summary>
        /// <param name="accountCode">5-digit alphanumeric account code</param>
        /// <param name="customerId">4- or 5-digit customer ID under which the card was assigned</param>
        /// <param name="cardAccountCode">The account code under which the cards are assigned</param>
        /// <param name="cardCustomerId">The customer ID under which the cards are assigned.  For a 4-digit customer ID, include a leading zero.  A 5-digit customer ID must be left justified.</param>
        /// <param name="transferFromCardNumber">The number of the card being transferred.</param>
        /// <param name="transferToCardNumber">The number of the card receiving the data transferred.</param>
        /// <param name="discretionaryData">Any discretionary data (optional). Will be truncated to 10 characters.</param>
        /// <param name="trackingNumber">Any number (data type: long)</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<bool> CardTransferMaintenanceAsync(string accountCode, string customerId,
            string cardAccountCode, string cardCustomerId, string transferFromCardNumber, string transferToCardNumber,
            string discretionaryData = "", long? trackingNumber = null)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardTransferMaintenanceRequest
            {
                AccountCode = accountCode,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,

                CardAccountCode = cardAccountCode,
                CardCustomerId = cardCustomerId,
                TransferFromCardNumber = transferFromCardNumber,
                TransferToCardNumber = transferToCardNumber,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.TransferMaintenanceAsync, new CardTransferMaintenanceRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }



        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<bool> CardUpdateAsync(CardUpdateRequestV01 request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.CardUpdateAsync, new CardUpdateRequestV01Body(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<bool> CardUpdateV02Async(CardUpdateRequestV02 request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            // Send the request
            var response = await SendAsync(Channel.CardUpdateV02Async, new CardUpdateRequestV02Body(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<bool> CardUpdateV03Async(CardUpdateRequestV03 request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            // Send the request
            var response = await SendAsync(Channel.CardUpdateV03Async, new CardUpdateRequestV03Body(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }



        public async Task<TrackCardShipment[]> TrackCardShipmentStatusAsync(string accountCode, string customerId, string dateType, string startDate, string endDate)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new TrackCardShipmentRequest
            {
                AccountCode = accountCode,
                CustomerId = customerId,
                DateType = dateType,
                StartDate = startDate,
                EndDate = endDate,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.TrackCardShipmentStatusAsync, new TrackCardShipmentRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.TrackCardShipments;
        }

        #endregion Card Webservice Methods

        #region Direct Deposit Webservice Methods

        /// <summary>
        /// Adds or updates an employee's direct deposit record.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DirectDepositAddUpdateResponse> DirectDepositAddUpdateAsync(DirectDepositAddUpdateRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.DirectDepositAddUpdateAsync, new DirectDepositAddUpdateRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Inquires into the direct deposit information set up for an employee.
        /// </summary>
        /// <param name="accountCode">5-digit alphanumeric account code</param>
        /// <param name="customerId">4- or 5-digit customer ID under which the card was assigned</param>
        /// <param name="employeeCustomerId">Customer ID of the employee with the direct deposit account</param>
        /// <param name="employeeNumber">Employee number assigned to this card</param>
        /// <param name="discretionaryData">Any discretionary data (optional). Will be truncated to 10 characters.</param>
        /// <param name="trackingNumber">Any number (data type: long)</param>
        /// <returns></returns>
        public async Task<DirectDepositInquiryResponse> DirectDepositInquiryAsync(string accountCode, string customerId, string employeeCustomerId, string employeeNumber,
            string discretionaryData = "", long? trackingNumber = null)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new DirectDepositInquiryRequest
            {
                AccountCode = accountCode,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,

                EmployeeCustomerId = employeeCustomerId,
                EmployeeNumber = employeeNumber,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.DirectDepositInquiryAsync, new DirectDepositInquiryRequestBody(request));

            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        #endregion Direct Deposit Webservice Methods

        #region Limited Network Webservice Methods

        /// <summary>
        /// Adds, updates (replace), or deletes records tied to a card number for customers using the limited network feature.You can enable a one-time purchase at any
        /// location code by not specifying a location code.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> LimitedNetworkByCardUpdateAsync(LimitedNetworkByCardUpdateRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.LimitedNetworkByCardUpdateAsync, new LimitedNetworkByCardUpdateRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        #endregion Limited Network Webservice Methods

        #region Express Cash Webservice Methods

        /// <summary>
        /// Requests Express Check Seed Code. Express Check Seed Code are part of the key building blocks used in calculating Express Check codes.Instructions for
        /// calculating Express Check codes are provided separately upon request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ExpressCheckBatchResponse> ExpressCheckBatchAsync(ExpressCheckBatchRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.ExpressCheckBatchAsync, new ExpressCheckBatchRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Provides the customer a general purpose inquiry into the status, properties, and last useage of an Express Check Code.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="pin">PIN Number</param>
        /// <param name="sequenceNumber">Digits 6-10 of the Express Check Code</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <returns></returns>
        public async Task<ExpressCheckInquiryResponse> ExpressCheckInquiryAsync(string accountCode, string customerId, string pin, string sequenceNumber, string discretionaryData = "", long? trackingNumber = null)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new ExpressCheckInquiryRequest
            {
                AccountCode = accountCode,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,

                Pin = pin,
                SequenceNumber = sequenceNumber,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.ExpressCheckInquiryAsync, new ExpressCheckInquiryRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Used by customers who have established internal processes in adherence to Comdata's Express Check Code Calculation Instructions 
        /// (provided separately upon request) to calculate their own Express Check codes.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ExpressCheckIssueResponse> ExpressCheckIssueAsync(ExpressCheckIssueRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.ExpressCheckIssueAsync, new ExpressCheckIssueRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Changes the status of an Express Check Code.It is important to note that other values assigned to an Express Check code at the time of Retrieval or
        /// Issuance such as amount, driver number, first name, last name, location code, purpose code, trip number, and unit number cannot be altered.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ExpressCheckMaintenanceResponse> ExpressCheckMaintenanceAsync(ExpressCheckMaintenanceRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.ExpressCheckMaintenanceAsync, new ExpressCheckMaintenanceRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Request Express Codes from Comdata. Customer specific setup within the Comdata host determines which fields are required; contact Comdata for details.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ExpressCheckRetrievalResponse> ExpressCheckRetrievalAsync(ExpressCheckRetrievalRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.ExpressCheckRetrievalAsync, new ExpressCheckRetrievalRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }



        /// <summary>
        /// Used for adding or subtracting money to/from a card's Express Cash Balance.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<LoadMoneyResponse> LoadMoneyAsync(LoadMoneyRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.LoadMoneyAsync, new LoadMoneyRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Cancel Express Cash Loads.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> LoadMoneyCancelAsync(LoadMoneyCancelRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.LoadMoneyCancelAsync, new LoadMoneyCancelRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        /// <summary>
        /// Sends money to registered Comchek Mobile users.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<LoadMoneyComchekResponse> LoadMoneyComchekAsync(LoadMoneyComchekRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.LoadMoneyComchekAsync, new LoadMoneyComchekRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        #endregion Express Cash Webservice Methods

        #region Location Webservice Methods

        /// <summary>
        /// Makes updates to a merchant network location, including updates to fueling and cash back limits and restrictions on product codes.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> LocationMaintenanceAsync(LocationMaintenanceRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.LocationMaintenanceAsync, new LocationMaintenanceRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        #endregion Location Webservice Methods

        #region PIN Webservice Methods

        /// <summary>
        /// Establishes a card's PIN (Personal Identification Number).
        /// Encryption algorithm instructions are detailed in a separate document. Please consult your Comdata Technical Representative.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardNumber">Full 16-digit card number. (BIN required).</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="pin">Encryption algorithm instructions provided in separate document.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <returns></returns>
        public async Task<bool> PinSetAsync(string accountCode, string cardNumber, string customerId, string pin, string? discretionaryData = null, long? trackingNumber = null)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new PinSetRequest
            {
                AccountCode = accountCode,
                CardNumber = cardNumber,
                CustomerId = customerId,
                Pin = pin,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.PinSetAsync, new PinSetRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        /// <summary>
        /// Reset a card's PIN (Personal Indentification Number).  Once complete, a new PIN is then able to be assigned to a card.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardNumber">Full 16-digit card number. (BIN required).</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <returns></returns>
        public async Task<bool> PinResetAsync(string accountCode, string cardNumber, string customerId, string? discretionaryData = null, long? trackingNumber = null)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new PinResetRequest
            {
                AccountCode = accountCode,
                CardNumber = cardNumber,
                CustomerId = customerId,
                DiscretionaryData = discretionaryData,
                TrackingNumber = trackingNumber,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.PinResetAsync, new PinResetRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        #endregion PIN Webservice Methods

        #region Transfer Webservice Methods

        public async Task<bool> TransferToBankAsync(TransferToBankRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.TransferToBankAsync, new TransferToBankRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        public async Task<TransferMaintenanceByCardtokenResponse> TransferMaintenanceByCardtokenAsync(TransferMaintenanceByCardtokenRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.TransferMaintenanceByCardtokenAsync, new TransferMaintenanceByCardtokenRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        #endregion Transfer Webservice Methods

        #region Virtual Card Webservice Methods

        /// <summary>
        /// Requests a Comdata Virtual MasterCard.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<VirtualCardAddResponse> VirtualCardAddAsync(VirtualCardAddRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.VirtualCardAddAsync, new VirtualCardAddRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Inquires the current attributes of an existing Comdata Virtual MasterCard.No card updates are performed.  It is an information only request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<VirtualCardInquiryResponse> VirtualCardInquiryAsync(VirtualCardInquiryRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.VirtualCardInquiryAsync, new VirtualCardInquiryRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Make updates to an existing Comdata Virtual MasterCard.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> VirtualCardUpdateAsync(VirtualCardUpdateRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.VirtualCardUpdateAsync, new VirtualCardUpdateRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        #endregion Virtual Card Webservice Methods

        #region Virtual Comchek Webservice Methods

        /// <summary>
        /// Requests a Comdata Virtual Comchek Card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<VirtualComchekAddResponse> VirtualComchekAddAsync(VirtualComchekAddRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Send the request
            var response = await SendAsync(Channel.VirtualComchekAddAsync, new VirtualComchekAddRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Inquires the current attributes of an existing Comdata Virtual Comchek.  No card updates are performed.  It is an information only request.
        /// </summary>
        /// <param name="accountCode">5-digit alphanumeric account code</param>
        /// <param name="customerId">4- or 5-digit customer ID under which the card was assigned</param>
        /// <param name="cardNumber">Full 16 digit Comdata MasterCard number.</param>
        /// <param name="discretionaryData">Any discretionary data (optional). Will be truncated to 10 characters.</param>
        /// <returns></returns>
        public async Task<VirtualComchekInquiryResponse> VirtualComchekInquiryAsync(string accountCode, string customerId, string cardNumber,
            string discretionaryData = "")
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new VirtualComchekInquiryRequest
            {
                AccountCode = accountCode,
                CustomerId = customerId,
                CardNumber = cardNumber,
                DiscretionaryData = discretionaryData,

                SignOnName = ClientCredentials.Windows.ClientCredential.UserName,
                Password = ClientCredentials.Windows.ClientCredential.Password,
                SecurityInfo = _securityCardNumber
            };

            // Send the request
            var response = await SendAsync(Channel.VirtualComchekInquiryAsync, new VirtualComchekInquiryRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// Makes updates to an existing Comdata Virtual Comchek card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> VirtualComchekUpdateAsync(VirtualComchekUpdateRequest request)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var response = await SendAsync(Channel.VirtualComchekUpdateAsync, new VirtualComchekUpdateRequestBody(request));

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

            // Return the result of the operation
            return response.Content.ResponseCode == 0;
        }

        #endregion Virtual Comchek Webservice Methods



        #region Endpoint Helper Methods

        private static Binding GetDefaultBinding()
        {
            var securityElement = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
            securityElement.IncludeTimestamp = false;
            securityElement.MessageSecurityVersion = MessageSecurityVersion.WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10;

            var encodingElement = new TextMessageEncodingBindingElement
            {
                MessageVersion = MessageVersion.Soap11
            };

            var transportElement = new HttpsTransportBindingElement
            {
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true
            };

            return new CustomBinding(securityElement, encodingElement, transportElement);
        }



        private static EndpointAddress GetDefaultEndpointAddress() => GetEndpointAddress(ComdataEndpointType.Production);

        private static EndpointAddress GetEndpointAddress(ComdataEndpointType endpointConfiguration)
        {
            return endpointConfiguration switch
            {
                ComdataEndpointType.Test => new EndpointAddress("https://w8cert.iconnectdata.com/cows/services/RealTimeOnline0103"),
                ComdataEndpointType.Production => new EndpointAddress("https://w6.iconnectdata.com/cows/services/RealTimeOnline0103"),
                _ => throw new InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration)),
            };
        }

        private static EndpointAddress GetEndpointAddress(string uriAddress) => new EndpointAddress(uriAddress);  //new EndpointAddress(new Uri(uriAddress));



        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        #endregion Endpoint Helper Methods

        #region Authentication Helper Methods

        /// <summary>
        /// Update the cached Comdata user credentials
        /// </summary>
        /// <param name="serviceUserName"></param>
        /// <param name="servicePassword"></param>
        /// <param name="networkUserName"></param>
        /// <param name="networkPassword"></param>
        /// <param name="securityCardNumber"></param>
        public void SetCredentials(string serviceUserName, string servicePassword, string networkUserName, string networkPassword, string securityCardNumber)
        {
            SetServiceCredentials(serviceUserName, servicePassword);
            SetNetworkCredentials(networkUserName, networkPassword);
            SetSecurityCard(securityCardNumber);
        }

        /// <summary>
        /// Set the WSSE UserName Token credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void SetServiceCredentials(string userName, string password)
        {
            ClientCredentials.UserName.UserName = userName;
            ClientCredentials.UserName.Password = password;
        }

        /// <summary>
        /// Set the WebSphere Active Directory Credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void SetNetworkCredentials(string userName, string password)
        {
            ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            ClientCredentials.Windows.ClientCredential.Domain = "";
            ClientCredentials.Windows.ClientCredential.UserName = userName;
            ClientCredentials.Windows.ClientCredential.Password = password;
        }

        /// <summary>
        /// Set the WebSphere Active Directory Credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void SetSecurityCard(string securityCardNumber)
        {
            _securityCardNumber = securityCardNumber;
        }



        /// <summary>
        /// Ensures that all credentials have been provided.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        private void ValidateCredentials()
        {
            // Service Credentials
            if (string.IsNullOrWhiteSpace(ClientCredentials.UserName.UserName) || string.IsNullOrWhiteSpace(ClientCredentials.UserName.Password))
                throw new ArgumentException("The 'Service Credentials' are incomplete.");

            // Network Credentials
            if (string.IsNullOrWhiteSpace(ClientCredentials.Windows.ClientCredential.UserName) || string.IsNullOrWhiteSpace(ClientCredentials.Windows.ClientCredential.Password))
                throw new ArgumentException("The 'Network Credentials' are incomplete.");

            // Security Card
            if (string.IsNullOrWhiteSpace(_securityCardNumber))
                throw new ArgumentException("No 'Security Card Number' has been provided.");
        }

        #endregion Authentication Helper Methods

        #region Factory Helper Methods

        public virtual Task OpenAsync()
            => Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndOpen));

        public virtual Task CloseAsync()
            => Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginClose(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndClose));

        #endregion Factory Helper Methods

        #region Webservice Helper Methods

        private async Task<TResponse> SendAsync<TRequest, TResponse>(Func<TRequest, Task<TResponse>> operation, TRequest request)
            where TRequest : class, IRequest, new()
            where TResponse : class, IResponse, new()
        {
            try
            {
                return await operation(request);
            }
            catch (FaultException<BusinessException> ex)
            {
                throw new ComdataBusinessException(Convert.ToInt32(ex.Detail.MessageCode), ex.Detail.Message ?? $"An {ex.GetType().Name} occurred while executing the request.", ex);
            }
            catch (FaultException ex)
            {
                throw new ComdataOperationException($"An {ex.GetType().Name} occurred while executing the request.", ex);
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion Webservice Helper Methods
    }
}