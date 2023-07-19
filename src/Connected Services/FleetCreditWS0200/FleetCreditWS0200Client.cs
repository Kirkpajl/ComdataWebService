using Comdata.FleetCreditWS0200.Models;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Comdata.FleetCreditWS0200
{
    [DebuggerStepThrough()]
    public partial class FleetCreditWS0200Client : ClientBase<IFleetCreditWS0200>, IFleetCreditWS0200
    {
        #region Constructors

        public FleetCreditWS0200Client() : base(GetDefaultBinding(), GetDefaultEndpointAddress())
        {
            Endpoint.Name = EndpointConfiguration.FleetCreditWS0200.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(string remoteAddress) : base(GetDefaultBinding(), GetEndpointAddress(remoteAddress))
        {
            Endpoint.Name = EndpointConfiguration.FleetCreditWS0200.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(EndpointConfiguration endpointConfiguration) : base(GetBindingForEndpoint(endpointConfiguration), GetEndpointAddress(endpointConfiguration))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : base(GetBindingForEndpoint(endpointConfiguration), new EndpointAddress(remoteAddress))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(EndpointConfiguration endpointConfiguration, EndpointAddress remoteAddress) : base(GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

        #endregion Constructors

        #region Webservice Methods

        public Task<InquireCardV01Response> InquireCardV01Async(InquireCardV01Request request) => Channel.InquireCardV01Async(request);

        public Task<InquireCardV02Response> InquireCardV02Async(InquireCardV02Request request) => Channel.InquireCardV02Async(request);

        public Task<UpdateCardV01Response> UpdateCardV01Async(UpdateCardV01Request request) => Channel.UpdateCardV01Async(request);

        public Task<UpdateCardV02Response> UpdateCardV02Async(UpdateCardV02Request request) => Channel.UpdateCardV02Async(request);

        public Task<AddCardV01Response> AddCardV01Async(AddCardV01Request request) => Channel.AddCardV01Async(request);

        public Task<AddCardV02Response> AddCardV02Async(AddCardV02Request request) => Channel.AddCardV02Async(request);

        public Task<AddCardV03Response> AddCardV03Async(AddCardV03Request request) => Channel.AddCardV03Async(request);

        public Task<CustomerProfileListingResponse> CustomerProfileListingAsync(CustomerProfileListingRequest request) => Channel.CustomerProfileListingAsync(request);

        public Task<InquireCustomerProfileLimitsResponse> InquireCustomerProfileLimitsAsync(InquireCustomerProfileLimitsRequest request) => Channel.InquireCustomerProfileLimitsAsync(request);

        public Task<UpdateCustomerProfileLimitsResponse> UpdateCustomerProfileLimitsAsync(UpdateCustomerProfileLimitsRequest request) => Channel.UpdateCustomerProfileLimitsAsync(request);

        public Task<InquireCardSecurityCodeResponse> InquireCardSecurityCodeAsync(InquireCardSecurityCodeRequest request) => Channel.InquireCardSecurityCodeAsync(request);

        public Task<InquireCardProfileLimitsResponse> InquireCardProfileLimitsAsync(InquireCardProfileLimitsRequest request) => Channel.InquireCardProfileLimitsAsync(request);

        public Task<UpdateCardProfileLimitsResponse> UpdateCardProfileLimitsAsync(UpdateCardProfileLimitsRequest request) => Channel.UpdateCardProfileLimitsAsync(request);

        public Task<InquireDriverIdResponse> InquireDriverIdAsync(InquireDriverIdRequest request) => Channel.InquireDriverIdAsync(request);

        public Task<AddDriverIdResponse> AddDriverIdAsync(AddDriverIdRequest request) => Channel.AddDriverIdAsync(request);

        public Task<UpdateDriverIdResponse> UpdateDriverIdAsync(UpdateDriverIdRequest request) => Channel.UpdateDriverIdAsync(request);

        public Task<DeleteDriverIdResponse> DeleteDriverIdAsync(DeleteDriverIdRequest request) => Channel.DeleteDriverIdAsync(request);

        public Task<InquireVehicleIdResponse> InquireVehicleIdAsync(InquireVehicleIdRequest request) => Channel.InquireVehicleIdAsync(request);

        public Task<AddVehicleIdResponse> AddVehicleIdAsync(AddVehicleIdRequest request) => Channel.AddVehicleIdAsync(request);

        public Task<UpdateVehicleIdResponse> UpdateVehicleIdAsync(UpdateVehicleIdRequest request) => Channel.UpdateVehicleIdAsync(request);

        public Task<DeleteVehicleIdResponse> DeleteVehicleIdAsync(DeleteVehicleIdRequest request) => Channel.DeleteVehicleIdAsync(request);

        public Task<RealTimeTransactionHistoryV01Response> RealTimeTransactionHistoryV01Async(RealTimeTransactionHistoryV01Request request) => Channel.RealTimeTransactionHistoryV01Async(request);

        public Task<RealTimeTransactionHistoryV02Response> RealTimeTransactionHistoryV02Async(RealTimeTransactionHistoryV02Request request) => Channel.RealTimeTransactionHistoryV02Async(request);

        public Task<RealTimeTransactionHistoryV03Response> RealTimeTransactionHistoryV03Async(RealTimeTransactionHistoryV03Request request) => Channel.RealTimeTransactionHistoryV03Async(request);

        public Task<RealTimeTransactionHistoryV04Response> RealTimeTransactionHistoryV04Async(RealTimeTransactionHistoryV04Request request) => Channel.RealTimeTransactionHistoryV04Async(request);

        public Task<CustIdListingResponse> CustIdListingAsync(CustIdListingRequest request) => Channel.CustIdListingAsync(request);

        public Task<AvailableCreditInquiryResponse> AvailableCreditInquiryAsync(AvailableCreditInquiryRequest request) => Channel.AvailableCreditInquiryAsync(request);

        public Task<IntradayV01Response> IntradayV01Async(IntradayV01Request request) => Channel.IntradayV01Async(request);

        public Task<IntradayV02Response> IntradayV02Async(IntradayV02Request request) => Channel.IntradayV02Async(request);

        public Task<IntradayV03Response> IntradayV03Async(IntradayV03Request request) => Channel.IntradayV03Async(request);

        public Task<ProprietaryIntradayResponse> ProprietaryIntradayAsync(ProprietaryIntradayRequest request) => Channel.ProprietaryIntradayAsync(request);

        public Task<CardListingV01Response> CardListingV01Async(CardListingV01Request request) => Channel.CardListingV01Async(request);

        public Task<CardListingV02Response> CardListingV02Async(CardListingV02Request request) => Channel.CardListingV02Async(request);

        public Task<RecycleCardLimitsResponse> RecycleCardLimitsAsync(RecycleCardLimitsRequest request) => Channel.RecycleCardLimitsAsync(request);

        public Task<OneTimePurchaseOverrideResponse> OneTimePurchaseOverrideAsync(OneTimePurchaseOverrideRequest request) => Channel.OneTimePurchaseOverrideAsync(request);

        public Task<PaymentHistoryResponse> PaymentHistoryAsync(PaymentHistoryRequest request) => Channel.PaymentHistoryAsync(request);

        #endregion Webservice Methods

        #region Endpoint Helper Methods

        private static Binding GetDefaultBinding() => GetBindingForEndpoint(EndpointConfiguration.FleetCreditWS0200);

        private static Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if (endpointConfiguration == EndpointConfiguration.FleetCreditWS0200)
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
                            MaxReceivedMessageSize = int.MaxValue,
                            AllowCookies = true,
                        }
                    }
                };

                return customBinding;
            }

            throw new InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }



        private static EndpointAddress GetDefaultEndpointAddress() => GetEndpointAddress(EndpointConfiguration.FleetCreditWS0200);

        private static EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FleetCreditWS0200))
            {
                return new EndpointAddress("https://w8cert.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200");
            }

            throw new InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static EndpointAddress GetEndpointAddress(string uriAddress) => new EndpointAddress(new Uri(uriAddress));



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

        #endregion Authentication Helper Methods

        #region Factory Helper Methods

        public virtual Task OpenAsync()
            => Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndOpen));

        public virtual Task CloseAsync()
            => Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginClose(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndClose));

        #endregion Factory Helper Methods
    }
}
