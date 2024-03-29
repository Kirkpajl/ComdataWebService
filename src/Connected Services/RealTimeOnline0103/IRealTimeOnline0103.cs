﻿using Comdata.RealTimeOnline0103.Models;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Comdata.RealTimeOnline0103
{
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [ServiceContract(Namespace="http://cows0103.comdata.com", ConfigurationName="Comdata.RealTimeOnline0103")]
    public interface IRealTimeOnline0103
    {
        [OperationContract(Action = "cardBlockUnblock", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardBlockUnblockResponseBody> CardBlockUnblockAsync(CardBlockUnblockRequestBody request);

        [OperationContract(Action = "cardInquiry", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardInquiryResponseV01Body> CardInquiryAsync(CardInquiryRequestV01Body request);

        [OperationContract(Action = "cardInquiryV02", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardInquiryResponseV02Body> CardInquiryV02Async(CardInquiryRequestV02Body request);

        [OperationContract(Action = "cardInquiryV03", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardInquiryResponseV03Body> CardInquiryV03Async(CardInquiryRequestV03Body request);

        [OperationContract(Action = "cardMoveMaintenance", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardMoveMaintenanceResponseBody> CardMoveMaintenanceAsync(CardMoveMaintenanceRequestBody request);

        [OperationContract(Action = "cardUpdate", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardUpdateResponseV01Body> CardUpdateAsync(CardUpdateRequestV01Body request);

        [OperationContract(Action = "cardUpdateV02", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardUpdateResponseV02Body> CardUpdateV02Async(CardUpdateRequestV02Body request);

        [OperationContract(Action = "cardUpdateV03", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardUpdateResponseV03Body> CardUpdateV03Async(CardUpdateRequestV03Body request);



        [OperationContract(Action = "DirectDepositAddUpdate", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<DirectDepositAddUpdateResponseBody> DirectDepositAddUpdateAsync(DirectDepositAddUpdateRequestBody request);

        [OperationContract(Action = "DirectDepositInquiry", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<DirectDepositInquiryResponseBody> DirectDepositInquiryAsync(DirectDepositInquiryRequestBody request);



        [OperationContract(Action="expressCheckInquiry", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Task<ExpressCheckInquiryResponseBody> ExpressCheckInquiryAsync(ExpressCheckInquiryRequestBody request);
        
        [OperationContract(Action="expressCheckIssue", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Task<ExpressCheckIssueResponseBody> ExpressCheckIssueAsync(ExpressCheckIssueRequestBody request);
        
        [OperationContract(Action="expressCheckMaintenance", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Task<ExpressCheckMaintenanceResponseBody> ExpressCheckMaintenanceAsync(ExpressCheckMaintenanceRequestBody request);

        [OperationContract(Action = "expressCheckBatch", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<ExpressCheckBatchResponseBody> ExpressCheckBatchAsync(ExpressCheckBatchRequestBody request);

        [OperationContract(Action = "expressCheckRetrieval", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<ExpressCheckRetrievalResponseBody> ExpressCheckRetrievalAsync(ExpressCheckRetrievalRequestBody request);



        [OperationContract(Action="limitedNetworkByCardUpdate", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Task<LimitedNetworkByCardUpdateResponseBody> LimitedNetworkByCardUpdateAsync(LimitedNetworkByCardUpdateRequestBody request);



        [OperationContract(Action = "locationMaintenance", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<LocationMaintenanceResponseBody> LocationMaintenanceAsync(LocationMaintenanceRequestBody request);



        [OperationContract(Action="loadMoney", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Task<LoadMoneyResponseBody> LoadMoneyAsync(LoadMoneyRequestBody request);
        
        [OperationContract(Action="loadMoneyComchek", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Task<LoadMoneyComchekResponseBody> LoadMoneyComchekAsync(LoadMoneyComchekRequestBody request);
        
        [OperationContract(Action="loadMoneyCancel", ReplyAction="*")]
        [XmlSerializerFormat(SupportFaults=true)]
        Task<LoadMoneyCancelResponseBody> LoadMoneyCancelAsync(LoadMoneyCancelRequestBody request);



        [OperationContract(Action = "pinSet", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<PinSetResponseBody> PinSetAsync(PinSetRequestBody request);



        [OperationContract(Action = "pinReset", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<PinResetResponseBody> PinResetAsync(PinResetRequestBody request);



        [OperationContract(Action = "trackCardShipmentStatus", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<TrackCardShipmentResponseBody> TrackCardShipmentStatusAsync(TrackCardShipmentRequestBody request);



        [OperationContract(Action = "transferToBank", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<TransferToBankResponseBody> TransferToBankAsync(TransferToBankRequestBody request);

        [OperationContract(Action = "transferMaintenance", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<CardTransferMaintenanceResponseBody> TransferMaintenanceAsync(CardTransferMaintenanceRequestBody request);

        [OperationContract(Action = "transferMaintenanceByCardtoken", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<TransferMaintenanceByCardtokenResponseBody> TransferMaintenanceByCardtokenAsync(TransferMaintenanceByCardtokenRequestBody request);



        [OperationContract(Action = "virtualCardAdd", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<VirtualCardAddResponseBody> VirtualCardAddAsync(VirtualCardAddRequestBody request);

        //[OperationContract(Action = "virtualCardAddAsync", ReplyAction = "*")]
        //[XmlSerializerFormat(SupportFaults = true)]
        //Task<VirtualCardAddAsyncResponse> VirtualCardAddAsync(VirtualCardAddAsyncRequest request);

        [OperationContract(Action = "virtualCardInquiry", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<VirtualCardInquiryResponseBody> VirtualCardInquiryAsync(VirtualCardInquiryRequestBody request);

        //[OperationContract(Action = "virtualCardInquiryAsync", ReplyAction = "*")]
        //[XmlSerializerFormat(SupportFaults = true)]
        //Task<VirtualCardInquiryAsyncResponse> VirtualCardInquiryAsync(VirtualCardInquiryAsyncRequest request);

        [OperationContract(Action = "virtualCardUpdate", ReplyAction = "*")]
        Task<VirtualCardUpdateResponseBody> VirtualCardUpdateAsync(VirtualCardUpdateRequestBody request);

        //[OperationContract(Action = "virtualCardUpdateAsync", ReplyAction = "*")]
        //[XmlSerializerFormat(SupportFaults = true)]
        //Task<VirtualCardUpdateAsyncResponse> VirtualCardUpdateAsync(VirtualCardUpdateAsyncRequest request);



        [OperationContract(Action = "virtualComchekAdd", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<VirtualComchekAddResponseBody> VirtualComchekAddAsync(VirtualComchekAddRequestBody request);

        [OperationContract(Action = "virtualComchekInquiry", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<VirtualComchekInquiryResponseBody> VirtualComchekInquiryAsync(VirtualComchekInquiryRequestBody request);

        [OperationContract(Action = "virtualComchekUpdate", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        Task<VirtualComchekUpdateResponseBody> VirtualComchekUpdateAsync(VirtualComchekUpdateRequestBody request);
    }    
}
