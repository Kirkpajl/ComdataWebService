using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardUpdateV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateRequestV02Body : ISoapRequestBody<CardUpdateRequestV02>
    {
        public CardUpdateRequestV02Body() : this(new CardUpdateRequestV02()) { }
        public CardUpdateRequestV02Body(CardUpdateRequestV02 request) { Request = request; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "updateRequestV02", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardUpdateRequestV02 Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardUpdateV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateRequestV02Body
    {
        public CardUpdateRequestBodyV02() : this(new CardUpdateRequestV02()) { }

        public CardUpdateRequestBodyV02(CardUpdateRequestV02 request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "updateRequestV02", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardUpdateRequestV02 Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardUpdateRequestV02 : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CashRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? DriverLicenseNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? DriverLicenseState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? EmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? FirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? LastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? OilRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? OneTwoRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? ReeferRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? OtherRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? PhoneRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "primaryCardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? PrimaryCardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? PurchaseRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trailerNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? TrailerNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? TripNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "unitNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? UnitNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "atmAccess", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? AtmAccess { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public string? CardStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "voiceMailEmail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? VoiceMailEmail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public double CashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeCashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 27)]
        public double OneTimeCashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilDollarLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 28)]
        public double OilDollarLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 29)]
        public double PhoneLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 30)]
        public double PurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimePurchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 31)]
        public double OneTimePurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 32)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dieselGallonLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 33)]
        public int DieselGallonLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilQuartLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 34)]
        public int OilQuartLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferGallonLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 35)]
        public int ReeferGallonLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 36)]
        public int ReeferQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 37)]
        public int OneTwoQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 38)]
        public int OtherQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public System.Nullable<bool> CashRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public System.Nullable<bool> CashRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "companyStandards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public System.Nullable<bool> CompanyStandards { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "conferenceCall", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public System.Nullable<bool> ConferenceCall { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCash", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public System.Nullable<bool> ExpressCash { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "faxMail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public System.Nullable<bool> FaxMail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fuelPurchase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public System.Nullable<bool> FuelPurchase { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "informationService", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public System.Nullable<bool> InformationService { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedNetworkByCard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public System.Nullable<bool> LimitedNetworkByCard { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "messageService", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public System.Nullable<bool> MessageService { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public System.Nullable<bool> OilRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public System.Nullable<bool> OilRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "OneTwoRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public System.Nullable<bool> OneTwoRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public System.Nullable<bool> OneTwoRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public System.Nullable<bool> ReeferRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public System.Nullable<bool> ReeferRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public System.Nullable<bool> OtherRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public System.Nullable<bool> OtherRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeFuelOffNetwork", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public System.Nullable<bool> OneTimeFuelOffNetwork { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public System.Nullable<bool> PhoneRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public System.Nullable<bool> PhoneRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneService", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public System.Nullable<bool> PhoneService { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public System.Nullable<bool> PurchaseRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public System.Nullable<bool> PurchaseRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vruAccess", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public System.Nullable<bool> VruAccess { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ignore1HourCheck", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public System.Nullable<bool> Ignore1HourCheck { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? TripNumber2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? TripNumber3 { get; set; }
    }
}
