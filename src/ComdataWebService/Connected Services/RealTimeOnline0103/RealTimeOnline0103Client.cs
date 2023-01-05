using Comdata.RealTimeOnline0103.Models;
using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Comdata.RealTimeOnline0103
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class RealTimeOnline0103Client : System.ServiceModel.ClientBase<IRealTimeOnline0103>
    {
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

        #region Webservice Methods

        /// <summary>
        /// Modifies the status of a Proprietary Card.  Alternatively, proprietary card status can also be modified by using the Proprietary Card Update 1.0 function.
        /// The requestor has the option of which function(s) they would like to use to perform proprietary card maintenance.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardBlockUnblockResponse> CardBlockUnblockAsync(CardBlockUnblockRequest request)
            => ExecuteSoapRequestAsync<CardBlockUnblockRequest, CardBlockUnblockRequestBody, CardBlockUnblockResponse, CardBlockUnblockResponseBody>(Channel.CardBlockUnblockAsync, request);
        /*public async System.Threading.Tasks.Task<CardBlockUnblockResponse?> CardBlockUnblockAsync(CardBlockUnblockRequest request) 
            => (await base.Channel.CardBlockUnblockAsync(new CardBlockUnblockRequestBody(request))).Response;*/

        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.  No card updates are performed.It is an information only request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardInquiryResponseV01> CardInquiryAsync(CardInquiryRequestV01 request)
            => ExecuteSoapRequestAsync<CardInquiryRequestV01, CardInquiryRequestV01Body, CardInquiryResponseV01, CardInquiryResponseV01Body>(Channel.CardInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<CardInquiryResponse?> CardInquiryAsync(CardInquiryRequest request)
            => (await base.Channel.CardInquiryAsync(new CardInquiryRequestBody(request))).Response;*/

        /// <summary>
        /// Requests the current attributes of a Comdata Proprietary Card.  No card updates are performed.It is an information only request.
        /// Card inquiry by token has been introduced in this updated version.
        /// </summary>
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

        /// <summary>
        /// Transfers a card from one customer ID to another.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardMoveMaintenanceResponse> CardMoveMaintenanceAsync(CardMoveMaintenanceRequest request)
            => ExecuteSoapRequestAsync<CardMoveMaintenanceRequest, CardMoveMaintenanceRequestBody, CardMoveMaintenanceResponse, CardMoveMaintenanceResponseBody>(Channel.CardMoveMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<CardMoveMaintenanceResponse> CardMoveMaintenanceAsync(CardMoveMaintenanceRequest request)
            => (await base.Channel.CardMoveMaintenanceAsync(new CardMoveMaintenanceRequestBody(request))).Response;*/

        /// <summary>
        /// Transfers card values from one card to an unassigned card under the same account code and customer ID.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardTransferMaintenanceResponse> CardTransferMaintenanceAsync(CardTransferMaintenanceRequest request)
            => ExecuteSoapRequestAsync<CardTransferMaintenanceRequest, CardTransferMaintenanceRequestBody, CardTransferMaintenanceResponse, CardTransferMaintenanceResponseBody>(Channel.TransferMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<TransferMaintenanceResponse> TransferMaintenanceAsync(TransferMaintenanceRequest request)
            => (await base.Channel.TransferMaintenanceAsync(new TransferMaintenanceRequestBody(request))).Response;*/

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardUpdateResponseV01> CardUpdateAsync(CardUpdateRequestV01 request)
            => ExecuteSoapRequestAsync<CardUpdateRequestV01, CardUpdateRequestV01Body, CardUpdateResponseV01, CardUpdateResponseV01Body>(Channel.CardUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<CardUpdateResponseV01> CardUpdateAsync(CardUpdateRequestV01 request)
            => (await base.Channel.CardUpdateAsync(new CardUpdateRequestV01Body(request))).Response;*/

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardUpdateResponseV02> CardUpdateV02Async(CardUpdateRequestV02 request)
            => ExecuteSoapRequestAsync<CardUpdateRequestV02, CardUpdateRequestV02Body, CardUpdateResponseV02, CardUpdateResponseV02Body>(Channel.CardUpdateV02Async, request);
        /*public async System.Threading.Tasks.Task<CardUpdateResponseV02> CardUpdateV02Async(CardUpdateRequestV02 request)
            => (await base.Channel.CardUpdateV02Async(new CardUpdateRequestV02Body(request))).Response;*/

        /// <summary>
        /// Makes updates to a Comdata Proprietary Card. This function is the workhorse for making updates to proprietary cards.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardUpdateResponseV03> CardUpdateV03Async(CardUpdateRequestV03 request)
            => ExecuteSoapRequestAsync<CardUpdateRequestV03, CardUpdateRequestV03Body, CardUpdateResponseV03, CardUpdateResponseV03Body>(Channel.CardUpdateV03Async, request);
        /*public async System.Threading.Tasks.Task<CardUpdateResponseV03> CardUpdateV03Async(CardUpdateRequestV03 request)
            => (await base.Channel.CardUpdateV03Async(new CardUpdateRequestV03Body(request))).Response;*/



        /// <summary>
        /// Requests Express Check Seed Code. Express Check Seed Code are part of the key building blocks used in calculating Express Check codes.Instructions for
        /// calculating Express Check codes are provided separately upon request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ExpressCheckBatchResponse> ExpressCheckBatchAsync(ExpressCheckBatchRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckBatchRequest, ExpressCheckBatchRequestBody, ExpressCheckBatchResponse, ExpressCheckBatchResponseBody>(Channel.ExpressCheckBatchAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckBatchResponse> ExpressCheckBatchAsync(ExpressCheckBatchRequest request)
            => (await base.Channel.ExpressCheckBatchAsync(new ExpressCheckBatchRequestBody(request))).Response;*/

        /// <summary>
        /// Provides the customer a general purpose inquiry into the status, properties, and last useage of an Express Check Code.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ExpressCheckInquiryResponse> ExpressCheckInquiryAsync(ExpressCheckInquiryRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckInquiryRequest, ExpressCheckInquiryRequestBody, ExpressCheckInquiryResponse, ExpressCheckInquiryResponseBody>(Channel.ExpressCheckInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckInquiryResponse> ExpressCheckInquiryAsync(ExpressCheckInquiryRequest request)
            => (await base.Channel.ExpressCheckInquiryAsync(new ExpressCheckInquiryRequestBody(request))).Response;*/

        /// <summary>
        /// Used by customers who have established internal processes in adherence to Comdata's Express Check Code Calculation Instructions 
        /// (provided separately upon request) to calculate their own Express Check codes.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ExpressCheckIssueResponse> ExpressCheckIssueAsync(ExpressCheckIssueRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckIssueRequest, ExpressCheckIssueRequestBody, ExpressCheckIssueResponse, ExpressCheckIssueResponseBody>(Channel.ExpressCheckIssueAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckIssueResponse> ExpressCheckIssueAsync(ExpressCheckIssueRequest request)
            => (await base.Channel.ExpressCheckIssueAsync(new ExpressCheckIssueRequestBody(request))).Response;*/

        /// <summary>
        /// Changes the status of an Express Check Code.It is important to note that other values assigned to an Express Check code at the time of Retrieval or
        /// Issuance such as amount, driver number, first name, last name, location code, purpose code, trip number, and unit number cannot be altered.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ExpressCheckMaintenanceResponse> ExpressCheckMaintenanceAsync(ExpressCheckMaintenanceRequest request)
            => ExecuteSoapRequestAsync<ExpressCheckMaintenanceRequest, ExpressCheckMaintenanceRequestBody, ExpressCheckMaintenanceResponse, ExpressCheckMaintenanceResponseBody>(Channel.ExpressCheckMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<ExpressCheckMaintenanceResponse> ExpressCheckMaintenanceAsync(ExpressCheckMaintenanceRequest request)
            => (await base.Channel.ExpressCheckMaintenanceAsync(new ExpressCheckMaintenanceRequestBody(request))).Response;*/

        /// <summary>
        /// Request Express Codes from Comdata. Customer specific setup within the Comdata host determines which fields are required; contact Comdata for details.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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



        /// <summary>
        /// Used for adding or subtracting money to/from a card's Express Cash Balance.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<LoadMoneyResponse> LoadMoneyAsync(LoadMoneyRequest request)
            => ExecuteSoapRequestAsync<LoadMoneyRequest, LoadMoneyRequestBody, LoadMoneyResponse, LoadMoneyResponseBody>(Channel.LoadMoneyAsync, request);
        /*public async System.Threading.Tasks.Task<LoadMoneyResponse> LoadMoneyAsync(LoadMoneyRequest request)
            => (await base.Channel.LoadMoneyAsync(new LoadMoneyRequestBody(request))).Response;*/

        /// <summary>
        /// Cancel Express Cash Loads.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<LoadMoneyCancelResponse> LoadMoneyCancelAsync(LoadMoneyCancelRequest request)
            => ExecuteSoapRequestAsync<LoadMoneyCancelRequest, LoadMoneyCancelRequestBody, LoadMoneyCancelResponse, LoadMoneyCancelResponseBody>(Channel.LoadMoneyCancelAsync, request);
        /*public async System.Threading.Tasks.Task<LoadMoneyCancelResponse> LoadMoneyCancelAsync(LoadMoneyCancelRequest request)
            => (await base.Channel.LoadMoneyCancelAsync(new LoadMoneyCancelRequestBody(request))).Response;*/

        /// <summary>
        /// Sends money to registered Comchek Mobile users.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<LoadMoneyComchekResponse> LoadMoneyComchekAsync(LoadMoneyComchekRequest request)
            => ExecuteSoapRequestAsync<LoadMoneyComchekRequest, LoadMoneyComchekRequestBody, LoadMoneyComchekResponse, LoadMoneyComchekResponseBody>(Channel.LoadMoneyComchekAsync, request);
        /*public async System.Threading.Tasks.Task<LoadMoneyComchekResponse> LoadMoneyComchekAsync(LoadMoneyComchekRequest request)
            => (await base.Channel.LoadMoneyComchekAsync(new LoadMoneyComchekRequestBody(request))).Response;*/



        /// <summary>
        /// Makes updates to a merchant network location, including updates to fueling and cash back limits and restrictions on product codes.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<LocationMaintenanceResponse> LocationMaintenanceAsync(LocationMaintenanceRequest request)
          => ExecuteSoapRequestAsync<LocationMaintenanceRequest, LocationMaintenanceRequestBody, LocationMaintenanceResponse, LocationMaintenanceResponseBody>(Channel.LocationMaintenanceAsync, request);
        /*public async System.Threading.Tasks.Task<LocationMaintenanceResponse> LocationMaintenanceAsync(LocationMaintenanceRequest request)
             => (await base.Channel.LocationMaintenanceAsync(new LocationMaintenanceRequestBody(request))).Response;*/



        /// <summary>
        /// Establishes a card's PIN (Personal Identification Number).
        /// Encryption algorithm instructions are detailed in a separate document. Please consult your Comdata Technical Representative.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<PinSetResponse> PinSetAsync(PinSetRequest request)
           => ExecuteSoapRequestAsync<PinSetRequest, PinSetRequestBody, PinSetResponse, PinSetResponseBody>(Channel.PinSetAsync, request);
        /*public async System.Threading.Tasks.Task<PinSetResponse> PinSetAsync(PinSetRequest request)
             => (await base.Channel.PinSetAsync(new PinSetRequestBody(request))).Response;*/

        /// <summary>
        /// Reset a card's PIN (Personal Indentification Number).  Once complete, a new PIN is then able to be assigned to a card.
        /// </summary>
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



        /// <summary>
        /// Requests a Comdata Virtual MasterCard.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<VirtualCardAddResponse> VirtualCardAddAsync(VirtualCardAddRequest request)
            => ExecuteSoapRequestAsync<VirtualCardAddRequest, VirtualCardAddRequestBody, VirtualCardAddResponse, VirtualCardAddResponseBody>(Channel.VirtualCardAddAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualCardAddResponse> VirtualCardAddAsync(VirtualCardAddRequest request)
             => (await base.Channel.VirtualCardAddAsync(new VirtualCardAddRequestBody(request))).Response;*/

        /// <summary>
        /// Inquires the current attributes of an existing Comdata Virtual MasterCard.No card updates are performed.  It is an information only request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<VirtualCardInquiryResponse> VirtualCardInquiryAsync(VirtualCardInquiryRequest request)
           => ExecuteSoapRequestAsync<VirtualCardInquiryRequest, VirtualCardInquiryRequestBody, VirtualCardInquiryResponse, VirtualCardInquiryResponseBody>(Channel.VirtualCardInquiryAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualCardInquiryResponse> VirtualCardInquiryAsync(VirtualCardInquiryRequest request)
             => (await base.Channel.VirtualCardInquiryAsync(new VirtualCardInquiryRequestBody(request))).Response;*/

        /// <summary>
        /// Make updates to an existing Comdata Virtual MasterCard.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<VirtualCardUpdateResponse> VirtualCardUpdateAsync(VirtualCardUpdateRequest request)
           => ExecuteSoapRequestAsync<VirtualCardUpdateRequest, VirtualCardUpdateRequestBody, VirtualCardUpdateResponse, VirtualCardUpdateResponseBody>(Channel.VirtualCardUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualCardUpdateResponse> VirtualCardUpdateAsync(VirtualCardUpdateRequest request)
            => (await base.Channel.VirtualCardUpdateAsync(new VirtualCardUpdateRequestBody(request))).Response;*/



        /// <summary>
        /// Requests a Comdata Virtual Comchek Card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Makes updates to an existing Comdata Virtual Comchek card.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<VirtualComchekUpdateResponse> VirtualComchekUpdateAsync(VirtualComchekUpdateRequest request)
             => ExecuteSoapRequestAsync<VirtualComchekUpdateRequest, VirtualComchekUpdateRequestBody, VirtualComchekUpdateResponse, VirtualComchekUpdateResponseBody>(Channel.VirtualComchekUpdateAsync, request);
        /*public async System.Threading.Tasks.Task<VirtualComchekUpdateResponse> VirtualComchekUpdateAsync(VirtualComchekUpdateRequest request)
            => (await base.Channel.VirtualComchekUpdateAsync(new VirtualComchekUpdateRequestBody(request))).Response;*/

        #endregion Webservice Methods

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
                return new System.ServiceModel.EndpointAddress("https://w8cert.iconnectdata.com/cows/services/RealTimeOnline0103");
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
        /// Set the WSSE UserName Token credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void SetUsernameTokenCredentials(string userName, string password)
        {
            ClientCredentials.UserName.UserName = userName;
            ClientCredentials.UserName.Password = password;
        }

        /// <summary>
        /// Set the WebSphere Active Directory Credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void SetActiveDirectoryCredentials(string userName, string password)
        {
            ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            ClientCredentials.Windows.ClientCredential.Domain = "";
            ClientCredentials.Windows.ClientCredential.UserName = userName;
            ClientCredentials.Windows.ClientCredential.Password = password;
        }

        #endregion Authentication Helper Methods

        #region Factory Helper Methods

        public virtual System.Threading.Tasks.Task OpenAsync()
            => System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));

        public virtual System.Threading.Tasks.Task CloseAsync()
            => System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));

        #endregion Factory Helper Methods

        #region Webservice Helper Methods

        private async Task<TResponse> ExecuteSoapRequestAsync<TRequest, TRequestBody, TResponse, TResponseBody>(Func<TRequestBody,Task<TResponseBody>> operation, TRequest request)
            where TRequest : class, ISoapRequest, new()
            where TRequestBody : class, ISoapRequestBody<TRequest>, new()
            where TResponse : class, ISoapResponse, new()
            where TResponseBody : class, ISoapResponseBody<TResponse>, new()
        {
            var requestBody = Activator.CreateInstance(typeof(TRequestBody), request) as TRequestBody;

            if (requestBody == null)
                throw new InvalidOperationException($"Unable to initialize the {typeof(TRequestBody).Name} instance!");

            var responseBody = await operation(requestBody);

            if (responseBody == null)
                throw new InvalidOperationException($"Could not deserialize a valid {typeof(TResponseBody).Name} instance!");

            return responseBody.Response;


            
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

        #endregion Webservice Helper Methods

        public enum EndpointConfiguration { RealTimeOnline0103 }
    }
}