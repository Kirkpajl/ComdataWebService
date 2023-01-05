using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.FleetCreditWS0200.Exceptions;
using Comdata.FleetCreditWS0200.Models;
using Comdata.Models.Internals;

namespace Comdata.FleetCreditWS0200
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class FleetCreditWS0200Client : System.ServiceModel.ClientBase<IFleetCreditWS0200>
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



        #region Card Webservice Methods

        /// <summary>
        /// The Add Card request is used to order a card via a web service mirroring PS14 functionality. 
        /// 
        /// The Card Add request requires the following information: the requested card limit, card expiration date, and the card status.
        /// </summary>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCard"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardAddUpdateResponse?> AddCardV01Async(CardRecordV01 cardDetails, MailingDetailsV01 mailingDetails, bool maskCard)
        {
            var request = new AddCardV01Request(cardDetails, mailingDetails, maskCard ? "Y" : "N");

            var response = await SendAsync(Channel.AddCardV01Async, request);

            if (int.TryParse(response.Response?.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.Response?.ResponseDescription ?? string.Empty);

            return response.Response;
        }

        /// <summary>
        /// The Add Card request is used to order a card via a web service mirroring PS14 functionality. 
        /// 
        /// The Card Add request requires the following information: the requested card limit, card expiration date, and the card status.
        /// </summary>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCard"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<CardAddUpdateResponse?> AddCardV02Async(CardRecordV03 cardDetails, MailingDetailsV01 mailingDetails, bool maskCard)
        {
            var request = new AddCardV02Request(cardDetails, mailingDetails, maskCard ? "Y" : "N");

            var response = await SendAsync(Channel.AddCardV02Async, request);

            if (int.TryParse(response.Response?.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.Response?.ResponseDescription ?? string.Empty);

            return response.Response;
        }

        /// <summary>
        /// The Add Card V03 request is used to order a card via a web service while combining the following features:
        /// * Create card
        /// * Set Customer Profile Limits
        /// * Return card details and limits along with security code
        /// 
        /// The Card Add request requires the following information:
        /// * Requested card limits
        /// * Card expiration date
        /// * Card status
        /// 
        /// This is a specialized card add operation that operation only with the following card settings:
        /// * Cycle type "T" (never reset)
        /// * Off company standards/profile (profileFlag = "N")
        /// 
        /// Attempting to create cards outside of these settings will result in an input validation error.
        /// </summary>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="profileLimits"></param>
        /// <param name="maskCard"></param>
        /// <param name="securityCode"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public Task<AddCardV03Response> AddCardV03Async(CardRecordV03 cardDetails, MailingDetailsV02 mailingDetails, ProfileLimits profileLimits, bool maskCard, bool securityCode)
        {
            var request = new AddCardV03Request(cardDetails, mailingDetails, profileLimits, maskCard, securityCode);

            return SendAsync(Channel.AddCardV03Async, request);
        }



        /// <summary>
        /// The Card Inquiry function is used to request the current attributes of a card. No card updates can be performed using this function.  It is an information-only request.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="discretionaryData">Customer-assigned value returned in the response record</param>
        /// <param name="trackingNumber">Customer-assigned value returned in the response record</param>
        /// <param name="empNumCardNumFlag">C, E, c, or e (Card Number or Employee Number will be used in the empNumCardNumValue field)</param>
        /// <param name="empNumCardNumValue">Employee number or card number used as a search criterion based on the empNumCardNumFlag element</param>
        /// <param name="maskCard">Y (yes) returns a masked card number. Space or null returns the full card number as long as the account-level access allows.</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        [Obsolete("This operation has been deprecated and will be removed at some point in the future. Please use the latest version of this function.")]
        public Task<InquireCardV01Response> InquireCardV01Async(string accountCode, string customerId, string discretionaryData, string trackingNumber, EmpNumCardNumFlag? empNumCardNumFlag, string empNumCardNumValue, bool maskCard)
        {
            var request = new InquireCardV01Request(accountCode, customerId, discretionaryData, trackingNumber, empNumCardNumFlag, empNumCardNumValue, maskCard ? "Y" : " ");

            return SendAsync(Channel.InquireCardV01Async, request);
        }

        /// <summary>
        /// The Card Inquiry 2 function is used to request the current attributes of a card.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="discretionaryData">Customer-assigned value returned in the response record</param>
        /// <param name="trackingNumber">Customer-assigned value returned in the response record</param>
        /// <param name="cardIdentifierType">C, E, T, c, e, t (Card Number, Employee Number, Card Token will be used in the cardIdentifier field)</param>
        /// <param name="cardIdentifier">Employee number, card number, or card token used as a search criterion based on the cardIdentifierType element</param>
        /// <param name="maskCard">Y(yes) returns a masked card number. Space or null returns the full card number as long as the account-level access allows.</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public Task<InquireCardV02Response> InquireCardV02Async(string accountCode, string customerId, string discretionaryData, string trackingNumber, CardIdentifierType? cardIdentifierType, string cardIdentifier, bool maskCard)
        {
            var request = new InquireCardV02Request(accountCode, customerId, discretionaryData, trackingNumber, cardIdentifierType, cardIdentifier, maskCard ? "Y" : " ");

            return SendAsync(Channel.InquireCardV02Async, request);
        }



        /// <summary>
        /// The Card Update function is used to make updates to a customer's card.  This is the web services request with
        /// the most options, and it is likely to be the most used.
        /// </summary>
        /// <param name="empNumCardNumFlag">C, E, c, or e (Card Number or Employee Number used for the empNumCardNumValue)</param>
        /// <param name="empNumCardNumValue">Employee number or card number used to search</param>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCard">Y (yes) or N (no); Yes returns a masked card number</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        [Obsolete("This operation has been deprecated and will be removed at some point in the future. Please use the latest version of this function.")]
        public async Task<CardAddUpdateResponse?> UpdateCardV01Async(EmpNumCardNumFlag? empNumCardNumFlag, string empNumCardNumValue, CardRecordV01 cardDetails, MailingDetailsV01 mailingDetails, bool maskCard)
        {
            var request = new UpdateCardV01Request(empNumCardNumFlag, empNumCardNumValue, cardDetails, mailingDetails, maskCard ? "Y" : "N");

            var response = await SendAsync(Channel.UpdateCardV01Async, request);

            if (int.TryParse(response.Response?.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.Response?.ResponseDescription ?? string.Empty);

            return response.Response;
        }

        /// <summary>
        /// The Card Update 2 function is used to make updates to a customer's card.  This is the web services request with the most options.
        /// </summary>
        /// <param name="cardIdentifierType">C, E, T, c, e, or t (Card Number, Employee Number, Card Token used for the cardIdentifierType)</param>
        /// <param name="cardIdentifier">Employee number, card number, or card token used to search</param>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCard">Y(yes) returns a masked card number. Space or null returns the full card number as long as the accountlevel access allows</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<CardAddUpdateResponse?> UpdateCardV02Async(CardIdentifierType? cardIdentifierType, string cardIdentifier, CardRecordV01 cardDetails, MailingDetailsV02 mailingDetails, bool maskCard)
        {
            var request = new UpdateCardV02Request(cardIdentifierType, cardIdentifier, cardDetails, mailingDetails, maskCard ? "Y" : " ");

            var response = await SendAsync(Channel.UpdateCardV02Async, request);

            if (int.TryParse(response.Response?.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.Response?.ResponseDescription ?? string.Empty);

            return response.Response;
        }



        /// <summary>
        /// The Card Listing request pulls a record of cards for one or more account codes and/or customer IDs. Results can
        /// be filtered by card status(e.g., Active or Blocked). The card list can be generated using masked card numbers or
        /// card tokens, if available.
        /// </summary>
        /// <param name="accountCodes">Alphanumeric value assigned by Comdata; up to 20 account codes can be submitted in a single request</param>
        /// <param name="maskCard">Y (yes) or N (no); the default is N.  Note: The mask card setting at the user level overrides this selection</param>
        /// <param name="status">A = active; B = blocked; C = clear; F = fraud; L = lost; S = stolen; X = permanent block; the default is all statuses</param>
        /// <param name="sortOption">C = sort by card number; T = sort by token; default is C</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Number of the page to display</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<CardListingRecordV01>> CardListingV01Async(AccountCodeRecord[] accountCodes, CardListingMaskCardFlag? maskCard, CardListingStatus? status, CardListingSortOption? sortOption, int maxRows = 10000, int pageNumber = 1)
        {
            var request = new CardListingV01Request(accountCodes, maskCard, status, sortOption, maxRows, pageNumber);

            var response = await SendAsync(Channel.CardListingV01Async, request);

            return new PaginatedDataSet<CardListingRecordV01>(
                response.Records ?? Array.Empty<CardListingRecordV01>(),
                response.RecordCount ?? 0,
                response.PageNbr ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// The Card Listing V02 request pulls a record of cards (and limits) for one or more account codes and/or customer IDs.
        /// Results can be filtered by card status(e.g., Active or Blocked). The card list can be generated using masked card numbers or card tokens, if available.
        /// Along with the card listing information, this operation provide's a card's limit information normally available via the Inquire Card operation.
        /// </summary>
        /// <param name="accountCodes">Alphanumeric value assigned by Comdata; up to 20 account codes can be submitted in a single request</param>
        /// <param name="maskCard">Y (yes) or N (no); the default is N.  Note: The mask card setting at the user level overrides this selection</param>
        /// <param name="status">A = active; B = blocked; C = clear; F = fraud; L = lost; S = stolen; X = permanent block; the default is all statuses</param>
        /// <param name="sortOption">C = sort by card number; T = sort by token; default is C</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Number of the page to display</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<CardListingRecordV02>> CardListingV02Async(AccountCodeRecord[] accountCodes, CardListingMaskCardFlag? maskCard, CardListingStatus? status, CardListingSortOption? sortOption, int maxRows = 10000, int pageNumber = 1)
        {
            var request = new CardListingV02Request(accountCodes, maskCard, status, sortOption, maxRows, pageNumber);

            var response = await SendAsync(Channel.CardListingV02Async, request);

            return new PaginatedDataSet<CardListingRecordV02>(
                response.Records ?? Array.Empty<CardListingRecordV02>(),
                response.RecordCount ?? 0,
                response.PageNbr ?? 0,
                response.PageCount ?? 0);
        }



        /// <summary>
        /// The Recycle Card Limits request is used to recycle/reset any spending limit associated with that card.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata (4-digit customer IDs will include a leading zero)</param>
        /// <param name="cardIdentifierType">Card number, card token, or employee number</param>
        /// <param name="cardIdentifier">C = Card number, T = Card token, E = Employee number</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task RecycleCardLimitsAsync(string accountCode, string customerId, CardIdentifierType? cardIdentifierType, string cardIdentifier)
        {
            var request = new RecycleCardLimitsRequest(accountCode, customerId, cardIdentifierType, cardIdentifier);

            var response = await SendAsync(Channel.RecycleCardLimitsAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);
        }

        #endregion Card Webservice Methods

        #region Card Profile Webservice Methods

        /// <summary>
        /// The Card Profile Limit Inquiry request is used to view card-level transaction limits, including information on
        /// dollar/transaction/and/or quantity limits.You can review limits by overall, daily, and cycle terms.This is an
        /// information-only request. The Card Profile Limit Update request (see below) is used to make changes.
        /// </summary>
        /// <param name="cardProfileLimitRequestUtil"></param>
        /// <param name="empNumCardNumFlag">C, E, c, or e (Card Number or Employee Number): this specifies the type of number used in empNumCardNumValue</param>
        /// <param name="empNumCardNumValue">Employee number or card number used to search</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<InquireCardProfileLimitsResponse> InquireCardProfileLimitsAsync(CardProfileLimitReqResUtil cardProfileLimitRequestUtil, EmpNumCardNumFlag? empNumCardNumFlag, string empNumCardNumValue)
        {
            var request = new InquireCardProfileLimitsRequest(cardProfileLimitRequestUtil, empNumCardNumFlag, empNumCardNumValue);

            var response = await SendAsync(Channel.InquireCardProfileLimitsAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response;
        }

        /// <summary>
        /// The Update Card Profile Limit request is used to adjust the limits on a cardholder's card.  Updates can be made
        /// to the limits set on overall, daily, and cycle transactions in terms of dollars/number of transactions/and/or quantities.
        /// </summary>
        /// <remarks>Note: This function applies to cards with a T cycle status or cards not on company standards.</remarks>
        /// <param name="requestUtil"></param>
        /// <param name="empNumCardNumFlag">C = card number; E = employee number</param>
        /// <param name="empNumCardNumValue">Employee number or card number used as a search criterion based on the empNumCardNumFlag element</param>
        /// <param name="profileLimits"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<CardProfileLimitReqResUtil?> UpdateCardProfileLimitsAsync(CardProfileLimitReqResUtil requestUtil, EmpNumCardNumFlag? empNumCardNumFlag, string empNumCardNumValue, ProfileLimits profileLimits)
        {
            var request = new UpdateCardProfileLimitsRequest(requestUtil, empNumCardNumFlag, empNumCardNumValue, profileLimits);

            var response = await SendAsync(Channel.UpdateCardProfileLimitsAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.ResponseUtil;
        }

        #endregion Card Profile Webservice Methods

        #region Card Security Webservice Methods

        /// <summary>
        /// The Card Security Code Inquiry function is used to retrieve a cardholder's security (CVC2) code.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="discretionaryData">Customer-assigned value returned in the response record</param>
        /// <param name="trackingNumber">Customer-assigned value returned in the response record</param>
        /// <param name="empNumCardNumFlag">C, E, c, or e (Card Number or Employee Number); indicates the number type used for empNumCardNumValue</param>
        /// <param name="empNumCardNumValue">Employee number or card number to search</param>
        /// <param name="cardExpirationDate">YYYY MM DD (Year Month Date)</param>
        /// <param name="maskCard">Y (yes) or N (no); yes masks the full card number</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public Task<InquireCardSecurityCodeResponse> InquireCardSecurityCodeAsync(string accountCode, string customerId, string discretionaryData, string trackingNumber, EmpNumCardNumFlag? empNumCardNumFlag, string empNumCardNumValue, DateTime? cardExpirationDate, bool maskCard)
        {
            var request = new InquireCardSecurityCodeRequest(accountCode, customerId, discretionaryData, trackingNumber, empNumCardNumFlag, empNumCardNumValue, cardExpirationDate, maskCard ? "Y" : "N");

            return SendAsync(Channel.InquireCardSecurityCodeAsync, request);
        }

        #endregion Card Security Webservice Methods

        #region Credit Webservice Methods

        /// <summary>
        /// The Available Credit Inquiry request checks the credit limits and available balance for an Account Code.
        /// </summary>
        /// <param name="accountCodes">1 or more 5-digit alphanumeric account codes  * Need at least one account code but no more than 10.</param>
        /// <param name="activeAccountsOnly">True or false, default is false.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<AvailableCreditInquiryRecord[]> AvailableCreditInquiryAsync(string[] accountCodes, bool activeAccountsOnly)
        {
            var request = new AvailableCreditInquiryRequest(accountCodes, activeAccountsOnly);

            var response = await SendAsync(Channel.AvailableCreditInquiryAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.Records ?? Array.Empty<AvailableCreditInquiryRecord>();
        }

        #endregion Credit Webservice Methods

        #region Customer Id Webservice Methods

        /// <summary>
        /// The Customer ID Listing request pulls information associated with a customer ID including the name, customer
        /// ID status, address information, and type of cards associated with the customer ID.The Customer ID Listing can
        /// be pulled by submitting: a) one or more account codes, in which case the customer IDs should be omitted in the
        /// request; b) one or more customer IDs, in which case the account code or codes should be omitted; c) with both
        /// the account code and customer ID left blank, in which case the response includes all account numbers and
        /// customer IDs available to the user.This request allows you to delimit the number of records returned with a query.
        /// </summary>
        /// <param name="accountCodes">1 or more 5-digit alphanumeric account codes.  *Omit if you are pulling the list by customer IDs</param>
        /// <param name="customerIds">1 or more 4- or 5-digit Customer IDs.  *Omit if you are pulling the list by account codes</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages. 
        /// Enter a page number greater than 1 to see the additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<CustIdListingRecord>> CustIdListingAsync(string[] accountCodes, string[] customerIds, int maxRows = 10000, int pageNumber = 1)
        {
            var request = new CustIdListingRequest(maxRows.ToString(), accountCodes, customerIds, pageNumber.ToString());

            var response = await SendAsync(Channel.CustIdListingAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<CustIdListingRecord>(
                response.Records ?? Array.Empty<CustIdListingRecord>(),
                response.RecordCount ?? 0,
                response.PageNbr ?? 0,
                response.PageCount ?? 0);
        }

        #endregion Customer Id Webservice Methods

        #region Customer Profile Webservice Methods

        /// <summary>
        /// The Customer Profile Limit Inquiry request is used to view customer-level spending limits, including daily
        /// dollar/transaction/quantity and cycle dollar/transaction/quantity limits.
        /// </summary>
        /// <param name="requestUtil"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<InquireCustomerProfileLimitsResponse> InquireCustomerProfileLimitsAsync(CustomerProfileLimitReqRespUtil requestUtil)
        {
            var request = new InquireCustomerProfileLimitsRequest(requestUtil);

            var response = await SendAsync(Channel.InquireCustomerProfileLimitsAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response;
        }

        /// <summary>
        /// The Update Customer Profile Limit request allows you to make changes to the limits on a cardholder's card.
        /// Updates can be made to the limits set on overall, daily, and cycle transactions by dollars/number of
        /// transactions/and/or quantities.
        /// </summary>
        /// <param name="requestUtil"></param>
        /// <param name="profileLimits"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<CustomerProfileLimitReqRespUtil?> UpdateCustomerProfileLimitsAsync(CustomerProfileLimitReqRespUtil requestUtil, ProfileLimits profileLimits)
        {
            var request = new UpdateCustomerProfileLimitsRequest(requestUtil, profileLimits);

            var response = await SendAsync(Channel.UpdateCustomerProfileLimitsAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.ResponseUtil;
        }

        /// <summary>
        /// The Customer Profile Listing request is used to view customer-level transaction profiles.
        /// </summary>
        /// <param name="customerId">Value assigned by Comdata (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="maxRows">The number of profiles the user wants returned per request.Default is 50, max is 999.</param>
        /// <param name="pageNumber">The pageNbr indicates which set of profiles the user wants returned.For example, if maxRows equals 50 and the user wants profiles 51 through 100 returned, then the pageNbr value should be 2.</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<CustomerProfiles>> CustomerProfileListingAsync(string customerId, int maxRows, int pageNumber)
        {
            var request = new CustomerProfileListingRequest(customerId, maxRows.ToString(), pageNumber.ToString());

            var response = await SendAsync(Channel.CustomerProfileListingAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<CustomerProfiles>(
                response.Records ?? Array.Empty<CustomerProfiles>(),
                response.RecordCount ?? response.Records?.Length ?? 0,
                response.PageNbr ?? 0,
                0);
        }

        #endregion Customer Profile Webservice Methods

        #region Driver Id Webservice Methods

        /// <summary>
        /// The Add Driver ID request is used to add a new driver to a driver pool. This request mirrors the Add Driver ID
        /// function in the PS14 batch file process.
        /// </summary>
        /// <param name="record"></param>
        /// <returns>Number of records updated</returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> AddDriverIdAsync(DriverIdRecord record)
        {
            var request = new AddDriverIdRequest(record);

            var response = await SendAsync(Channel.AddDriverIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.NumberChanges ?? default;
        }

        /// <summary>
        /// The Delete Driver ID request is used to remove a driver ID from a driver pool. This request mirrors the Delete
        /// Driver ID function in the PS14 batch file process.
        /// </summary>
        /// <param name="driverId">Numeric driver ID of 6 digits; the field permits <= 16 digits</param>
        /// <param name="customerId">Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="accountNumber">Value assigned by Comdata</param>
        /// <returns>Number of records updated</returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> DeleteDriverIdAsync(string driverId, string customerId, string accountNumber)
        {
            var request = new DeleteDriverIdRequest(driverId, customerId, accountNumber);

            var response = await SendAsync(Channel.DeleteDriverIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.NumberChanges ?? default;
        }

        /// <summary>
        /// The Driver ID Inquiry request is used to pull a list of driver IDs under an account. Search results are returned by
        /// page with up to 50 records per page.In the request, you can specify a page number or the results will display the
        /// first page by default. To retrieve pages 1, 2, 3, and 4 of the records requires four individual requests.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<DriverIdSearchRecord>> InquireDriverIdAsync(DriverIdRecord criteria, int pageNumber = 1)
        {
            var request = new InquireDriverIdRequest(criteria, pageNumber.ToString());

            var response = await SendAsync(Channel.InquireDriverIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<DriverIdSearchRecord>(
                response.Records ?? Array.Empty<DriverIdSearchRecord>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// The Update Driver ID request is used to change driver information for a Driver ID. This request mirrors the
        /// update function in the PS14 batch file process.
        /// </summary>
        /// <param name="record"></param>
        /// <returns>Number of records updated</returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<int> UpdateDriverIdAsync(DriverIdRecord record)
        {
            var request = new UpdateDriverIdRequest(record);

            var response = await SendAsync(Channel.UpdateDriverIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.NumberChanges ?? 0;
        }

        #endregion Driver Id Webservice Methods

        #region Intraday Webservice Methods

        /// <summary>
        /// The MasterCard Intraday request allows customers to retrieve new MasterCard transactions that have occurred
        /// since the time of their last request. This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions. The response record includes transactions authorized at the point of sale
        /// (POS), declines at the POS, settlements (posted), and credits.
        /// </summary>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000.</param>
        /// <param name="startDate">Optional field which allows the reselection of transactions older than the most recent retrieval.
        /// Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="maskCard">Y (yes) or N (no); the default is N.  Masked card numbers appear as follows: 123456XXXXXX1234</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <param name="detailType">PD = Product Details level data will be provided.  If blank, then only regular MasterCard Intraday fields will be returned.</param>
        /// <returns></returns>
        public async Task<PaginatedDataSet<IDTransactionRecordV01>> IntradayV01Async(int maxRows = 10000, DateTime? startDate = null, bool maskCard = false, int pageNumber = 1, string detailType = "")
        {
            var request = new IntradayV01Request(maxRows.ToString(), startDate?.ToString("yyyy-MM-dd") ?? "", maskCard ? "Y" : "N", pageNumber.ToString(), detailType, startDate?.ToString("HH:mm:ss") ?? "");

            var response = await SendAsync(Channel.IntradayV01Async, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<IDTransactionRecordV01>(
                response.Records ?? Array.Empty<IDTransactionRecordV01>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// The MasterCard Intraday request allows customers to retrieve new MasterCard transactions that have occurred
        /// since the time of their last request. This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions. The response record includes transactions authorized at the point of sale
        /// (POS), declines at the POS, settlements (posted), and credits.
        /// </summary>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000.</param>
        /// <param name="startDate">Optional field which allows the reselection of transactions older than the most recent retrieval.
        /// Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="maskCard">Y (yes) or N (no); the default is N.  Masked card numbers appear as follows: 123456XXXXXX1234</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <param name="detailType">PD = Product Details level data will be provided.  If blank, then only regular MasterCard Intraday fields will be returned.</param>
        /// <returns></returns>
        public async Task<PaginatedDataSet<IDTransactionRecordV02>> IntradayV02Async(int maxRows = 10000, DateTime? startDate = null, bool maskCard = false, int pageNumber = 1, string detailType = "")
        {
            var request = new IntradayV02Request(maxRows.ToString(), startDate?.ToString("yyyy-MM-dd") ?? "", maskCard ? "Y" : "N", pageNumber.ToString(), detailType, startDate?.ToString("HH:mm:ss") ?? "");

            var response = await SendAsync(Channel.IntradayV02Async, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<IDTransactionRecordV02>(
                response.Records ?? Array.Empty<IDTransactionRecordV02>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// The MasterCard Intraday Request allows customers to retrieve new MasterCard transactions that have occurred
        /// since the time of their last request.This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions.The response record includes transactions authorized at the point of sale(POS),
        /// declines at the POS, settlements (posted) and credits.
        /// </summary>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000.</param>
        /// <param name="startDate">Optional field which allows the reselection of transactions older than the most recent retrieval.
        /// Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="maskCard">Y (yes) or N (no); the default is N.  Masked card numbers appear as follows: 123456XXXXXX1234</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <param name="detailType">PD = Product Details level data will be provided.  If blank, then only regular MasterCard Intraday fields will be returned.</param>
        /// <returns></returns>
        public async Task<PaginatedDataSet<IDTransactionRecordV01>> IntradayV03Async(int maxRows = 10000, DateTime? startDate = null, bool maskCard = false, int pageNumber = 1, string detailType = "")
        {
            var request = new IntradayV03Request(maxRows.ToString(), startDate?.ToString("yyyy-MM-dd") ?? "", maskCard ? "Y" : "N", pageNumber.ToString(), detailType, startDate?.ToString("HH:mm:ss") ?? "");

            var response = await SendAsync(Channel.IntradayV03Async, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<IDTransactionRecordV01>(
                response.Records ?? Array.Empty<IDTransactionRecordV01>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// The Proprietary Intraday Request allows customers to retrieve new Proprietary transactions that have occurred
        /// since the time of their last request. This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions.The response record includes transactions authorized at the point of sale,
        /// those that have completed settlement(posted), and declined transactions as well.By default, a transaction will
        /// not be included in the response record a second time using this inquiry method.
        /// To access the Proprietary Intraday web service, users must be flagged in iConnectData under the Registration
        /// Module for Web Services.
        /// </summary>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000.</param>
        /// <param name="startDate">Optional field which allows the reselection of transactions older than the most recent retrieval.
        /// Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="maskCard">Y (yes) or N (no); the default is N.  Masked card numbers appear as follows: 123456XXXXXX1234</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <returns></returns>
        public async Task<PaginatedDataSet<PIDTransactionRecord>> ProprietaryIntradayAsync(int maxRows = 10000, DateTime? startDate = null, bool maskCard = false, int pageNumber = 1)
        {
            var request = new ProprietaryIntradayRequest(maxRows.ToString(), startDate?.ToString("yyyy-MM-dd") ?? "", maskCard ? "Y" : "N", pageNumber.ToString(), startDate?.ToString("HH:mm:ss") ?? "");

            var response = await SendAsync(Channel.ProprietaryIntradayAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<PIDTransactionRecord>(
                response.Records ?? Array.Empty<PIDTransactionRecord>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        #endregion Intraday Webservice Methods

        #region Payment Webservice Methods

        /// <summary>
        /// The One-Time Purchase Override request is used to make the next card purchase happen without card limits being applied.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata (4-digit Customer IDs will include a leading zero)</param>
        /// <param name="cardIdentifierType">C = Card number, T = Card token, E = Employee number</param>
        /// <param name="cardIdentifier">Card number, card token, or employee number</param>
        /// <param name="oneTimePurchaseAmount">The amount to add for the One-Time Purchase: 99999999.99</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task OneTimePurchaseOverrideAsync(string accountCode, string customerId, System.Nullable<CardIdentifierType> cardIdentifierType, string cardIdentifier, System.Nullable<decimal> oneTimePurchaseAmount)
        {
            var request = new OneTimePurchaseOverrideRequest(accountCode, customerId, cardIdentifierType, cardIdentifier, oneTimePurchaseAmount);

            var response = await SendAsync(Channel.OneTimePurchaseOverrideAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);
        }

        public async Task<PaginatedDataSet<PaymentHistoryRecord>> PaymentHistoryAsync(string accountCode)
        {
            var request = new PaymentHistoryRequest(accountCode);

            var response = await SendAsync(Channel.PaymentHistoryAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<PaymentHistoryRecord>(
                response.Records ?? Array.Empty<PaymentHistoryRecord>(),
                0,
                0,
                0);
        }

        #endregion Payment Webservice Methods

        #region Transaction History Webservice Methods

        /// <summary>
        /// Pulls a real-time record of all card transactions under the user's Account ID and any Customer IDs to which they have access.
        /// 
        /// The history is limited to a 45-day window and cannot be older than 14 months from the search date.
        /// 
        /// Results can be filtered by search criteria including a specific customer ID, card number, one or more transaction statuses, 
        /// and a start date and/or end date, among others.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber">Searches return up to 10,000 records per page. Searches with 10,000 results are divided into pages.
        /// Enter a page number greater than one to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV01>> RealTimeTransactionHistoryV01Async(RtTransactionCriteriaV01 criteria, int pageNumber = 1)
        {
            var request = new RealTimeTransactionHistoryV01Request(criteria, pageNumber.ToString());

            var response = await SendAsync(Channel.RealTimeTransactionHistoryV01Async, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<RtTransactionRecordV01>(
                response.Records ?? Array.Empty<RtTransactionRecordV01>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// Pulls a real-time record of all card transactions under the user's Account ID and any Customer IDs to which they have access.
        /// 
        /// The history is limited to a 45-day window and cannot be older than 14 months from the search date.
        /// 
        /// Results can be filtered by search criteria including a specific customer ID, card number, one or more transaction statuses, 
        /// and a start date and/or end date, among others.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber">Searches return up to 10,000 records per page. Searches with > 10,000 results are divided into pages. Enter a page number greater than one to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV02>> RealTimeTransactionHistoryV02Async(RtTransactionCriteriaV02 criteria, int pageNumber = 1)
        {
            var request = new RealTimeTransactionHistoryV02Request(criteria, pageNumber.ToString());

            var response = await SendAsync(Channel.RealTimeTransactionHistoryV02Async, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<RtTransactionRecordV02>(
                response.Records ?? Array.Empty<RtTransactionRecordV02>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// Pulls a real-time record of all card transactions under the user's Account ID and any Customer IDs to which they have access.
        /// 
        /// The history is limited to a 45-day window and cannot be older than 14 months from the search date.
        /// 
        /// Results can be filtered by search criteria including a specific customer ID, card number, one or more transaction statuses, 
        /// and a start date and/or end date, among others.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV03>> RealTimeTransactionHistoryV03Async(RtTransactionCriteriaV03 criteria, int pageNumber = 1)
        {
            var request = new RealTimeTransactionHistoryV03Request(criteria, pageNumber.ToString());

            var response = await SendAsync(Channel.RealTimeTransactionHistoryV03Async, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<RtTransactionRecordV03>(
                response.Records ?? Array.Empty<RtTransactionRecordV03>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// Pulls a real-time record of all card transactions under the user's Account ID and any Customer IDs to which they have access.
        /// 
        /// The history is limited to a 45-day window and cannot be older than 14 months from the search date.
        /// 
        /// Results can be filtered by search criteria including a specific customer ID, card number, one or more transaction statuses, 
        /// and a start date and/or end date, among others.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV04>> RealTimeTransactionHistoryV04Async(RtTransactionCriteriaV04 criteria, int pageNumber = 1)
        {
            var request = new RealTimeTransactionHistoryV04Request(criteria, pageNumber.ToString());

            var response = await SendAsync(Channel.RealTimeTransactionHistoryV04Async, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<RtTransactionRecordV04>(
                response.Records ?? Array.Empty<RtTransactionRecordV04>(),
                response.RecordCount ?? 0,
                response.PageNumber ?? 0,
                response.PageCount ?? 0);
        }

        #endregion Transaction History Webservice Methods

        #region Vehicle Id Webservice Methods

        /// <summary>
        /// The Add Vehicle ID request is used to add a new unit to a vehicle pool. This request mirrors the Add Vehicle ID
        /// function in the PS14 batch file process.
        /// </summary>
        /// <param name="record"></param>
        /// <returns>Number of records updated</returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> AddVehicleIdAsync(VehicleIdRecord record)
        {
            var request = new AddVehicleIdRequest(record);

            var response = await SendAsync(Channel.AddVehicleIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.NumberChanges ?? default;
        }

        /// <summary>
        /// The Delete Vehicle ID request is used to remove a vehicle (unit) ID from a vehicle pool. This request mirrors the
        /// Delete Vehicle ID function in the PS14 batch file process.
        /// </summary>
        /// <param name="vehicleId">Also referred to as Vehicle Number, Unit ID, or Unit Number; this
        /// value must be 6 digits or less in the web service request and not 17 digits as in the PS14 batch file process</param>
        /// <param name="customerId">Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="accountNumber">Value assigned by Comdata</param>
        /// <returns>Number of records updated</returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> DeleteVehicleIdAsync(string vehicleId, string customerId, string accountNumber)
        {
            var request = new DeleteVehicleIdRequest(vehicleId, customerId, accountNumber);

            var response = await SendAsync(Channel.DeleteVehicleIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.NumberChanges ?? default;
        }

        /// <summary>
        /// The Vehicle ID Inquiry request is used to pull a list of pooled vehicles (units) under an account. Search results are
        /// returned in a page with 50 records per page.  In the request, you can specify the specific page to view or the first
        /// page will display by default. To retrieve pages 1, 2, 3, and 4 of the records requires four individual requests.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<VehicleIdSearchRecord>> InquireVehicleIdAsync(VehicleIdRecord criteria, int pageNumber = 1)
        {
            var request = new InquireVehicleIdRequest(criteria, pageNumber.ToString());

            var response = await SendAsync(Channel.InquireVehicleIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return new PaginatedDataSet<VehicleIdSearchRecord>(
                response.Records ?? Array.Empty<VehicleIdSearchRecord>(),
                response.RecordCount ?? 0,
                response.PageNbr ?? 0,
                response.PageCount ?? 0);
        }

        /// <summary>
        /// The Update Vehicle ID request is used to change information for a pooled vehicle (unit). This request mirrors the
        /// update function in the PS14 batch file process.
        /// </summary>
        /// <param name="record"></param>
        /// <returns>Number of records updated</returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<int> UpdateVehicleIdAsync(VehicleIdRecord record)
        {
            var request = new UpdateVehicleIdRequest(record);

            var response = await SendAsync(Channel.UpdateVehicleIdAsync, request);

            if (int.TryParse(response.ResponseCode, out int responseCode) && responseCode > 0)
                throw new ComdataOperationException(responseCode, response.ResponseDescription ?? string.Empty);

            return response.NumberChanges ?? default;
        }

        #endregion Vehicle Id Webservice Methods



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
                return new System.ServiceModel.EndpointAddress("https://w6.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200");
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
        /// Update the cached Comdata user credentials
        /// </summary>
        /// <param name="serviceUserName"></param>
        /// <param name="servicePassword"></param>
        /// <param name="networkUserName"></param>
        /// <param name="networkPassword"></param>
        /// <param name="securityCardNumber"></param>
        public void SetCredentials(string serviceUserName, string servicePassword, string networkUserName, string networkPassword)
        {
            SetServiceCredentials(serviceUserName, servicePassword);
            SetNetworkCredentials(networkUserName, networkPassword);
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

        #endregion Authentication Helper Methods

        #region Factory Helper Methods

        public virtual Task OpenAsync()
            => Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));

        public virtual Task CloseAsync()
            => Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));

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
                // Ignore any "no data found" exceptions
                //if (ex.Detail.MessageCode != 99905)
                
                throw new ComdataBusinessException(
                    Convert.ToInt32(ex.Detail.MessageCode), 
                    ex.Detail.Message ?? $"An {ex.GetType().Name} occurred while executing the request.", 
                    ex);
            }
            catch (FaultException ex)
            {
                throw new ComdataOperationException($"An {ex.GetType().Name} occurred while executing the request.", ex);
            }
            catch (Exception ex)
            {
                throw new ComdataException($"An {ex.GetType().Name} occurred while executing the request.", ex);
            }

            //catch (TimeoutException timeProblem)
            //{
            //    ConsoleWriteErrorLine("The service operation timed out.", timeProblem);
            //    client.Abort();
            //}
            //catch (FaultException unknownFault)
            //{
            //    ConsoleWriteErrorLine("An unknown exception was received.", unknownFault);
            //    client.Abort();
            //}
            //catch (CommunicationException commProblem)
            //{
            //    ConsoleWriteErrorLine("There was a communication problem.", commProblem);
            //    client.Abort();
            //}            
        }

        #endregion Webservice Helper Methods



        public enum EndpointConfiguration { FleetCreditWS0200 }
    }
}