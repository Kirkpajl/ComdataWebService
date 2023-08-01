using Comdata.Exceptions;
using Comdata.FleetCreditWS0200.Models;

namespace Comdata.FleetCreditWS0200
{

    [System.ServiceModel.ServiceContract(Namespace = "http://fleetCredit02.comdata.com/maintenance/", ConfigurationName = "Comdata.FleetCreditWS0200.FleetCreditWS0200")]
    public interface IFleetCreditWS0200
    {
        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCard", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCard", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<InquireCardV01Response> InquireCardV01Async(InquireCardV01Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardV02", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<InquireCardV02Response> InquireCardV02Async(InquireCardV02Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCard", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCard", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<UpdateCardV01Response> UpdateCardV01Async(UpdateCardV01Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardV02", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<UpdateCardV02Response> UpdateCardV02Async(UpdateCardV02Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCard", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCard", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<AddCardV01Response> AddCardV01Async(AddCardV01Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV02", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<AddCardV02Response> AddCardV02Async(AddCardV02Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV03", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV03", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<AddCardV03Response> AddCardV03Async(AddCardV03Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/customerProfileListing", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/customerProfileListing", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CustomerProfileListingResponse> CustomerProfileListingAsync(CustomerProfileListingRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCustomerProfileLimits", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCustomerProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<InquireCustomerProfileLimitsResponse> InquireCustomerProfileLimitsAsync(InquireCustomerProfileLimitsRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCustomerProfileLimits", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCustomerProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<UpdateCustomerProfileLimitsResponse> UpdateCustomerProfileLimitsAsync(UpdateCustomerProfileLimitsRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardSecurityCode", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardSecurityCode", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<InquireCardSecurityCodeResponse> InquireCardSecurityCodeAsync(InquireCardSecurityCodeRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardProfileLimits", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<InquireCardProfileLimitsResponse> InquireCardProfileLimitsAsync(InquireCardProfileLimitsRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardProfileLimits", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<UpdateCardProfileLimitsResponse> UpdateCardProfileLimitsAsync(UpdateCardProfileLimitsRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireDriverId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<InquireDriverIdResponse> InquireDriverIdAsync(InquireDriverIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addDriverId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<AddDriverIdResponse> AddDriverIdAsync(AddDriverIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateDriverId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<UpdateDriverIdResponse> UpdateDriverIdAsync(UpdateDriverIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteDriverId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<DeleteDriverIdResponse> DeleteDriverIdAsync(DeleteDriverIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireVehicleId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<InquireVehicleIdResponse> InquireVehicleIdAsync(InquireVehicleIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addVehicleId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<AddVehicleIdResponse> AddVehicleIdAsync(AddVehicleIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateVehicleId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<UpdateVehicleIdResponse> UpdateVehicleIdAsync(UpdateVehicleIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteVehicleId", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<DeleteVehicleIdResponse> DeleteVehicleIdAsync(DeleteVehicleIdRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistory", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistory", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<RealTimeTransactionHistoryV01Response> RealTimeTransactionHistoryV01Async(RealTimeTransactionHistoryV01Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV02", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<RealTimeTransactionHistoryV02Response> RealTimeTransactionHistoryV02Async(RealTimeTransactionHistoryV02Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV03", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV03", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<RealTimeTransactionHistoryV03Response> RealTimeTransactionHistoryV03Async(RealTimeTransactionHistoryV03Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV04", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV04", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<RealTimeTransactionHistoryV04Response> RealTimeTransactionHistoryV04Async(RealTimeTransactionHistoryV04Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/custIdListing", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/custIdListing", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CustIdListingResponse> CustIdListingAsync(CustIdListingRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/availableCreditInquiry", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/availableCreditInquiry", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<AvailableCreditInquiryResponse> AvailableCreditInquiryAsync(AvailableCreditInquiryRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intraday", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intraday", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<IntradayV01Response> IntradayV01Async(IntradayV01Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV02", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<IntradayV02Response> IntradayV02Async(IntradayV02Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV03", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV03", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<IntradayV03Response> IntradayV03Async(IntradayV03Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/proprietaryIntraday", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/proprietaryIntraday", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<ProprietaryIntradayResponse> ProprietaryIntradayAsync(ProprietaryIntradayRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListing", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListing", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardListingV01Response> CardListingV01Async(CardListingV01Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListingV02", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListingV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardListingV02Response> CardListingV02Async(CardListingV02Request request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/recycleCardLimits", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/recycleCardLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<RecycleCardLimitsResponse> RecycleCardLimitsAsync(RecycleCardLimitsRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/oneTimePurchaseOverride", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/oneTimePurchaseOverride", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<OneTimePurchaseOverrideResponse> OneTimePurchaseOverrideAsync(OneTimePurchaseOverrideRequest request);

        [OperationContract(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/paymentHistory", ReplyAction = "*")]
        [FaultContract(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/paymentHistory", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<PaymentHistoryResponse> PaymentHistoryAsync(PaymentHistoryRequest request);
    }
}
