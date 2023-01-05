﻿using Comdata.RealTimeOnline0103.Models;
using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Comdata.FleetCreditWS0200.Exceptions;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using Comdata.FleetCreditWS0200.Enumerations;
using System.Security.AccessControl;

namespace Comdata.RealTimeOnline0103
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class RealTimeOnline0103Client : System.ServiceModel.ClientBase<IRealTimeOnline0103>
    {
        private string _securityCardNumber = string.Empty;



=======

namespace Comdata.RealTimeOnline0103
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class RealTimeOnline0103Client : System.ServiceModel.ClientBase<IRealTimeOnline0103>
    {
>>>>>>> releases/v1.0.0
        #region Constructors

        public RealTimeOnline0103Client() : base(RealTimeOnline0103Client.GetDefaultBinding(), RealTimeOnline0103Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.RealTimeOnline0103.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public RealTimeOnline0103Client(string remoteAddress) : base(RealTimeOnline0103Client.GetDefaultBinding(), RealTimeOnline0103Client.GetEndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = EndpointConfiguration.RealTimeOnline0103.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public RealTimeOnline0103Client(EndpointConfiguration endpointConfiguration) : base(RealTimeOnline0103Client.GetBindingForEndpoint(endpointConfiguration), RealTimeOnline0103Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public RealTimeOnline0103Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : base(RealTimeOnline0103Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public RealTimeOnline0103Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : base(RealTimeOnline0103Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public RealTimeOnline0103Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

        #endregion Constructors

<<<<<<< HEAD


        #region Card Webservice Methods
=======
        #region Webservice Methods
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Modifies the status of a Proprietary Card.  Alternatively, proprietary card status can also be modified by using the Proprietary Card Update 1.0 function.
        /// The requestor has the option of which function(s) they would like to use to perform proprietary card maintenance.
        /// </summary>
<<<<<<< HEAD
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
        public async Task<CardBlockUnblockResponse?> CardBlockUnblockAsync(string accountCode, string cardNumber, string customerId, 
            string discretionaryData = "", long? trackingNumber = null, bool cardActive = true)
        {
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

            try
            {
                var response = await SendAsync(Channel.CardBlockUnblockAsync, new CardBlockUnblockRequestBody(request));
                
                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }


=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardBlockUnblockResponse> CardBlockUnblockAsync(CardBlockUnblockRequest request)
            => ExecuteSoapRequestAsync<CardBlockUnblockRequest, CardBlockUnblockRequestBody, CardBlockUnblockResponse, CardBlockUnblockResponseBody>(Channel.CardBlockUnblockAsync, request);
        /*public async System.Threading.Tasks.Task<CardBlockUnblockResponse?> CardBlockUnblockAsync(CardBlockUnblockRequest request) 
            => (await base.Channel.CardBlockUnblockAsync(new CardBlockUnblockRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.  No card updates are performed.It is an information only request.
        /// </summary>
<<<<<<< HEAD
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

            try
            {
                var response = await SendAsync(Channel.CardInquiryAsync, new CardInquiryRequestV01Body(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardInquiryResponseV01> CardInquiryAsync(CardInquiryRequestV01 request)
            => ExecuteSoapRequestAsync<CardInquiryRequestV01, CardInquiryRequestV01Body, CardInquiryResponseV01, CardInquiryResponseV01Body>(Channel.CardInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<CardInquiryResponse?> CardInquiryAsync(CardInquiryRequest request)
            => (await base.Channel.CardInquiryAsync(new CardInquiryRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.  No card updates are performed.It is an information only request.
        /// Card inquiry by token has been introduced in this updated version.
        /// </summary>
<<<<<<< HEAD
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
        public async Task<CardInquiryResponseV02> CardInquiryV02Async(string accountCode, string cardIdentifier, CardIdentifierType cardIdentifierType, string customerId, 
            string discretionaryData = "", long? trackingNumber = null, bool maskCard = false)
        {
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

            try
            {
                var response = await SendAsync(Channel.CardInquiryV02Async, new CardInquiryRequestV02Body(request));
                //var response = await SendAsync<CardInquiryRequestV02, CardInquiryRequestV02Body, CardInquiryResponseV02, CardInquiryResponseV02Body>(Channel.CardInquiryV02Async, request);

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
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

            try
            {
                var response = await SendAsync(Channel.CardInquiryV03Async, new CardInquiryRequestV03Body(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }


=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardInquiryResponseV02> CardInquiryV02Async(CardInquiryRequestV02 request)
            => ExecuteSoapRequestAsync<CardInquiryRequestV02, CardInquiryRequestV02Body, CardInquiryResponseV02, CardInquiryResponseV02Body>(Channel.CardInquiryV02Async, request);
        /*public async System.Threading.Tasks.Task<CardInquiryResponseV02> CardInquiryV02Async(CardInquiryRequestV02 request)
            => (await base.Channel.CardInquiryV02Async(new CardInquiryRequestBodyV02(request))).Response;*/

        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.No card updates are performed.  It is an information only request.
        /// Card inquiry by token has been introduced in this updated version.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardInquiryResponseV03> CardInquiryV03Async(CardInquiryRequestV03 request)
            => ExecuteSoapRequestAsync<CardInquiryRequestV03, CardInquiryRequestV03Body, CardInquiryResponseV03, CardInquiryResponseV03Body>(Channel.CardInquiryV03Async, request);
        /*public async System.Threading.Tasks.Task<CardInquiryResponseV03> CardInquiryV03Async(CardInquiryRequestV03 request)
            => (await base.Channel.CardInquiryV03Async(new CardInquiryRequestV03Body(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Transfers a card from one customer ID to another.
        /// </summary>
<<<<<<< HEAD
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
        public async Task<CardMoveMaintenanceResponse> CardMoveMaintenanceAsync(string accountCode, string cardNumber, string customerId,
            string moveFromAccountCode, string moveFromCustomerId, string moveToAccountCode, string moveToCustomerId,
            string discretionaryData = "", long? trackingNumber = null)
        {
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

            try
            {
                var response = await SendAsync(Channel.CardMoveMaintenanceAsync, new CardMoveMaintenanceRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardMoveMaintenanceResponse> CardMoveMaintenanceAsync(CardMoveMaintenanceRequest request)
            => ExecuteSoapRequestAsync<CardMoveMaintenanceRequest, CardMoveMaintenanceRequestBody, CardMoveMaintenanceResponse, CardMoveMaintenanceResponseBody>(Channel.CardMoveMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<CardMoveMaintenanceResponse> CardMoveMaintenanceAsync(CardMoveMaintenanceRequest request)
            => (await base.Channel.CardMoveMaintenanceAsync(new CardMoveMaintenanceRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Transfers card values from one card to an unassigned card under the same account code and customer ID.
        /// </summary>
<<<<<<< HEAD
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
        public async Task<CardTransferMaintenanceResponse> CardTransferMaintenanceAsync(string accountCode, string customerId, 
            string cardAccountCode, string cardCustomerId, string transferFromCardNumber, string transferToCardNumber,
            string discretionaryData = "", long? trackingNumber = null)
        {
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

            try
            {
                var response = await SendAsync(Channel.TransferMaintenanceAsync, new CardTransferMaintenanceRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }


=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardTransferMaintenanceResponse> CardTransferMaintenanceAsync(CardTransferMaintenanceRequest request)
            => ExecuteSoapRequestAsync<CardTransferMaintenanceRequest, CardTransferMaintenanceRequestBody, CardTransferMaintenanceResponse, CardTransferMaintenanceResponseBody>(Channel.TransferMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<TransferMaintenanceResponse> TransferMaintenanceAsync(TransferMaintenanceRequest request)
            => (await base.Channel.TransferMaintenanceAsync(new TransferMaintenanceRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardUpdateResponseV01> CardUpdateAsync(CardUpdateRequestV01 request)
        {
            try
            {
                var response = await SendAsync(Channel.CardUpdateAsync, new CardUpdateRequestV01Body(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<CardUpdateResponseV01> CardUpdateAsync(CardUpdateRequestV01 request)
            => ExecuteSoapRequestAsync<CardUpdateRequestV01, CardUpdateRequestV01Body, CardUpdateResponseV01, CardUpdateResponseV01Body>(Channel.CardUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<CardUpdateResponseV01> CardUpdateAsync(CardUpdateRequestV01 request)
            => (await base.Channel.CardUpdateAsync(new CardUpdateRequestV01Body(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardUpdateResponseV02> CardUpdateV02Async(CardUpdateRequestV02 request)
        {
            try
            {
                var response = await SendAsync(Channel.CardUpdateV02Async, new CardUpdateRequestV02Body(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<CardUpdateResponseV02> CardUpdateV02Async(CardUpdateRequestV02 request)
            => ExecuteSoapRequestAsync<CardUpdateRequestV02, CardUpdateRequestV02Body, CardUpdateResponseV02, CardUpdateResponseV02Body>(Channel.CardUpdateV02Async, request);
        /*public async System.Threading.Tasks.Task<CardUpdateResponseV02> CardUpdateV02Async(CardUpdateRequestV02 request)
            => (await base.Channel.CardUpdateV02Async(new CardUpdateRequestV02Body(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        /// <exception cref="ComdataException"></exception>
        /// <exception cref="ComdataBusinessException"></exception>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardUpdateResponseV03> CardUpdateV03Async(CardUpdateRequestV03 request)
        {
            try
            {
                var response = await SendAsync(Channel.CardUpdateV03Async, new CardUpdateRequestV03Body(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
        


        public async Task<TrackCardShipmentResponse> TrackCardShipmentStatusAsync(string accountCode, string customerId, string dateType, string startDate, string endDate)
        {
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

            try
            {
                var response = await SendAsync(Channel.TrackCardShipmentStatusAsync, new TrackCardShipmentRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
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
            try
            {
                var response = await SendAsync(Channel.DirectDepositAddUpdateAsync, new DirectDepositAddUpdateRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
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

            try
            {
                var response = await SendAsync(Channel.DirectDepositInquiryAsync, new DirectDepositInquiryRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion Direct Deposit Webservice Methods

        #region Limited Network Webservice Methods

        /// <summary>
        /// Adds, updates (replace), or deletes records tied to a card number for customers using the limited network feature.You can enable a one-time purchase at any
        /// location code by not specifying a location code.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<LimitedNetworkByCardUpdateResponse> LimitedNetworkByCardUpdateAsync(LimitedNetworkByCardUpdateRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.LimitedNetworkByCardUpdateAsync, new LimitedNetworkByCardUpdateRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion Limited Network Webservice Methods

        #region Express Cash Webservice Methods
=======
        public Task<CardUpdateResponseV03> CardUpdateV03Async(CardUpdateRequestV03 request)
            => ExecuteSoapRequestAsync<CardUpdateRequestV03, CardUpdateRequestV03Body, CardUpdateResponseV03, CardUpdateResponseV03Body>(Channel.CardUpdateV03Async, request);
        /*public async System.Threading.Tasks.Task<CardUpdateResponseV03> CardUpdateV03Async(CardUpdateRequestV03 request)
            => (await base.Channel.CardUpdateV03Async(new CardUpdateRequestV03Body(request))).Response;*/


>>>>>>> releases/v1.0.0

        /// <summary>
        /// Requests Express Check Seed Code. Express Check Seed Code are part of the key building blocks used in calculating Express Check codes.Instructions for
        /// calculating Express Check codes are provided separately upon request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<ExpressCheckBatchResponse> ExpressCheckBatchAsync(ExpressCheckBatchRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.ExpressCheckBatchAsync, new ExpressCheckBatchRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<ExpressCheckBatchResponse> ExpressCheckBatchAsync(ExpressCheckBatchRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckBatchRequest, ExpressCheckBatchRequestBody, ExpressCheckBatchResponse, ExpressCheckBatchResponseBody>(Channel.ExpressCheckBatchAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckBatchResponse> ExpressCheckBatchAsync(ExpressCheckBatchRequest request)
            => (await base.Channel.ExpressCheckBatchAsync(new ExpressCheckBatchRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Provides the customer a general purpose inquiry into the status, properties, and last useage of an Express Check Code.
        /// </summary>
<<<<<<< HEAD
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="pin">PIN Number</param>
        /// <param name="sequenceNumber">Digits 6-10 of the Express Check Code</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <returns></returns>
        public async Task<ExpressCheckInquiryResponse> ExpressCheckInquiryAsync(string accountCode, string customerId, string pin, string sequenceNumber, string discretionaryData = "", long? trackingNumber = null)
        {
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

            try
            {
                var response = await SendAsync(Channel.ExpressCheckInquiryAsync, new ExpressCheckInquiryRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ExpressCheckInquiryResponse> ExpressCheckInquiryAsync(ExpressCheckInquiryRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckInquiryRequest, ExpressCheckInquiryRequestBody, ExpressCheckInquiryResponse, ExpressCheckInquiryResponseBody>(Channel.ExpressCheckInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckInquiryResponse> ExpressCheckInquiryAsync(ExpressCheckInquiryRequest request)
            => (await base.Channel.ExpressCheckInquiryAsync(new ExpressCheckInquiryRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Used by customers who have established internal processes in adherence to Comdata's Express Check Code Calculation Instructions 
        /// (provided separately upon request) to calculate their own Express Check codes.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<ExpressCheckIssueResponse> ExpressCheckIssueAsync(ExpressCheckIssueRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.ExpressCheckIssueAsync, new ExpressCheckIssueRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<ExpressCheckIssueResponse> ExpressCheckIssueAsync(ExpressCheckIssueRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckIssueRequest, ExpressCheckIssueRequestBody, ExpressCheckIssueResponse, ExpressCheckIssueResponseBody>(Channel.ExpressCheckIssueAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckIssueResponse> ExpressCheckIssueAsync(ExpressCheckIssueRequest request)
            => (await base.Channel.ExpressCheckIssueAsync(new ExpressCheckIssueRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Changes the status of an Express Check Code.It is important to note that other values assigned to an Express Check code at the time of Retrieval or
        /// Issuance such as amount, driver number, first name, last name, location code, purpose code, trip number, and unit number cannot be altered.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<ExpressCheckMaintenanceResponse> ExpressCheckMaintenanceAsync(ExpressCheckMaintenanceRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.ExpressCheckMaintenanceAsync, new ExpressCheckMaintenanceRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<ExpressCheckMaintenanceResponse> ExpressCheckMaintenanceAsync(ExpressCheckMaintenanceRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckMaintenanceRequest, ExpressCheckMaintenanceRequestBody, ExpressCheckMaintenanceResponse, ExpressCheckMaintenanceResponseBody>(Channel.ExpressCheckMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckMaintenanceResponse> ExpressCheckMaintenanceAsync(ExpressCheckMaintenanceRequest request)
            => (await base.Channel.ExpressCheckMaintenanceAsync(new ExpressCheckMaintenanceRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Request Express Codes from Comdata. Customer specific setup within the Comdata host determines which fields are required; contact Comdata for details.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<ExpressCheckRetrievalResponse> ExpressCheckRetrievalAsync(ExpressCheckRetrievalRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.ExpressCheckRetrievalAsync, new ExpressCheckRetrievalRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        
=======
        public Task<ExpressCheckRetrievalResponse> ExpressCheckRetrievalAsync(ExpressCheckRetrievalRequest request)
          => ExecuteSoapRequestAsync<ExpressCheckRetrievalRequest, ExpressCheckRetrievalRequestBody, ExpressCheckRetrievalResponse, ExpressCheckRetrievalResponseBody>(Channel.ExpressCheckRetrievalAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckRetrievalResponse> ExpressCheckRetrievalAsync(ExpressCheckRetrievalRequest request)
            => (await base.Channel.ExpressCheckRetrievalAsync(new ExpressCheckRetrievalRequestBody(request))).Response;*/



        /// <summary>
        /// Adds or updates an employee's direct deposit record.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<DirectDepositAddUpdateResponse> DirectDepositAddUpdateAsync(DirectDepositAddUpdateRequest request)
          => ExecuteSoapRequestAsync<DirectDepositAddUpdateRequest, DirectDepositAddUpdateRequestBody, DirectDepositAddUpdateResponse, DirectDepositAddUpdateResponseBody>(Channel.DirectDepositAddUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<DirectDepositAddUpdateResponse> DirectDepositAddUpdateAsync(DirectDepositAddUpdateRequest request)
             => (await base.Channel.DirectDepositAddUpdateAsync(new DirectDepositAddUpdateRequestBody(request))).Response;*/

        /// <summary>
        /// Inquires into the direct deposit information set up for an employee.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<DirectDepositInquiryResponse> DirectDepositInquiryAsync(DirectDepositInquiryRequest request)
          => ExecuteSoapRequestAsync<DirectDepositInquiryRequest, DirectDepositInquiryRequestBody, DirectDepositInquiryResponse, DirectDepositInquiryResponseBody>(Channel.DirectDepositInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<DirectDepositInquiryResponse> DirectDepositInquiryAsync(DirectDepositInquiryRequest request)
            => (await base.Channel.DirectDepositInquiryAsync(new DirectDepositInquiryRequestBody(request))).Response;*/



        /// <summary>
        /// Adds, updates (replace), or deletes records tied to a card number for customers using the limited network feature.You can enable a one-time purchase at any
        /// location code by not specifying a location code.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<LimitedNetworkByCardUpdateResponse> LimitedNetworkByCardUpdateAsync(LimitedNetworkByCardUpdateRequest request)
           => ExecuteSoapRequestAsync<LimitedNetworkByCardUpdateRequest, LimitedNetworkByCardUpdateRequestBody, LimitedNetworkByCardUpdateResponse, LimitedNetworkByCardUpdateResponseBody>(Channel.LimitedNetworkByCardUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<LimitedNetworkByCardUpdateResponse> LimitedNetworkByCardUpdateAsync(LimitedNetworkByCardUpdateRequest request)
             => (await base.Channel.LimitedNetworkByCardUpdateAsync(new LimitedNetworkByCardUpdateRequestBody(request))).Response;*/


>>>>>>> releases/v1.0.0

        /// <summary>
        /// Used for adding or subtracting money to/from a card's Express Cash Balance.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<LoadMoneyResponse> LoadMoneyAsync(LoadMoneyRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.LoadMoneyAsync, new LoadMoneyRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<LoadMoneyResponse> LoadMoneyAsync(LoadMoneyRequest request)
            => ExecuteSoapRequestAsync<LoadMoneyRequest, LoadMoneyRequestBody, LoadMoneyResponse, LoadMoneyResponseBody>(Channel.LoadMoneyAsync, request);
        /*public async System.Threading.Tasks.Task<LoadMoneyResponse> LoadMoneyAsync(LoadMoneyRequest request)
            => (await base.Channel.LoadMoneyAsync(new LoadMoneyRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Cancel Express Cash Loads.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<LoadMoneyCancelResponse> LoadMoneyCancelAsync(LoadMoneyCancelRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.LoadMoneyCancelAsync, new LoadMoneyCancelRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<LoadMoneyCancelResponse> LoadMoneyCancelAsync(LoadMoneyCancelRequest request)
            => ExecuteSoapRequestAsync<LoadMoneyCancelRequest, LoadMoneyCancelRequestBody, LoadMoneyCancelResponse, LoadMoneyCancelResponseBody>(Channel.LoadMoneyCancelAsync, request);
        /*public async System.Threading.Tasks.Task<LoadMoneyCancelResponse> LoadMoneyCancelAsync(LoadMoneyCancelRequest request)
            => (await base.Channel.LoadMoneyCancelAsync(new LoadMoneyCancelRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Sends money to registered Comchek Mobile users.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<LoadMoneyComchekResponse> LoadMoneyComchekAsync(LoadMoneyComchekRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.LoadMoneyComchekAsync, new LoadMoneyComchekRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion Express Cash Webservice Methods

        #region Location Webservice Methods
=======
        public Task<LoadMoneyComchekResponse> LoadMoneyComchekAsync(LoadMoneyComchekRequest request)
            => ExecuteSoapRequestAsync<LoadMoneyComchekRequest, LoadMoneyComchekRequestBody, LoadMoneyComchekResponse, LoadMoneyComchekResponseBody>(Channel.LoadMoneyComchekAsync, request);
        /*public async System.Threading.Tasks.Task<LoadMoneyComchekResponse> LoadMoneyComchekAsync(LoadMoneyComchekRequest request)
            => (await base.Channel.LoadMoneyComchekAsync(new LoadMoneyComchekRequestBody(request))).Response;*/


>>>>>>> releases/v1.0.0

        /// <summary>
        /// Makes updates to a merchant network location, including updates to fueling and cash back limits and restrictions on product codes.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<LocationMaintenanceResponse> LocationMaintenanceAsync(LocationMaintenanceRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.LocationMaintenanceAsync, new LocationMaintenanceRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion Location Webservice Methods

        #region PIN Webservice Methods
=======
        public Task<LocationMaintenanceResponse> LocationMaintenanceAsync(LocationMaintenanceRequest request)
          => ExecuteSoapRequestAsync<LocationMaintenanceRequest, LocationMaintenanceRequestBody, LocationMaintenanceResponse, LocationMaintenanceResponseBody>(Channel.LocationMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<LocationMaintenanceResponse> LocationMaintenanceAsync(LocationMaintenanceRequest request)
             => (await base.Channel.LocationMaintenanceAsync(new LocationMaintenanceRequestBody(request))).Response;*/


>>>>>>> releases/v1.0.0

        /// <summary>
        /// Establishes a card's PIN (Personal Identification Number).
        /// Encryption algorithm instructions are detailed in a separate document. Please consult your Comdata Technical Representative.
        /// </summary>
<<<<<<< HEAD
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardNumber">Full 16-digit card number. (BIN required).</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="pin">Encryption algorithm instructions provided in separate document.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <returns></returns>
        public async Task<PinSetResponse> PinSetAsync(string accountCode, string cardNumber, string customerId, string pin, string? discretionaryData = null, long? trackingNumber = null)
        {
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

            try
            {
                var response = await SendAsync(Channel.PinSetAsync, new PinSetRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<PinSetResponse> PinSetAsync(PinSetRequest request)
           => ExecuteSoapRequestAsync<PinSetRequest, PinSetRequestBody, PinSetResponse, PinSetResponseBody>(Channel.PinSetAsync, request);
        /*public async System.Threading.Tasks.Task<PinSetResponse> PinSetAsync(PinSetRequest request)
             => (await base.Channel.PinSetAsync(new PinSetRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Reset a card's PIN (Personal Indentification Number).  Once complete, a new PIN is then able to be assigned to a card.
        /// </summary>
<<<<<<< HEAD
        /// <param name="accountCode">Value assigned by Comdata.</param>
        /// <param name="cardNumber">Full 16-digit card number. (BIN required).</param>
        /// <param name="customerId">Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.</param>
        /// <param name="discretionaryData">Any discretionary data that the requestor would like returned in the response record. (optional)</param>
        /// <param name="trackingNumber">Any Number (data type: long)</param>
        /// <returns></returns>
        public async Task<PinResetResponse> PinResetAsync(string accountCode, string cardNumber, string customerId, string? discretionaryData = null, long? trackingNumber = null)
        {
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

            try
            {
                var response = await SendAsync(Channel.PinResetAsync, new PinResetRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion PIN Webservice Methods

        #region Transfer Webservice Methods

        public async Task<TransferToBankResponse> TransferToBankAsync(TransferToBankRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.TransferToBankAsync, new TransferToBankRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        public async Task<TransferMaintenanceByCardtokenResponse> TransferMaintenanceByCardtokenAsync(TransferMaintenanceByCardtokenRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.TransferMaintenanceByCardtokenAsync, new TransferMaintenanceByCardtokenRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion Transfer Webservice Methods

        #region Virtual Card Webservice Methods
=======
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<PinResetResponse> PinResetAsync(PinResetRequest request)
            => ExecuteSoapRequestAsync<PinResetRequest, PinResetRequestBody, PinResetResponse, PinResetResponseBody>(Channel.PinResetAsync, request);
        /*public async System.Threading.Tasks.Task<PinResetResponse> PinResetAsync(PinResetRequest request)
            => (await base.Channel.PinResetAsync(new PinResetRequestBody(request))).Response;*/



        public Task<TrackCardShipmentResponse> TrackCardShipmentStatusAsync(TrackCardShipmentRequest request)
            => ExecuteSoapRequestAsync<TrackCardShipmentRequest, TrackCardShipmentRequestBody, TrackCardShipmentResponse, TrackCardShipmentResponseBody>(Channel.TrackCardShipmentStatusAsync, request);
        /*public async System.Threading.Tasks.Task<TrackCardShipmentResponse> TrackCardShipmentStatusAsync(TrackCardShipmentRequest request)
            => (await base.Channel.TrackCardShipmentStatusAsync(new TrackCardShipmentRequestBody(request))).Response;*/

        public Task<TransferToBankResponse> TransferToBankAsync(TransferToBankRequest request)
             => ExecuteSoapRequestAsync<TransferToBankRequest, TransferToBankRequestBody, TransferToBankResponse, TransferToBankResponseBody>(Channel.TransferToBankAsync, request);
        /*public async System.Threading.Tasks.Task<TransferToBankResponse> TransferToBankAsync(TransferToBankRequest request)
           => (await base.Channel.TransferToBankAsync(new TransferToBankRequestBody(request))).Response;*/

        public Task<TransferMaintenanceByCardtokenResponse> TransferMaintenanceByCardtokenAsync(TransferMaintenanceByCardtokenRequest request)
              => ExecuteSoapRequestAsync<TransferMaintenanceByCardtokenRequest, TransferMaintenanceByCardtokenRequestBody, TransferMaintenanceByCardtokenResponse, TransferMaintenanceByCardtokenResponseBody>(Channel.TransferMaintenanceByCardtokenAsync, request);
        /*public async System.Threading.Tasks.Task<TransferMaintenanceByCardtokenResponse> TransferMaintenanceByCardtokenAsync(TransferMaintenanceByCardtokenRequest request)
          => (await base.Channel.TransferMaintenanceByCardtokenAsync(new TransferMaintenanceByCardtokenRequestBody(request))).Response;*/


>>>>>>> releases/v1.0.0

        /// <summary>
        /// Requests a Comdata Virtual MasterCard.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<VirtualCardAddResponse> VirtualCardAddAsync(VirtualCardAddRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.VirtualCardAddAsync, new VirtualCardAddRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<VirtualCardAddResponse> VirtualCardAddAsync(VirtualCardAddRequest request)
            => ExecuteSoapRequestAsync<VirtualCardAddRequest, VirtualCardAddRequestBody, VirtualCardAddResponse, VirtualCardAddResponseBody>(Channel.VirtualCardAddAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualCardAddResponse> VirtualCardAddAsync(VirtualCardAddRequest request)
             => (await base.Channel.VirtualCardAddAsync(new VirtualCardAddRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Inquires the current attributes of an existing Comdata Virtual MasterCard.No card updates are performed.  It is an information only request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<VirtualCardInquiryResponse> VirtualCardInquiryAsync(VirtualCardInquiryRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.VirtualCardInquiryAsync, new VirtualCardInquiryRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
=======
        public Task<VirtualCardInquiryResponse> VirtualCardInquiryAsync(VirtualCardInquiryRequest request)
           => ExecuteSoapRequestAsync<VirtualCardInquiryRequest, VirtualCardInquiryRequestBody, VirtualCardInquiryResponse, VirtualCardInquiryResponseBody>(Channel.VirtualCardInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualCardInquiryResponse> VirtualCardInquiryAsync(VirtualCardInquiryRequest request)
             => (await base.Channel.VirtualCardInquiryAsync(new VirtualCardInquiryRequestBody(request))).Response;*/
>>>>>>> releases/v1.0.0

        /// <summary>
        /// Make updates to an existing Comdata Virtual MasterCard.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<VirtualCardUpdateResponse> VirtualCardUpdateAsync(VirtualCardUpdateRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.VirtualCardUpdateAsync, new VirtualCardUpdateRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }

        #endregion Virtual Card Webservice Methods

        #region Virtual Comchek Webservice Methods
=======
        public Task<VirtualCardUpdateResponse> VirtualCardUpdateAsync(VirtualCardUpdateRequest request)
           => ExecuteSoapRequestAsync<VirtualCardUpdateRequest, VirtualCardUpdateRequestBody, VirtualCardUpdateResponse, VirtualCardUpdateResponseBody>(Channel.VirtualCardUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualCardUpdateResponse> VirtualCardUpdateAsync(VirtualCardUpdateRequest request)
            => (await base.Channel.VirtualCardUpdateAsync(new VirtualCardUpdateRequestBody(request))).Response;*/


>>>>>>> releases/v1.0.0

        /// <summary>
        /// Requests a Comdata Virtual Comchek Card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<VirtualComchekAddResponse> VirtualComchekAddAsync(VirtualComchekAddRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.VirtualComchekAddAsync, new VirtualComchekAddRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
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

            try
            {
                var response = await SendAsync(Channel.VirtualComchekInquiryAsync, new VirtualComchekInquiryRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
        
=======
        public Task<VirtualComchekAddResponse> VirtualComchekAddAsync(VirtualComchekAddRequest request)
             => ExecuteSoapRequestAsync<VirtualComchekAddRequest, VirtualComchekAddRequestBody, VirtualComchekAddResponse, VirtualComchekAddResponseBody>(Channel.VirtualComchekAddAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualComchekAddResponse> VirtualComchekAddAsync(VirtualComchekAddRequest request)
           => (await base.Channel.VirtualComchekAddAsync(new VirtualComchekAddRequestBody(request))).Response;*/

        /// <summary>
        /// Inquires the current attributes of an existing Comdata Virtual Comchek.  No card updates are performed.It is an information only request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<VirtualComchekInquiryResponse> VirtualComchekInquiryAsync(VirtualComchekInquiryRequest request)
             => ExecuteSoapRequestAsync<VirtualComchekInquiryRequest, VirtualComchekInquiryRequestBody, VirtualComchekInquiryResponse, VirtualComchekInquiryResponseBody>(Channel.VirtualComchekInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualComchekInquiryResponse> VirtualComchekInquiryAsync(VirtualComchekInquiryRequest request)
            => (await base.Channel.VirtualComchekInquiryAsync(new VirtualComchekInquiryRequestBody(request))).Response;*/

>>>>>>> releases/v1.0.0
        /// <summary>
        /// Makes updates to an existing Comdata Virtual Comchek card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
<<<<<<< HEAD
        public async Task<VirtualComchekUpdateResponse> VirtualComchekUpdateAsync(VirtualComchekUpdateRequest request)
        {
            try
            {
                var response = await SendAsync(Channel.VirtualComchekUpdateAsync, new VirtualComchekUpdateRequestBody(request));

                if (response.Content.ResponseCode > 0)
                    throw new ComdataOperationException(response.Content.ResponseCode ?? -1, response.Content.ResponseMessage ?? string.Empty);

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while communicating with the Comdata web service.", ex);
            }
        }
      
        #endregion Virtual Comchek Webservice Methods


=======
        public Task<VirtualComchekUpdateResponse> VirtualComchekUpdateAsync(VirtualComchekUpdateRequest request)
             => ExecuteSoapRequestAsync<VirtualComchekUpdateRequest, VirtualComchekUpdateRequestBody, VirtualComchekUpdateResponse, VirtualComchekUpdateResponseBody>(Channel.VirtualComchekUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualComchekUpdateResponse> VirtualComchekUpdateAsync(VirtualComchekUpdateRequest request)
            => (await base.Channel.VirtualComchekUpdateAsync(new VirtualComchekUpdateRequestBody(request))).Response;*/

        #endregion Webservice Methods
>>>>>>> releases/v1.0.0

        #region Endpoint Helper Methods

        private static System.ServiceModel.Channels.Binding GetDefaultBinding() => RealTimeOnline0103Client.GetBindingForEndpoint(EndpointConfiguration.RealTimeOnline0103);

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RealTimeOnline0103))
            {
                var securityElement = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
                securityElement.IncludeTimestamp = false;
                securityElement.MessageSecurityVersion = MessageSecurityVersion.WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10;                

                var customBinding = new CustomBinding
                {
                    Elements =
                    {
                        securityElement,
                        new TextMessageEncodingBindingElement
                        {
                            MessageVersion =  MessageVersion.Soap11
                        },
                        new HttpsTransportBindingElement
                        {
                            MaxBufferSize = int.MaxValue,
                            //ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max,
                            MaxReceivedMessageSize = int.MaxValue,
                            AllowCookies = true,
                        }
                    }
                };

                return customBinding;

                /*
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
                */
            }

            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }



        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() => RealTimeOnline0103Client.GetEndpointAddress(EndpointConfiguration.RealTimeOnline0103);

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RealTimeOnline0103))
            {
<<<<<<< HEAD
                return new System.ServiceModel.EndpointAddress("https://w6.iconnectdata.com/cows/services/RealTimeOnline0103");
=======
                return new System.ServiceModel.EndpointAddress("https://w8cert.iconnectdata.com/cows/services/RealTimeOnline0103");
>>>>>>> releases/v1.0.0
            }

            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(string uriAddress) => new EndpointAddress(new Uri(uriAddress));



        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        #endregion Endpoint Helper Methods

        #region Authentication Helper Methods

        /// <summary>
<<<<<<< HEAD
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
=======
>>>>>>> releases/v1.0.0
        /// Set the WSSE UserName Token credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
<<<<<<< HEAD
        public void SetServiceCredentials(string userName, string password)
=======
        public void SetUsernameTokenCredentials(string userName, string password)
>>>>>>> releases/v1.0.0
        {
            ClientCredentials.UserName.UserName = userName;
            ClientCredentials.UserName.Password = password;
        }

        /// <summary>
        /// Set the WebSphere Active Directory Credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
<<<<<<< HEAD
        public void SetNetworkCredentials(string userName, string password)
=======
        public void SetActiveDirectoryCredentials(string userName, string password)
>>>>>>> releases/v1.0.0
        {
            ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            ClientCredentials.Windows.ClientCredential.Domain = "";
            ClientCredentials.Windows.ClientCredential.UserName = userName;
            ClientCredentials.Windows.ClientCredential.Password = password;
        }

<<<<<<< HEAD
        /// <summary>
        /// Set the WebSphere Active Directory Credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void SetSecurityCard(string securityCardNumber)
        {
            _securityCardNumber = securityCardNumber;
        }

=======
>>>>>>> releases/v1.0.0
        #endregion Authentication Helper Methods

        #region Factory Helper Methods

        public virtual System.Threading.Tasks.Task OpenAsync()
            => System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));

        public virtual System.Threading.Tasks.Task CloseAsync()
            => System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));

        #endregion Factory Helper Methods

        #region Webservice Helper Methods

<<<<<<< HEAD
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

            //catch (TimeoutException timeProblem)
            //{
            //    ConsoleWriteErrorLine("The service operation timed out.", timeProblem);
            //    //ConsoleWriteErrorLine("The service operation timed out. " + timeProblem.Message);
            //    client.Abort();
            //}
            //catch (FaultException unknownFault)
            //{
            //    ConsoleWriteErrorLine("An unknown exception was received.",unknownFault);
            //    //ConsoleWriteErrorLine("An unknown exception was received. " + unknownFault.Message);
            //    client.Abort();
            //}
            //catch (CommunicationException commProblem)
            //{
            //    ConsoleWriteErrorLine("There was a communication problem.", commProblem);
            //    //ConsoleWriteErrorLine("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            //    client.Abort();
            //}            
        }

        /*private async Task<TResponse> SendAsync<TRequest, TRequestBody, TResponse, TResponseBody>(Func<TRequestBody,Task<TResponseBody>> operation, TRequest request)
            where TRequest : class, ISoapRequest, new()
            where TRequestBody : class  //, ISoapRequestBody<TRequest>, new()
            where TResponse : class, ISoapResponse, new()
            where TResponseBody : class  //, ISoapResponseBody<TResponse>, new()
=======
        private async Task<TResponse> ExecuteSoapRequestAsync<TRequest, TRequestBody, TResponse, TResponseBody>(Func<TRequestBody,Task<TResponseBody>> operation, TRequest request)
            where TRequest : class, ISoapRequest, new()
            where TRequestBody : class, ISoapRequestBody<TRequest>, new()
            where TResponse : class, ISoapResponse, new()
            where TResponseBody : class, ISoapResponseBody<TResponse>, new()
>>>>>>> releases/v1.0.0
        {
            var requestBody = Activator.CreateInstance(typeof(TRequestBody), request) as TRequestBody;

            if (requestBody == null)
                throw new InvalidOperationException($"Unable to initialize the {typeof(TRequestBody).Name} instance!");
<<<<<<< HEAD
                        
            try
            {
                var responseBody = await operation(requestBody);

                if (responseBody == null)
                    throw new InvalidOperationException($"Could not deserialize a valid {typeof(TResponseBody).Name} instance!");

                return responseBody.Content;
            }
            catch (FaultException<BusinessException> ex)
            {
                throw new ComdataBusinessException(Convert.ToInt32(ex.Detail.MessageCode), ex.Detail.Message ?? $"An {ex.GetType().Name} occurred while executing the request.", ex);
            }
            catch (FaultException ex)
            {
                throw new ComdataOperationException($"An {ex.GetType().Name} occurred while executing the request.", ex);
            }

=======

            var responseBody = await operation(requestBody);

            if (responseBody == null)
                throw new InvalidOperationException($"Could not deserialize a valid {typeof(TResponseBody).Name} instance!");

            return responseBody.Response;
>>>>>>> releases/v1.0.0


            
            //catch (TimeoutException timeProblem)
            //{
            //    ConsoleWriteErrorLine("The service operation timed out.", timeProblem);
            //    //ConsoleWriteErrorLine("The service operation timed out. " + timeProblem.Message);
            //    client.Abort();
            //}
            //catch (FaultException unknownFault)
            //{
            //    ConsoleWriteErrorLine("An unknown exception was received.",unknownFault);
            //    //ConsoleWriteErrorLine("An unknown exception was received. " + unknownFault.Message);
            //    client.Abort();
            //}
            //catch (CommunicationException commProblem)
            //{
            //    ConsoleWriteErrorLine("There was a communication problem.", commProblem);
            //    //ConsoleWriteErrorLine("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            //    client.Abort();
            //}            
<<<<<<< HEAD
        }*/

        #endregion Webservice Helper Methods



        public enum EndpointConfiguration { RealTimeOnline0103 }
    }
}

/*
SignOnName = ClientCredentials.Windows.ClientCredential.UserName,  // "NB012"
Password = ClientCredentials.Windows.ClientCredential.Password,  // "NB012#52"
SecurityInfo = _securityCardNumber,  // "5600171620395709"
*/
=======
        }

        #endregion Webservice Helper Methods

        public enum EndpointConfiguration { RealTimeOnline0103 }
    }
}
>>>>>>> releases/v1.0.0
