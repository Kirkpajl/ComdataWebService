using System;
using System.Collections.Generic;
using System.Text;
using Comdata.FleetCreditWS0200.Models;
using Comdata.FleetCreditWS0200.Exceptions;

namespace Comdata.FleetCreditWS0200
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", ConfigurationName = "Comdata.FleetCreditWS0200.FleetCreditWS0200")]
    public interface IFleetCreditWS0200
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCard", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCard", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<InquireCardV01Response> InquireCardV01Async(InquireCardV01Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardV02", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<InquireCardV02Response> InquireCardV02Async(InquireCardV02Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCard", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCard", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<UpdateCardV01Response> UpdateCardV01Async(UpdateCardV01Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardV02", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<UpdateCardV02Response> UpdateCardV02Async(UpdateCardV02Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCard", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCard", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<AddCardV01Response> AddCardV01Async(AddCardV01Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV02", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<AddCardV02Response> AddCardV02Async(AddCardV02Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV03", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addCardV03", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<AddCardV03Response> AddCardV03Async(AddCardV03Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/customerProfileListing", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/customerProfileListing", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<CustomerProfileListingResponse> CustomerProfileListingAsync(CustomerProfileListingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCustomerProfileLimits", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCustomerProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<InquireCustomerProfileLimitsResponse> InquireCustomerProfileLimitsAsync(InquireCustomerProfileLimitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCustomerProfileLimits", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCustomerProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<UpdateCustomerProfileLimitsResponse> UpdateCustomerProfileLimitsAsync(UpdateCustomerProfileLimitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardSecurityCode", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardSecurityCode", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<InquireCardSecurityCodeResponse> InquireCardSecurityCodeAsync(InquireCardSecurityCodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardProfileLimits", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireCardProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<InquireCardProfileLimitsResponse> InquireCardProfileLimitsAsync(InquireCardProfileLimitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardProfileLimits", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateCardProfileLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<UpdateCardProfileLimitsResponse> UpdateCardProfileLimitsAsync(UpdateCardProfileLimitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireDriverId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<InquireDriverIdResponse> InquireDriverIdAsync(InquireDriverIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addDriverId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<AddDriverIdResponse> AddDriverIdAsync(AddDriverIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateDriverId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<UpdateDriverIdResponse> UpdateDriverIdAsync(UpdateDriverIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteDriverId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteDriverId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<DeleteDriverIdResponse> DeleteDriverIdAsync(DeleteDriverIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireVehicleId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/inquireVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<InquireVehicleIdResponse> InquireVehicleIdAsync(InquireVehicleIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addVehicleId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/addVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<AddVehicleIdResponse> AddVehicleIdAsync(AddVehicleIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateVehicleId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/updateVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<UpdateVehicleIdResponse> UpdateVehicleIdAsync(UpdateVehicleIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteVehicleId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/deleteVehicleId", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<DeleteVehicleIdResponse> DeleteVehicleIdAsync(DeleteVehicleIdRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistory", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistory", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<RealTimeTransactionHistoryV01Response> RealTimeTransactionHistoryV01Async(RealTimeTransactionHistoryV01Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV02", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<RealTimeTransactionHistoryV02Response> RealTimeTransactionHistoryV02Async(RealTimeTransactionHistoryV02Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV03", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV03", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<RealTimeTransactionHistoryV03Response> RealTimeTransactionHistoryV03Async(RealTimeTransactionHistoryV03Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV04", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/realTimeTransactionHistoryV04", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<RealTimeTransactionHistoryV04Response> RealTimeTransactionHistoryV04Async(RealTimeTransactionHistoryV04Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/custIdListing", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/custIdListing", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<CustIdListingResponse> CustIdListingAsync(CustIdListingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/availableCreditInquiry", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/availableCreditInquiry", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<AvailableCreditInquiryResponse> AvailableCreditInquiryAsync(AvailableCreditInquiryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intraday", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intraday", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<IntradayV01Response> IntradayV01Async(IntradayV01Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV02", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<IntradayV02Response> IntradayV02Async(IntradayV02Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV03", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/intradayV03", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<IntradayV03Response> IntradayV03Async(IntradayV03Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/proprietaryIntraday", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/proprietaryIntraday", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<ProprietaryIntradayResponse> ProprietaryIntradayAsync(ProprietaryIntradayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListing", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListing", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<CardListingV01Response> CardListingV01Async(CardListingV01Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListingV02", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/cardListingV02", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<CardListingV02Response> CardListingV02Async(CardListingV02Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/recycleCardLimits", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/recycleCardLimits", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<RecycleCardLimitsResponse> RecycleCardLimitsAsync(RecycleCardLimitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/oneTimePurchaseOverride", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/oneTimePurchaseOverride", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<OneTimePurchaseOverrideResponse> OneTimePurchaseOverrideAsync(OneTimePurchaseOverrideRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/paymentHistory", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessException), Action = "http://fleetCredit02.comdata.com/FleetCreditWS0200/paymentHistory", Name = "BusinessException", Namespace = "http://fleetCredit.comdata.com/exception/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<PaymentHistoryResponse> PaymentHistoryAsync(PaymentHistoryRequest request);
    }
}
