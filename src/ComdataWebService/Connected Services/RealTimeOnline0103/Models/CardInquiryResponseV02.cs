using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardInquiryResponseV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseV02Body : ISoapResponseBody<CardInquiryResponseV02>
    {
        public CardInquiryResponseV02Body() : this(new CardInquiryResponseV02()) { }
        public CardInquiryResponseV02Body(CardInquiryResponseV02 response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardInquiryReturnV02", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV02 Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardInquiryResponseV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseBodyV02
    {
        public CardInquiryResponseBodyV02() : this(new CardInquiryResponseV02()) { }

        public CardInquiryResponseBodyV02(CardInquiryResponseV02 response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardInquiryReturnV02", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV02 Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardInquiryResponseV02 : ISoapResponse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "atmAccess", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? AtmAccess { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardBalance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public double CardBalance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CardStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public double CashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? CashRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public double CashUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dieselGallonLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public int DieselGallonLimit { get; set; }

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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilDollarLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public double OilDollarLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilDollarsUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public double OilDollarsUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilQuartLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public int OilQuartLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilQuartsUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public int OilQuartsUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? OilRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeCashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public double OneTimeCashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimePurchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
        public double OneTimePurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "primaryCardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? PrimaryCardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public double PurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? PurchaseRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public double PurchaseUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferGallonLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 27)]
        public int ReeferGallonLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 28)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 30)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trailerNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? TrailerNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? TripNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "unitNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? UnitNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 34)]
        public bool CashRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 35)]
        public bool CashRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "companyStandards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 36)]
        public bool CompanyStandards { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCash", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 37)]
        public bool ExpressCash { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fuelPurchase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 38)]
        public bool FuelPurchase { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedNetworkByCard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 39)]
        public bool LimitedNetworkByCard { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 40)]
        public bool OilRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 41)]
        public bool OilRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeFuelOffNetwork", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 42)]
        public bool OneTimeFuelOffNetwork { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 43)]
        public bool PurchaseRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 44)]
        public bool PurchaseRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vruAccess", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 45)]
        public bool VruAccess { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expCardEmployeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? ExpCardEmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ignore1HourCheck", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 47)]
        public bool Ignore1HourCheck { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 48)]
        public int OtherQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 49)]
        public bool OneTwoRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public string? OneTwoRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 51)]
        public bool OneTwoRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 52)]
        public bool ReeferRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public string? ReeferRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 54)]
        public bool ReeferRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 55)]
        public bool OtherRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public string? OtherRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 57)]
        public bool OtherRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? TripNumber2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? TripNumber3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tokenNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? TokenNumber { get; set; }
    }
}
