using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.Exceptions;
using Comdata.FleetCreditWS0200.Models;
using Comdata.Models.Internals;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Comdata.FleetCreditWS0200
{
    [DebuggerStepThrough()]
    public partial class FleetCreditWS0200Client : ClientBase<IFleetCreditWS0200>
    {
        #region Constructors

        public FleetCreditWS0200Client() : base(GetDefaultBinding(), GetDefaultEndpointAddress())
        {
            Endpoint.Name = ComdataEndpointType.Production.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(string remoteAddress) : base(GetDefaultBinding(), GetEndpointAddress(remoteAddress))
        {
            Endpoint.Name = ComdataEndpointType.Production.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(ComdataEndpointType endpointConfiguration) : base(GetDefaultBinding(), GetEndpointAddress(endpointConfiguration))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(ComdataEndpointType endpointConfiguration, string remoteAddress) : base(GetDefaultBinding(), new EndpointAddress(remoteAddress))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(ComdataEndpointType endpointConfiguration, EndpointAddress remoteAddress) : base(GetDefaultBinding(), remoteAddress)
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public FleetCreditWS0200Client(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

        #endregion Constructors



        #region Card Webservice Methods

        /// <summary>
        /// The Add Card request is used to order a card via a web service mirroring PS14 functionality.
        /// </summary>
        /// <remarks>
        /// The Card Add request requires the following information:
        /// <list type="bullet">
        /// <item>requested card limit</item>
        /// <item>card expiration date</item>
        /// <item>card status</item>
        /// </list>
        /// </remarks>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCardFlag"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<CardAddUpdateResponse> AddCardV01Async(CardRecordV01 cardDetails, MailingDetailsV01 mailingDetails, YesNoCharFlag maskCardFlag)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new AddCardV01Request(cardDetails, mailingDetails, maskCardFlag);

            // Send the request
            var response = await SendAsync(Channel.AddCardV01Async, request);

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode, response.Content.ResponseDescription);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// The Add Card V02 request is used to order a card via a web service.
        /// </summary>
        /// <remarks>
        /// The Card Add request requires the following information:
        /// <list type="bullet">
        /// <item>requested card limit</item>
        /// <item>card expiration date</item>
        /// <item>card status</item>
        /// </list>
        /// </remarks>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCardFlag"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<CardAddUpdateResponse> AddCardV02Async(CardRecordV02 cardDetails, MailingDetailsV01 mailingDetails, YesNoCharFlag maskCardFlag)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new AddCardV02Request(cardDetails, mailingDetails, maskCardFlag);

            // Send the request
            var response = await SendAsync(Channel.AddCardV02Async, request);

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode, response.Content.ResponseDescription);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// The Add Card V03 request is used to order a card via a web service while combining the following features:
        /// <list type="bullet">
        /// <item>Create card</item>
        /// <item>Set Customer Profile Limits</item>
        /// <item>Return card details and limits along with security code</item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <para>
        /// The Card Add request requires the following information:
        /// <list type="bullet">
        /// <item>Requested card limits</item>
        /// <item>Card expiration date</item>
        /// <item>Card status</item>
        /// </list>
        /// </para>
        /// <para>
        /// This is a specialized card add operation that operation only with the following card settings:
        /// <list type="bullet">
        /// <item>Cycle type "T" (never reset)</item>
        /// <item>Off company standards/profile (profileFlag = "N")</item>
        /// </list>
        /// </para>
        /// <para>Attempting to create cards outside of these settings will result in an input validation error.</para>
        /// </remarks>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="profileLimits"></param>
        /// <param name="maskCard"></param>
        /// <param name="securityCode"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public Task<AddCardV03Response> AddCardV03Async(CardRecordV03 cardDetails, MailingDetailsV02 mailingDetails, ProfileLimits profileLimits, bool maskCard, bool securityCode)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new AddCardV03Request(cardDetails, mailingDetails, profileLimits, maskCard, securityCode);

            // Return the result of the operation
            return SendAsync(Channel.AddCardV03Async, request);
        }



        /// <summary>The Card Inquiry function is used to request the current attributes of a card.</summary>
        /// <remarks>No card updates can be performed using this function.It is an information-only request.</remarks>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="discretionaryData">Customer-assigned value returned in the response record</param>
        /// <param name="trackingNumber">Customer-assigned value returned in the response record</param>
        /// <param name="empNumCardNumFlag">C, E, c, or e (Card Number or Employee Number will be used in the empNumCardNumValue field)</param>
        /// <param name="empNumCardNumValue">Employee number or card number used as a search criterion based on the empNumCardNumFlag element</param>
        /// <param name="maskCardFlag">Y (yes) returns a masked card number. Space or null returns the full card number as long as the account-level access allows.</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        [Obsolete("This operation has been deprecated and will be removed at some point in the future. Please use the latest version of this function.")]
        public Task<InquireCardV01Response> InquireCardV01Async(string accountCode, string customerId, string discretionaryData, string trackingNumber, EmpNumCardNumFlag? empNumCardNumFlag, string empNumCardNumValue, YesNoNullCharFlag maskCardFlag)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new InquireCardV01Request(accountCode, customerId, discretionaryData, trackingNumber, empNumCardNumFlag, empNumCardNumValue, maskCardFlag);

            // Return the result of the operation
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
        /// <param name="maskCardFlag">Y(yes) returns a masked card number. Space or null returns the full card number as long as the account-level access allows.</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public Task<InquireCardV02Response> InquireCardV02Async(string accountCode, string customerId, string discretionaryData, string trackingNumber, CardIdentifierType cardIdentifierType, string cardIdentifier, YesNoNullCharFlag maskCardFlag)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new InquireCardV02Request(accountCode, customerId, discretionaryData, trackingNumber, cardIdentifierType, cardIdentifier, maskCardFlag);

            // Return the result of the operation
            return SendAsync(Channel.InquireCardV02Async, request);
        }



        /// <summary>
        /// The Card Update function is used to make updates to a customer's card.  This is the web service's request with the most options, and it is likely to be the most used.
        /// </summary>
        /// <param name="empNumCardNumFlag">C, E, c, or e (Card Number or Employee Number used for the empNumCardNumValue)</param>
        /// <param name="empNumCardNumValue">Employee number or card number used to search</param>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCardFlag">Y (yes) or N (no); Yes returns a masked card number</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        [Obsolete("This operation has been deprecated and will be removed at some point in the future. Please use the latest version of this function.")]
        public async Task<CardAddUpdateResponse> UpdateCardV01Async(EmpNumCardNumFlag? empNumCardNumFlag, string empNumCardNumValue, CardRecordV01 cardDetails, MailingDetailsV01 mailingDetails, YesNoCharFlag maskCardFlag)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new UpdateCardV01Request(empNumCardNumFlag, empNumCardNumValue, cardDetails, mailingDetails, maskCardFlag);

            // Send the request
            var response = await SendAsync(Channel.UpdateCardV01Async, request);

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode, response.Content.ResponseDescription);

            // Return the result of the operation
            return response.Content;
        }

        /// <summary>
        /// The Card Update function is used to make updates to a customer's card.  This is the web service's request with the most options, and it is likely to be the most used.
        /// </summary>
        /// <param name="cardIdentifierType">C, E, T, c, e, or t (Card Number, Employee Number, Card Token used for the cardIdentifierType)</param>
        /// <param name="cardIdentifier">Employee number, card number, or card token used to search</param>
        /// <param name="cardDetails"></param>
        /// <param name="mailingDetails"></param>
        /// <param name="maskCardFlag">Y(yes) returns a masked card number. Space or null returns the full card number as long as the accountlevel access allows</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<CardAddUpdateResponse> UpdateCardV02Async(CardIdentifierType? cardIdentifierType, string cardIdentifier, CardRecordV01 cardDetails, MailingDetailsV02 mailingDetails, YesNoNullCharFlag maskCardFlag)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new UpdateCardV02Request(cardIdentifierType, cardIdentifier, cardDetails, mailingDetails, maskCardFlag);

            // Send the request
            var response = await SendAsync(Channel.UpdateCardV02Async, request);

            // Inject any error messages into an exception
            if (response.Content.ResponseCode > 0)
                throw new ComdataOperationException(response.Content.ResponseCode, response.Content.ResponseDescription);

            // Return the result of the operation
            return response.Content;
        }



        /// <summary>
        /// The Card Listing request pulls a record of cards for one or more account codes and/or customer IDs. Results can
        /// be filtered by card status(e.g., Active or Blocked). The card list can be generated using masked card numbers or
        /// card tokens, if available.
        /// </summary>
        /// <param name="accountCodes">Alphanumeric value assigned by Comdata; up to 20 account codes can be submitted in a single request</param>
        /// <param name="maskCardFlag">Y (yes) or N (no); the default is N</param>
        /// <param name="status">A = active; B = blocked; C = clear; F = fraud; L = lost; S = stolen; X = permanent block; the default is all statuses</param>
        /// <param name="sortOption">C = sort by card number; T = sort by token; default is C</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Number of the page to display</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<CardListingRecordV01>> CardListingV01Async(AccountCodeRecord[] accountCodes, CardListingMaskCardFlag? maskCardFlag, CardListingStatus? status, CardListingSortOption? sortOption, int maxRows, int pageNumber)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardListingV01Request(accountCodes, maskCardFlag, status, sortOption, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.CardListingV01Async, request);

            // Return the result of the operation
            return new PaginatedDataSet<CardListingRecordV01>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The Card Listing V02 request pulls a record of cards (and limits) for one or more account codes and/or customer
        /// IDs.  Results can be filtered by card status(e.g., Active or Blocked). The card list can be generated using masked
        /// card numbers or card tokens, if available.
        /// </summary>
        /// <remarks>
        /// Along with the card listing information, this operation provides a card's limit information normally available via 
        /// the 'Inquire Card' operation.
        /// </remarks>
        /// <param name="accountCodes">Alphanumeric value assigned by Comdata; up to 20 account codes can be submitted in a single request</param>
        /// <param name="maskCardFlag">Y (yes) or BLANK (no); default is BLANK;  Note: The mask card setting at the user level overrides this selection</param>
        /// <param name="status">A = active; B = blocked; C = clear; F = fraud; L = lost; S = stolen; X = permanent block; default is all statuses</param>
        /// <param name="sortOption">C = sort by card number; T = sort by token; default is C</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Number of the page to display</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<PaginatedDataSet<CardListingRecordV02>> CardListingV02Async(AccountCodeRecord[] accountCodes, CardListingMaskCardFlag? maskCardFlag,
            CardListingStatus? status, CardListingSortOption? sortOption, int maxRows = 10000, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CardListingV02Request(accountCodes, maskCardFlag, status, sortOption, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.CardListingV02Async, request);

            // Return the result of the operation
            return new PaginatedDataSet<CardListingRecordV02>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }



        /// <summary>
        /// The Recycle Card Limits request is used to recycle/reset any spending limit associated with that card.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata (4-digit customer IDs will include a leading zero)</param>
        /// <param name="cardIdentifierType">C = Card number; T = Card token; E = Employee number</param>
        /// <param name="cardIdentifier">Card number, card token, or employee number</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<bool> RecycleCardLimitsAsync(string accountCode, string customerId, CardIdentifierType cardIdentifierType, string cardIdentifier)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new RecycleCardLimitsRequest(accountCode, customerId, cardIdentifierType, cardIdentifier);

            // Send the request
            var response = await SendAsync(Channel.RecycleCardLimitsAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription ?? string.Empty);

            // Return the result of the operation
            return response.ResponseCode == 0;
        }



        /// <summary>
        /// The Card Security Code Inquiry function is used to retrieve a cardholder's security (CVC2) code.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="discretionaryData">Customer-assigned value returned in the response record</param>
        /// <param name="trackingNumber">Customer-assigned value returned in the response record</param>
        /// <param name="empNumCardNumFlag"></param>
        /// <param name="empNumCardNumValue"></param>
        /// <param name="cardExpirationDate"></param>
        /// <param name="maskCardFlag"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public Task<InquireCardSecurityCodeResponse> InquireCardSecurityCodeAsync(string accountCode, string customerId, string discretionaryData, string trackingNumber, EmpNumCardNumFlag empNumCardNumFlag,
            string empNumCardNumValue, DateTime cardExpirationDate, YesNoCharFlag maskCardFlag = YesNoCharFlag.No)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new InquireCardSecurityCodeRequest(accountCode, customerId, discretionaryData, trackingNumber, empNumCardNumFlag, empNumCardNumValue, cardExpirationDate, maskCardFlag);

            // Send the request
            return SendAsync(Channel.InquireCardSecurityCodeAsync, request);
        }

        /// <summary>
        /// The Card Profile Limit Inquiry request is used to view card-level transaction limits, including information on
        /// dollar/transaction/and/or quantity limits.You can review limits by overall, daily, and cycle terms.This is an
        /// information-only request. The 'Card Profile Limit Update' operation is used to make changes.
        /// </summary>
        /// <param name="cardProfileLimitRequestUtil"></param>
        /// <param name="empNumCardNumFlag">C, E, c, or e (Card Number or Employee Number): this specifies the type of number used in empNumCardNumValue</param>
        /// <param name="empNumCardNumValue">Employee number or card number used to search</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<ProfileLimits> InquireCardProfileLimitsAsync(CardProfileLimitReqResUtil cardProfileLimitRequestUtil, EmpNumCardNumFlag empNumCardNumFlag, string empNumCardNumValue)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new InquireCardProfileLimitsRequest(cardProfileLimitRequestUtil, empNumCardNumFlag, empNumCardNumValue);

            // Send the request
            var response = await SendAsync(Channel.InquireCardProfileLimitsAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription ?? string.Empty);

            // Return the result of the operation
            return response.ProfileLimits;
        }

        /// The Update Card Profile Limit request is used to Updates can be made
        /// to the limits set on overall, daily, and cycle transactions in terms of dollars/number of transactions/and/or
        /// quantities.
        /// <param name="requestUtil"></param>
        /// <param name="empNumCardNumFlag">C = card number; E = employee number</param>
        /// <param name="empNumCardNumValue">Employee number or card number used as a search criterion based on the empNumCardNumFlag element</param>
        /// <param name="profileLimits"></param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<bool> UpdateCardProfileLimitsAsync(CardProfileLimitReqResUtil requestUtil, EmpNumCardNumFlag empNumCardNumFlag, string empNumCardNumValue, ProfileLimits profileLimits)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new UpdateCardProfileLimitsRequest(requestUtil, empNumCardNumFlag, empNumCardNumValue, profileLimits);

            // Send the request
            var response = await SendAsync(Channel.UpdateCardProfileLimitsAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription ?? string.Empty);

            // Return the result of the operation
            return response.ResponseCode == 0;
        }

        #endregion Card Webservice Methods

        #region Credit Inquiry Webservice Methods

        /// <summary>
        /// The Available Credit Inquiry request checks the credit limits and available balance for an Account Code.
        /// </summary>
        /// <param name="accountCodes">1 or more 5-digit alphanumeric account codes  *Need at least one account code but no more than 10.</param>
        /// <param name="activeAccountsOnly">True or false, default is false.</param>
        /// <returns></returns>
        /// <exception cref="ComdataException"></exception>
        public async Task<AvailableCreditInquiryRecord[]> AvailableCreditInquiryAsync(string[] accountCodes, bool activeAccountsOnly = false)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new AvailableCreditInquiryRequest(accountCodes, activeAccountsOnly);

            // Send the request
            var response = await SendAsync(Channel.AvailableCreditInquiryAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.Records;
        }

        #endregion Credit Inquiry Webservice Methods

        #region Customer Webservice Methods

        /// <summary>
        /// The Customer Profile Listing request is used to view customer-level transaction profiles.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PaginatedDataSet<CustomerProfiles>> CustomerProfileListingAsync(string customerId, int maxRows = 50, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CustomerProfileListingRequest(customerId, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.CustomerProfileListingAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<CustomerProfiles>(response.Records, response.RecordCount, response.PageNumber, 0 /*response.PageCount*/);
        }

        /// <summary>
        /// The Customer Profile Limit Inquiry request is used to view customer-level spending limits, including daily
        /// dollar/transaction/quantity and cycle dollar/transaction/quantity limits.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="discretionaryData">Customer-assigned value returned in the response record</param>
        /// <param name="trackingNumber">Customer-assigned value returned in the response record</param>
        /// <param name="profileID">3-digit profile ID specified by customer</param>
        /// <param name="productCode">5-digit product level (merchant group or MCC)</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<ProfileLimits> InquireCustomerProfileLimitsAsync(string accountCode, string customerId, string discretionaryData, string trackingNumber, string profileID, int productCode)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new InquireCustomerProfileLimitsRequest(new CustomerProfileLimitReqRespUtil(accountCode, customerId, discretionaryData, trackingNumber, profileID, productCode));

            // Send the request
            var response = await SendAsync(Channel.InquireCustomerProfileLimitsAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.ProfileLimits;
        }



        /// <summary>
        /// The Update Customer Profile Limit request allows you to make changes to the limits on a cardholder's card.
        /// Updates can be made to the limits set on overall, daily, and cycle transactions by dollars/number of
        /// transactions/and/or quantities.
        /// </summary>
        /// <param name="accountCode">Value assigned by Comdata</param>
        /// <param name="customerId">Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <param name="discretionaryData">Customer-assigned value returned in the response record</param>
        /// <param name="trackingNumber">Customer-assigned value returned in the response record</param>
        /// <param name="profileID">3-digit profile ID specified by customer</param>
        /// <param name="productCode">5-digit product level (merchant group or MCC)</param>
        /// <param name="profileLimits"></param>
        /// <returns></returns>
        public Task<bool> UpdateCustomerProfileLimitsAsync(string accountCode, string customerId, string discretionaryData, string trackingNumber, string profileID, int productCode, ProfileLimits profileLimits)
            => UpdateCustomerProfileLimitsAsync(new CustomerProfileLimitReqRespUtil(accountCode, customerId, discretionaryData, trackingNumber, profileID, productCode), profileLimits);

        /// <summary>
        /// The Update Customer Profile Limit request allows you to make changes to the limits on a cardholder's card.
        /// Updates can be made to the limits set on overall, daily, and cycle transactions by dollars/number of
        /// transactions/and/or quantities.
        /// </summary>
        /// <param name="requestUtil"></param>
        /// <param name="profileLimits"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<bool> UpdateCustomerProfileLimitsAsync(CustomerProfileLimitReqRespUtil requestUtil, ProfileLimits profileLimits)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new UpdateCustomerProfileLimitsRequest(requestUtil, profileLimits);

            // Send the request
            var response = await SendAsync(Channel.UpdateCustomerProfileLimitsAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.ResponseCode == 0;
        }



        /// <summary>
        /// The Customer ID Listing request pulls information associated with a customer ID including the name, customer
        /// ID status, address information, and type of cards associated with the customer ID.
        /// </summary>
        /// <remarks>
        /// <para>The Customer ID Listing can be pulled by submitting:</para>
        /// <list type="number">
        /// <item>one or more account codes, in which case the customer IDs should be omitted in the request;</item>
        /// <item>one or more customer IDs, in which case the account code or codes should be omitted;</item>
        /// <item>with both the account code and customer ID left blank, in which case the response includes all account numbers and customer IDs available to the user.This request allows you to delimit the number of records returned with a query.</item>
        /// </list>
        /// </remarks>
        /// <param name="accountCodes">1 or more 5-digit alphanumeric account codes  *Omit if you are pulling the list by customer IDs</param>
        /// <param name="customerIds">1 or more 4- or 5-digit Customer IDs.  *Omit if you are pulling the list by account code</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see the additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<CustIdListingRecord>> CustIdListingAsync(string[] accountCodes, string[] customerIds, int maxRows = 10000, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new CustIdListingRequest(accountCodes, customerIds, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.CustIdListingAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<CustIdListingRecord>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        #endregion Customer Webservice Methods

        #region Driver Id Webservice Methods

        /// <summary>
        /// The Driver ID Inquiry request is used to pull a list of driver IDs under an account. Search results are returned by
        /// page with up to 50 records per page.  In the request, you can specify a page number or the results will display the
        /// first page by default. To retrieve pages 1, 2, 3, and 4 of the records requires four individual requests.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber"><= 6 digits</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<DriverIdSearchRecord>> InquireDriverIdAsync(DriverIdRecord criteria, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new InquireDriverIdRequest(criteria, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.InquireDriverIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<DriverIdSearchRecord>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The Add Driver ID request is used to add a new driver to a driver pool. This request mirrors the Add Driver ID
        /// function in the PS14 batch file process.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> AddDriverIdAsync(DriverIdRecord record)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new AddDriverIdRequest(record);

            // Send the request
            var response = await SendAsync(Channel.AddDriverIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.NumberChanges;
        }

        /// <summary>
        /// The Update Driver ID request is used to change driver information for a Driver ID. This request mirrors the
        /// update function in the PS14 batch file process.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> UpdateDriverIdAsync(DriverIdRecord record)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new UpdateDriverIdRequest(record);

            // Send the request
            var response = await SendAsync(Channel.UpdateDriverIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.NumberChanges;
        }

        /// <summary>
        /// The Delete Driver ID request is used to remove a driver ID from a driver pool. This request mirrors the Delete
        /// Driver ID function in the PS14 batch file process.
        /// </summary>
        /// <param name="driverId">Numeric driver ID of 6 digits; the field permits <= 16 digits</param>
        /// <param name="customerId">Value assigned by Comdata</param>
        /// <param name="accountNumber">Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> DeleteDriverIdAsync(string driverId, string accountNumber, string customerId)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new DeleteDriverIdRequest(driverId, accountNumber, customerId);

            // Send the request
            var response = await SendAsync(Channel.DeleteDriverIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.NumberChanges;
        }

        #endregion Driver Id Webservice Methods

        #region Intraday Webservice Methods

        /// <summary>
        /// The MasterCard Intraday request allows customers to retrieve new MasterCard transactions that have occurred
        /// since the time of their last request.This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions.The response record includes transactions authorized at the point of sale
        /// (POS), declines at the POS, settlements (posted), and credits.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This service is not intended to be an alternative delivery method for batch
        /// reconciliation files(AC29/AC30), which contain full details for settled transactions.
        /// It is intended to be used as notification of transaction events (authorizations,
        /// declines, posting, credits) and associated key data elements.
        /// </para>
        /// <para>
        /// Transactions older than 7 days are purged from the Intraday database and will not
        /// be available for retrieval by this service.
        /// </para>
        /// <para>
        /// Internal Comdata Note: To access the MasterCard Intraday web service, users
        /// must be flagged in iConnectData under the Registration Module for Web Services.
        /// </para>
        /// </remarks>
        /// <param name="start">Optional field which allows the reselection of transactions older than the most recent retrieval.Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="detailType">PD = Product Details level data will be provided.  If blank, then only regular MasterCard Intraday fields will be returned.</param>
        /// <param name="maskCardFlag">Y (yes) or N (no); the default is N; Masked card numbers appear as follows: 123456XXXXXX1234</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<IDTransactionRecordV01>> IntradayV01Async(DateTime? start, IntradayDetailType detailType = IntradayDetailType.Regular, YesNoCharFlag maskCardFlag = YesNoCharFlag.No, int maxRows = 10000, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new IntradayV01Request(start, detailType, maskCardFlag, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.IntradayV01Async, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<IDTransactionRecordV01>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The MasterCard Intraday request allows customers to retrieve new MasterCard transactions that have occurred
        /// since the time of their last request. This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions. The response record includes transactions authorized at the point of sale
        /// (POS), declines at the POS, settlements (posted), and credits.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This service is not intended to be an alternative delivery method for batch
        /// reconciliation files(AC29/AC30), which contain full details for settled transactions.
        /// It is intended to be used as notification of transaction events (authorizations,
        /// declines, posting, credits) and associated key data elements.
        /// </para>
        /// <para>
        /// Transactions older than 7 days are purged from the Intraday database and will not
        /// be available for retrieval by this service.
        /// </para>
        /// <para>
        /// Internal Comdata Note: To access the MasterCard Intraday web service, users
        /// must be flagged in iConnectData under the Registration Module for Web Services.
        /// </para>
        /// </remarks>
        /// <param name="start">Optional field which allows the reselection of transactions older than the most recent retrieval.Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="detailType">PD = Product Details level data will be provided.  If blank, then only regular MasterCard Intraday fields will be returned.</param>
        /// <param name="maskCardFlag">Y (yes) or N (no); the default is N; Masked card numbers appear as follows: 123456XXXXXX1234</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<IDTransactionRecordV02>> IntradayV02Async(DateTime? start, IntradayDetailType detailType = IntradayDetailType.Regular, YesNoCharFlag maskCardFlag = YesNoCharFlag.No, int maxRows = 10000, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new IntradayV02Request(start, detailType, maskCardFlag, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.IntradayV02Async, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<IDTransactionRecordV02>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The MasterCard Intraday request allows customers to retrieve new MasterCard transactions that have occurred
        /// since the time of their last request. This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions. The response record includes transactions authorized at the point of sale
        /// (POS), declines at the POS, settlements (posted), and credits.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This service is not intended to be an alternative delivery method for batch
        /// reconciliation files (AC29/AC30), which contain full details for settled transactions.
        /// It is intended to be used as notification of transaction events (authorizations,
        /// declines, posting, credits) and associated key data elements.
        /// </para>
        /// <para>
        /// Transactions older than 7 days are purged from the Intraday database and will not
        /// be available for retrieval by this service.
        /// </para>
        /// <para>
        /// Internal Comdata Note: To access the MasterCard Intraday web service, users
        /// must be flagged in iConnectData under the Registration Module for Web Services.
        /// </para>
        /// </remarks>
        /// <param name="start">Optional field which allows the reselection of transactions older than the most recent retrieval.Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="detailType">PD = Product Details level data will be provided.  If blank, then only regular MasterCard Intraday fields will be returned.</param>
        /// <param name="maskCardFlag">Y (yes) or N (no); the default is N; Masked card numbers appear as follows: 123456XXXXXX1234</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<IDTransactionRecordV01>> IntradayV03Async(DateTime? start, IntradayDetailType detailType = IntradayDetailType.Regular, YesNoCharFlag maskCardFlag = YesNoCharFlag.No, int maxRows = 10000, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new IntradayV03Request(start, detailType, maskCardFlag, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.IntradayV03Async, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<IDTransactionRecordV01>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// <para>
        /// The Proprietary Intraday Request allows customers to retrieve new Proprietary transactions that have occurred
        /// since the time of their last request.This allows for review of new transactions without the burden of processing
        /// previously retrieved transactions.The response record includes transactions authorized at the point of sale,
        /// those that have completed settlement(posted), and declined transactions as well.By default, a transaction will
        /// not be included in the response record a second time using this inquiry method.
        /// </para>
        /// <para>
        /// To access the Proprietary Intraday web service, users must be flagged in iConnectData under the Registration
        /// Module for Web Services.
        /// </para>
        /// </summary>
        /// <param name="start">Optional field which allows the reselection of transactions older than the most recent retrieval.Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</param>
        /// <param name="maskCardFlag">Y (yes) or N (no); the default is N; Masked card numbers appear as follows: 123XXXX123</param>
        /// <param name="maxRows">Number of rows to display per page; values between 1 and 10,000; the default is 10,000</param>
        /// <param name="pageNumber">Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<PIDTransactionRecord>> ProprietaryIntradayAsync(DateTime? start, YesNoCharFlag maskCardFlag = YesNoCharFlag.No, int maxRows = 10000, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new ProprietaryIntradayRequest(start, maskCardFlag, maxRows, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.ProprietaryIntradayAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<PIDTransactionRecord>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        #endregion Intraday Webservice Methods

        #region Payment Webservice Methods

        /// <summary>
        /// The One-Time Purchase Override request is used to make the next card purchase happen without card limits being applied.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> OneTimePurchaseOverrideAsync(string accountCode, string customerId, string cardIdentifier, CardIdentifierType cardIdentifierType, decimal oneTimePurchaseAmount)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new OneTimePurchaseOverrideRequest(accountCode, customerId, cardIdentifier, cardIdentifierType, oneTimePurchaseAmount);

            // Send the request
            var response = await SendAsync(Channel.OneTimePurchaseOverrideAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.ResponseCode == 0;
        }

        /// <summary>
        /// The Real Time Transaction History request pulls a real-time record of all payments under the user's 
        /// Account ID and any Customer IDs to which they have access.
        /// </summary>
        /// <param name="accountCode">Alphanumeric value assigned by Comdata</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaymentHistoryRecord[]> PaymentHistoryAsync(string accountCode)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new PaymentHistoryRequest(accountCode);

            // Send the request
            var response = await SendAsync(Channel.PaymentHistoryAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.Records;
        }

        #endregion Payment Webservice Methods

        #region Transaction History Webservice Methods

        /// <summary>
        /// The Real Time Transaction History request pulls a real-time record of all card transactions under the user's
        /// Account ID and any Customer IDs to which they have access. The history is limited to a 45-day window and
        /// cannot be older than 14 months from the search date. Results can be filtered by search criteria including a
        /// specific customer ID, card number, one or more transaction statuses, and a start date and/or end date, among others.
        /// </summary>
        /// <remarks>
        /// To access this web service, users must be flagged in iConnectData under the Reporting Registration Module. The
        /// flag is Real-Time Transaction History Web Service.
        /// </remarks>
        /// <param name="criteria"></param>
        /// <param name="pageNumber">Searches return up to 10,000 records per page. Searches with 10,000 results are divided into pages. Enter a page number greater than one to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV01>> RealTimeTransactionHistoryV01Async(RtTransactionCriteriaV01 criteria, int pageNumber)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new RealTimeTransactionHistoryV01Request(criteria, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.RealTimeTransactionHistoryV01Async, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<RtTransactionRecordV01>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The Real Time Transaction History 2 request pulls a real-time record of all card transactions under the user's
        /// Account ID and any Customer IDs to which they have access. The history is limited to a 45-day window and
        /// cannot be older than 14 months from the search date. Results can be filtered by search criteria including a
        /// specific customer ID, card number, one or more transaction statuses, and a start date and/or end date, among others.
        /// </summary>
        /// <remarks>
        /// To access this web service, users must be flagged in iConnectData under the Reporting Registration Module. The
        /// flag is Real-Time Transaction History Web Service.
        /// </remarks>
        /// <param name="criteria"></param>
        /// <param name="pageNumber">Searches return up to 10,000 records per page. Searches with 10,000 results are divided into pages. Enter a page number greater than one to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV02>> RealTimeTransactionHistoryV02Async(RtTransactionCriteriaV02 criteria, int pageNumber)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new RealTimeTransactionHistoryV02Request(criteria, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.RealTimeTransactionHistoryV02Async, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<RtTransactionRecordV02>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The Real Time Transaction History 3 request pulls a real-time record of all card transactions under the user's
        /// Account ID and any Customer IDs to which they have access. The history is limited to a 45-day window and
        /// cannot be older than 14 months from the search date. Results can be filtered by search criteria including a
        /// specific customer ID, card number, one or more transaction statuses, and a start date and/or end date, among others.
        /// </summary>
        /// <remarks>
        /// To access this web service, users must be flagged in iConnectData under the Reporting Registration Module. The
        /// flag is Real-Time Transaction History Web Service.
        /// </remarks>
        /// <param name="criteria"></param>
        /// <param name="pageNumber">Searches return up to 10,000 records per page. Searches with 10,000 results are divided into pages. Enter a page number greater than one to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV03>> RealTimeTransactionHistoryV03Async(RtTransactionCriteriaV03 criteria, int pageNumber)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new RealTimeTransactionHistoryV03Request(criteria, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.RealTimeTransactionHistoryV03Async, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<RtTransactionRecordV03>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The Real Time Transaction History 2 request pulls a real-time record of all card transactions under the user's
        /// Account ID and any Customer IDs to which they have access. The history is limited to a 45-day window and
        /// cannot be older than 14 months from the search date. Results can be filtered by search criteria including a
        /// specific customer ID, card number, one or more transaction statuses, and a start date and/or end date, among others.
        /// </summary>
        /// <remarks>
        /// To access this web service, users must be flagged in iConnectData under the Reporting Registration Module. The
        /// flag is Real-Time Transaction History Web Service.
        /// </remarks>
        /// <param name="criteria"></param>
        /// <param name="pageNumber">Searches return up to 10,000 records per page. Searches with 10,000 results are divided into pages. Enter a page number greater than one to see these additional pages.</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<RtTransactionRecordV04>> RealTimeTransactionHistoryV04Async(RtTransactionCriteriaV04 criteria, int pageNumber)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new RealTimeTransactionHistoryV04Request(criteria, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.RealTimeTransactionHistoryV04Async, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<RtTransactionRecordV04>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        #endregion Transaction History Webservice Methods

        #region Vehicle Id Webservice Methods

        /// <summary>
        /// The Vehicle ID Inquiry request is used to pull a list of pooled vehicles (units) under an account.  Search results are returned by
        /// page with up to 50 records per page.  In the request, you can specify a page number or the results will display the
        /// first page by default. To retrieve pages 1, 2, 3, and 4 of the records requires four individual requests.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="pageNumber"><= 6 digits</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<PaginatedDataSet<VehicleIdSearchRecord>> InquireVehicleIdAsync(VehicleIdRecord criteria, int pageNumber = 1)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new InquireVehicleIdRequest(criteria, pageNumber);

            // Send the request
            var response = await SendAsync(Channel.InquireVehicleIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return new PaginatedDataSet<VehicleIdSearchRecord>(response.Records, response.RecordCount, response.PageNumber, response.PageCount);
        }

        /// <summary>
        /// The Add Vehicle ID request is used to add a new unit to a vehicle pool. This request mirrors the Add Vehicle ID
        /// function in the PS14 batch file process.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> AddVehicleIdAsync(VehicleIdRecord criteria)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new AddVehicleIdRequest(criteria);

            // Send the request
            var response = await SendAsync(Channel.AddVehicleIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.NumberChanges;
        }

        /// <summary>
        /// The Update Vehicle ID request is used to change information for a pooled vehicle (unit). This request mirrors the
        /// update function in the PS14 batch file process.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> UpdateVehicleIdAsync(VehicleIdRecord criteria)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new UpdateVehicleIdRequest(criteria);

            // Send the request
            var response = await SendAsync(Channel.UpdateVehicleIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.NumberChanges;
        }

        /// <summary>
        /// The Delete Vehicle ID request is used to remove a vehicle (unit) ID from a vehicle pool. This request mirrors the
        /// Delete Vehicle ID function in the PS14 batch file process.
        /// </summary>
        /// <param name="vehicleId">Also referred to as Vehicle Number, Unit ID, or Unit Number; this value must be <= 6 digits in the web service request and not <=17 digits as in the PS14 batch file process</param>
        /// <param name="customerId">Value assigned by Comdata</param>
        /// <param name="accountNumber">Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)</param>
        /// <returns></returns>
        /// <exception cref="ComdataOperationException"></exception>
        public async Task<int> DeleteVehicleIdAsync(string vehicleId, string accountNumber, string customerId)
        {
            // Ensures that all credentials have been provided.
            ValidateCredentials();

            // Compile the request
            var request = new DeleteVehicleIdRequest(vehicleId, accountNumber, customerId);

            // Send the request
            var response = await SendAsync(Channel.DeleteVehicleIdAsync, request);

            // Inject any error messages into an exception
            if (response.ResponseCode > 0)
                throw new ComdataOperationException(response.ResponseCode, response.ResponseDescription);

            // Return the result of the operation
            return response.NumberChanges;
        }

        #endregion Vehicle Id Webservice Methods



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
                ComdataEndpointType.Test => new EndpointAddress("https://w8cert.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200"),
                ComdataEndpointType.Production => new EndpointAddress("https://w6.iconnectdata.com/FleetCreditWS/services/FleetCreditWS0200"),
                _ => throw new InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration))
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
        }

        #endregion Authentication Helper Methods

        #region Factory Helper Methods

        public virtual Task OpenAsync()
            => Task.Factory.FromAsync(((ICommunicationObject)this).BeginOpen(null, null), new Action<IAsyncResult>(((ICommunicationObject)this).EndOpen));

        public virtual Task CloseAsync()
            => Task.Factory.FromAsync(((ICommunicationObject)this).BeginClose(null, null), new Action<IAsyncResult>(((ICommunicationObject)this).EndClose));

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