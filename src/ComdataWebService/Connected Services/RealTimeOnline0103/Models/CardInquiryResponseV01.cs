using Comdata.RealTimeOnline0103.Enumerations;
using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseV01Body : ISoapResponseBody<CardInquiryResponseV01>
    {
        public CardInquiryResponseV01Body() : this(new CardInquiryResponseV01()) { }
        public CardInquiryResponseV01Body(CardInquiryResponseV01 response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV01 Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseBody
    {
        public CardInquiryResponseBody()
        {
            this.Response = new CardInquiryResponse();
        }

        public CardInquiryResponseBody(CardInquiryResponse response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponse Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardInquiryResponseV01 : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// C or E = Yes 
        /// N or blank = No
        /// </summary>
        [XmlElement(ElementName = "atmAccess", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? AtmAccessString { get; set; }

        [XmlIgnore]
        public bool AtmAccess => AtmAccessString == "C" || AtmAccessString == "E";

        /// <summary>
        /// Express Cash balance (999999.99 to -999999.99).
        /// </summary>
        [XmlElement(ElementName = "cardBalance", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public double CardBalance { get; set; }

        /// <summary>
        /// The last 10 digits of the card number inquired upon.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// A=Active B=Blocked C=Clear D=Delete
        /// </summary>
        [XmlElement(ElementName = "cardStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public Nullable<CardInquiryCardStatus> CardStatus { get; set; }  //string?

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "cashLimit", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public double CashLimit { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Cash Advance else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// Advance else empty tag
        /// </example>
        [XmlElement(ElementName = "cashRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? CashRenewDayOfWeek { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "cashUsed", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public double CashUsed { get; set; }

        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// 99999
        /// </summary>
        [XmlElement(ElementName = "dieselGallonLimit", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public int DieselGallonLimit { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Cardholder First Name
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Cardholder Last Name
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? LastName { get; set; }

        /// <summary>
        /// Driver License Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "driverLicenseNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? DriverLicenseNumber { get; set; }

        /// <summary>
        /// 2 letter abbreviation of Driver License State.
        /// </summary>
        [XmlElement(ElementName = "driverLicenseState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? DriverLicenseState { get; set; }

        /// <summary>
        /// Format: [Cardholder Last Name],[Cardholder First Name]
        /// </summary>
        [XmlElement(ElementName = "driverName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? DriverName { get; set; }

        /// <summary>
        /// Employee Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// 999.99
        /// </summary>
        [XmlElement(ElementName = "oilDollarLimit", Form = XmlSchemaForm.Unqualified, Order = 17)]
        public double OilDollarLimit { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "oilDollarsUsed", Form = XmlSchemaForm.Unqualified, Order = 18)]
        public double OilDollarsUsed { get; set; }

        /// <summary>
        /// 999
        /// </summary>
        [XmlElement(ElementName = "oilQuartLimit", Form = XmlSchemaForm.Unqualified, Order = 19)]
        public int OilQuartLimit { get; set; }

        /// <summary>
        /// 9999
        /// </summary>
        [XmlElement(ElementName = "oilQuartsUsed", Form = XmlSchemaForm.Unqualified, Order = 20)]
        public int OilQuartsUsed { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Oil else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "oilRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? OilRenewDayOfWeek { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "oneTimeCashLimit", Form = XmlSchemaForm.Unqualified, Order = 22)]
        public double OneTimeCashLimit { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "oneTimePurchaseLimit", Form = XmlSchemaForm.Unqualified, Order = 23)]
        public double OneTimePurchaseLimit { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "phoneLimit", Form = XmlSchemaForm.Unqualified, Order = 24)]
        public double PhoneLimit { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Phone else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "phoneRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? PhoneRenewDayOfWeek { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "phoneUsed", Form = XmlSchemaForm.Unqualified, Order = 26)]
        public double PhoneUsed { get; set; }

        /// <summary>
        /// Primary Card Nbr if flagged for Primary/Secondary Card else empty tag
        /// </summary>
        [XmlElement(ElementName = "primaryCardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? PrimaryCardNumber { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "purchaseLimit", Form = XmlSchemaForm.Unqualified, Order = 28)]
        public double PurchaseLimit { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Fuel else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001 
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "purchaseRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? PurchaseRenewDayOfWeek { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "purchaseUsed", Form = XmlSchemaForm.Unqualified, Order = 30)]
        public double PurchaseUsed { get; set; }

        /// <summary>
        /// 99999
        /// </summary>
        [XmlElement(ElementName = "reeferGallonLimit", Form = XmlSchemaForm.Unqualified, Order = 31)]
        public int ReeferGallonLimit { get; set; }

        /// <summary>
        /// 0=Inquiry Successful 
        /// Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 32)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 34)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Trailer number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "trailerNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? TrailerNumber { get; set; }

        /// <summary>
        /// Trip number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Unit number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? UnitNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "voiceMailEmail", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public Nullable<CardInquiryVoicemailEmail> VoiceMailEmail { get; set; }  //string?

        /// <remarks/>
        [XmlElement(ElementName = "cashRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 39)]
        public bool CashRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cashRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 40)]
        public bool CashRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "companyStandards", Form = XmlSchemaForm.Unqualified, Order = 41)]
        public bool CompanyStandards { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "conferenceCall", Form = XmlSchemaForm.Unqualified, Order = 42)]
        public bool ConferenceCall { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "expressCash", Form = XmlSchemaForm.Unqualified, Order = 43)]
        public bool ExpressCash { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "faxMail", Form = XmlSchemaForm.Unqualified, Order = 44)]
        public bool FaxMail { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "fuelPurchase", Form = XmlSchemaForm.Unqualified, Order = 45)]
        public bool FuelPurchase { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "informationService", Form = XmlSchemaForm.Unqualified, Order = 46)]
        public bool InformationService { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "limitedNetworkByCard", Form = XmlSchemaForm.Unqualified, Order = 47)]
        public bool LimitedNetworkByCard { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "messageService", Form = XmlSchemaForm.Unqualified, Order = 48)]
        public bool MessageService { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oilRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 49)]
        public bool OilRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oilRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 50)]
        public bool OilRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTimeFuelOffNetwork", Form = XmlSchemaForm.Unqualified, Order = 51)]
        public bool OneTimeFuelOffNetwork { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "phoneRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 52)]
        public bool PhoneRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "phoneRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 53)]
        public bool PhoneRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "phoneService", Form = XmlSchemaForm.Unqualified, Order = 54)]
        public bool PhoneService { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "purchaseRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 55)]
        public bool PurchaseRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "purchaseRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 56)]
        public bool PurchaseRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "vruAccess", Form = XmlSchemaForm.Unqualified, Order = 57)]
        public bool VruAccess { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "expCardEmployeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? ExpCardEmployeeNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "ignore1HourCheck", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public System.Nullable<bool> Ignore1HourCheck { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherQuantityLimit", Form = XmlSchemaForm.Unqualified, Order = 60)]
        public int OtherQuantityLimit { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTwoRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public System.Nullable<bool> OneTwoRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTwoRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public string? OneTwoRenewDayOfWeek { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTwoRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public System.Nullable<bool> OneTwoRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "reeferRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public System.Nullable<bool> ReeferRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "reeferRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? ReeferRenewDayOfWeek { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "reeferRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public System.Nullable<bool> ReeferRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 67)]
        public System.Nullable<bool> OtherRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 68)]
        public string? OtherRenewDayOfWeek { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 69)]
        public System.Nullable<bool> OtherRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "tripNumber2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 70)]
        public string? TripNumber2 { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "tripNumber3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 71)]
        public string? TripNumber3 { get; set; }
    }
}
