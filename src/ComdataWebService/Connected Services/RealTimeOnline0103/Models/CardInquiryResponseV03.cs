using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardInquiryResponseV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseV03Body : ISoapResponseBody<CardInquiryResponseV03>
    {
        public CardInquiryResponseV03Body() : this(new CardInquiryResponseV03()) { }
        public CardInquiryResponseV03Body(CardInquiryResponseV03 response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardInquiryReturnV03", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV03 Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardInquiryResponseV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseV03Body
    {
        public CardInquiryResponseV03Body() : this(new CardInquiryResponseV03()) { }

        public CardInquiryResponseV03Body(CardInquiryResponseV03 response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardInquiryReturnV03", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV03 Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardInquiryResponseV03 : ISoapResponse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "atmAccess", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? AtmAccess { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardBalance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CardBalance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CardStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? CashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? CashRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? CashUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dieselGallonLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? DieselGallonLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? FirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? LastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? DriverLicenseNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? DriverLicenseState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? DriverName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilDollarLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? OilDollarLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilDollarsUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? OilDollarsUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilQuartLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? OilQuartLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilQuartsUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? OilQuartsUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? OilRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeCashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? OneTimeCashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimePurchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? OneTimePurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "primaryCardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? PrimaryCardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public string? PurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? PurchaseRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public string? PurchaseUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferGallonLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? ReeferGallonLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public int? ResponseCode { get; set; }  //public string ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public long? TrackingNumber { get; set; }  //public string? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trailerNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? TrailerNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? TripNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? CashRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public string? CashRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "companyStandards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? CompanyStandards { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCash", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public string? ExpressCash { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fuelPurchase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? FuelPurchase { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedNetworkByCard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public string? LimitedNetworkByCard { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public string? OilRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public string? OilRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeFuelOffNetwork", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public string? OneTimeFuelOffNetwork { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public string? PurchaseRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public string? PurchaseRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vruAccess", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public string? VruAccess { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expCardEmployeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public string? ExpCardEmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ignore1HourCheck", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? Ignore1HourCheck { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public string? OtherQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public string? OneTwoRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public string? OneTwoRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public string? OneTwoRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public string? ReeferRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public string? ReeferRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public string? ReeferRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public string? OtherRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public string? OtherRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public string? OtherRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public string? TripNumber2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? TripNumber3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "unitNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? UnitNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHoldAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? CardHoldAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tokenNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public string? TokenNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderAddress1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public string? CardHolderAddress1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderAddress2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public string? CardHolderAddress2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderCity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public string? CardHolderCity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? CardHolderState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderZip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? CardHolderZip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 67)]
        public string? CardHolderType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "businessName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 68)]
        public string? BusinessName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderDOB", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 69)]
        public string? CardHolderDOB { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "taxIdType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 70)]
        public string? TaxIdType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "taxId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 71)]
        public string? TaxId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderEmail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 72)]
        public string? CardHolderEmail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderPhone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 73)]
        public string? CardHolderPhone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderWorkLocState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 74)]
        public string? CardHolderWorkLocState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderUseType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 75)]
        public string? CardHolderUseType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderEmailAlertSignUp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 76)]
        public string? CardHolderEmailAlertSignUp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderTextAlertSignUp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 77)]
        public string? CardHolderTextAlertSignUp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cipFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 78)]
        public string? CipFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cipDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 79)]
        public string? CipDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "onRoadCardIndicator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 80)]
        public string? OnRoadCardIndicator { get; set; }
    }
}
