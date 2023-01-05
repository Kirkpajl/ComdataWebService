using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Comdata.FleetCreditWS0200.Models;
using Comdata.Models.Internals;

namespace Comdata.FleetCreditWS0200
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class FleetCreditWS0200Client : System.ServiceModel.ClientBase<IFleetCreditWS0200>, IFleetCreditWS0200
    {
        #region Constructors

        public FleetCreditWS0200Client() : base(FleetCreditWS0200Client.GetDefaultBinding(), FleetCreditWS0200Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.FleetCreditWS0200.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public FleetCreditWS0200Client(string remoteAddress) : base(FleetCreditWS0200Client.GetDefaultBinding(), FleetCreditWS0200Client.GetEndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = EndpointConfiguration.FleetCreditWS0200.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public FleetCreditWS0200Client(EndpointConfiguration endpointConfiguration) : base(FleetCreditWS0200Client.GetBindingForEndpoint(endpointConfiguration), FleetCreditWS0200Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public FleetCreditWS0200Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : base(FleetCreditWS0200Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public FleetCreditWS0200Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : base(FleetCreditWS0200Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public FleetCreditWS0200Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

        #endregion Constructors

        #region Webservice Methods

        public System.Threading.Tasks.Task<InquireCardV01Response> InquireCardV01Async(InquireCardV01Request request) => base.Channel.InquireCardV01Async(request);

        public System.Threading.Tasks.Task<InquireCardV02Response> InquireCardV02Async(InquireCardV02Request request) => base.Channel.InquireCardV02Async(request);

        public System.Threading.Tasks.Task<UpdateCardV01Response> UpdateCardV01Async(UpdateCardV01Request request) => base.Channel.UpdateCardV01Async(request);

        public System.Threading.Tasks.Task<UpdateCardV02Response> UpdateCardV02Async(UpdateCardV02Request request) => base.Channel.UpdateCardV02Async(request);

        public System.Threading.Tasks.Task<AddCardV01Response> AddCardV01Async(AddCardV01Request request) => base.Channel.AddCardV01Async(request);

        public System.Threading.Tasks.Task<AddCardV02Response> AddCardV02Async(AddCardV02Request request) => base.Channel.AddCardV02Async(request);

        public System.Threading.Tasks.Task<AddCardV03Response> AddCardV03Async(AddCardV03Request request) => base.Channel.AddCardV03Async(request);

        public System.Threading.Tasks.Task<CustomerProfileListingResponse> CustomerProfileListingAsync(CustomerProfileListingRequest request) => base.Channel.CustomerProfileListingAsync(request);

        public System.Threading.Tasks.Task<InquireCustomerProfileLimitsResponse> InquireCustomerProfileLimitsAsync(InquireCustomerProfileLimitsRequest request) => base.Channel.InquireCustomerProfileLimitsAsync(request);

        public System.Threading.Tasks.Task<UpdateCustomerProfileLimitsResponse> UpdateCustomerProfileLimitsAsync(UpdateCustomerProfileLimitsRequest request) => base.Channel.UpdateCustomerProfileLimitsAsync(request);

        public System.Threading.Tasks.Task<InquireCardSecurityCodeResponse> InquireCardSecurityCodeAsync(InquireCardSecurityCodeRequest request) => base.Channel.InquireCardSecurityCodeAsync(request);

        public System.Threading.Tasks.Task<InquireCardProfileLimitsResponse> InquireCardProfileLimitsAsync(InquireCardProfileLimitsRequest request) => base.Channel.InquireCardProfileLimitsAsync(request);

        public System.Threading.Tasks.Task<UpdateCardProfileLimitsResponse> UpdateCardProfileLimitsAsync(UpdateCardProfileLimitsRequest request) => base.Channel.UpdateCardProfileLimitsAsync(request);

        public System.Threading.Tasks.Task<InquireDriverIdResponse> InquireDriverIdAsync(InquireDriverIdRequest request) => base.Channel.InquireDriverIdAsync(request);

        public System.Threading.Tasks.Task<AddDriverIdResponse> AddDriverIdAsync(AddDriverIdRequest request) => base.Channel.AddDriverIdAsync(request);

        public System.Threading.Tasks.Task<UpdateDriverIdResponse> UpdateDriverIdAsync(UpdateDriverIdRequest request) => base.Channel.UpdateDriverIdAsync(request);

        public System.Threading.Tasks.Task<DeleteDriverIdResponse> DeleteDriverIdAsync(DeleteDriverIdRequest request) => base.Channel.DeleteDriverIdAsync(request);

        public System.Threading.Tasks.Task<InquireVehicleIdResponse> InquireVehicleIdAsync(InquireVehicleIdRequest request) => base.Channel.InquireVehicleIdAsync(request);

        public System.Threading.Tasks.Task<AddVehicleIdResponse> AddVehicleIdAsync(AddVehicleIdRequest request) => base.Channel.AddVehicleIdAsync(request);

        public System.Threading.Tasks.Task<UpdateVehicleIdResponse> UpdateVehicleIdAsync(UpdateVehicleIdRequest request) => base.Channel.UpdateVehicleIdAsync(request);

        public System.Threading.Tasks.Task<DeleteVehicleIdResponse> DeleteVehicleIdAsync(DeleteVehicleIdRequest request) => base.Channel.DeleteVehicleIdAsync(request);

        public System.Threading.Tasks.Task<RealTimeTransactionHistoryV01Response> RealTimeTransactionHistoryV01Async(RealTimeTransactionHistoryV01Request request) => base.Channel.RealTimeTransactionHistoryV01Async(request);

        public System.Threading.Tasks.Task<RealTimeTransactionHistoryV02Response> RealTimeTransactionHistoryV02Async(RealTimeTransactionHistoryV02Request request) => base.Channel.RealTimeTransactionHistoryV02Async(request);

        public System.Threading.Tasks.Task<RealTimeTransactionHistoryV03Response> RealTimeTransactionHistoryV03Async(RealTimeTransactionHistoryV03Request request) => base.Channel.RealTimeTransactionHistoryV03Async(request);

        public System.Threading.Tasks.Task<RealTimeTransactionHistoryV04Response> RealTimeTransactionHistoryV04Async(RealTimeTransactionHistoryV04Request request) => base.Channel.RealTimeTransactionHistoryV04Async(request);

        public System.Threading.Tasks.Task<CustIdListingResponse> CustIdListingAsync(CustIdListingRequest request) => base.Channel.CustIdListingAsync(request);

        public System.Threading.Tasks.Task<AvailableCreditInquiryResponse> AvailableCreditInquiryAsync(AvailableCreditInquiryRequest request) => base.Channel.AvailableCreditInquiryAsync(request);

        public System.Threading.Tasks.Task<IntradayV01Response> IntradayV01Async(IntradayV01Request request) => base.Channel.IntradayV01Async(request);

        public System.Threading.Tasks.Task<IntradayV02Response> IntradayV02Async(IntradayV02Request request) => base.Channel.IntradayV02Async(request);

        public System.Threading.Tasks.Task<IntradayV03Response> IntradayV03Async(IntradayV03Request request) => base.Channel.IntradayV03Async(request);

        public System.Threading.Tasks.Task<ProprietaryIntradayResponse> ProprietaryIntradayAsync(ProprietaryIntradayRequest request) => base.Channel.ProprietaryIntradayAsync(request);

        public System.Threading.Tasks.Task<CardListingV01Response> CardListingV01Async(CardListingV01Request request) => base.Channel.CardListingV01Async(request);

        public System.Threading.Tasks.Task<CardListingV02Response> CardListingV02Async(CardListingV02Request request) => base.Channel.CardListingV02Async(request);

        public System.Threading.Tasks.Task<RecycleCardLimitsResponse> RecycleCardLimitsAsync(RecycleCardLimitsRequest request) => base.Channel.RecycleCardLimitsAsync(request);

        public System.Threading.Tasks.Task<OneTimePurchaseOverrideResponse> OneTimePurchaseOverrideAsync(OneTimePurchaseOverrideRequest request) => base.Channel.OneTimePurchaseOverrideAsync(request);

        public System.Threading.Tasks.Task<PaymentHistoryResponse> PaymentHistoryAsync(PaymentHistoryRequest request) => base.Channel.PaymentHistoryAsync(request);

        #endregion Webservice Methods

        #region Endpoint Helper Methods

        private static System.ServiceModel.Channels.Binding GetDefaultBinding() => FleetCreditWS0200Client.GetBindingForEndpoint(EndpointConfiguration.FleetCreditWS0200);

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FleetCreditWS0200))
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



        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() => FleetCreditWS0200Client.GetEndpointAddress(EndpointConfiguration.FleetCreditWS0200);

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FleetCreditWS0200))
            {
                return new System.ServiceModel.EndpointAddress("https://w8cert.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200");
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

        private async Task<TResponse> ExecuteSoapRequestAsync<TRequest, TRequestBody, TResponse, TResponseBody>(Func<TRequestBody, Task<TResponseBody>> operation, TRequest request)
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

        public enum EndpointConfiguration { FleetCreditWS0200 }
    }
}
