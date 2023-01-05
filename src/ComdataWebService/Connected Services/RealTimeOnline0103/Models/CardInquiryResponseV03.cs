using Comdata.Models.Internals;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using Comdata.RealTimeOnline0103.Enumerations;
using System.Security.Policy;
using System.ServiceModel.Channels;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardInquiryResponseV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseV03Body : IResponse //ISoapResponseBody<CardInquiryResponseV03>
    {
        public CardInquiryResponseV03Body() : this(new CardInquiryResponseV03()) { }
        public CardInquiryResponseV03Body(CardInquiryResponseV03 response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardInquiryReturnV03", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV03 Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardInquiryResponseV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseV03Body
    {
        public CardInquiryResponseV03Body() : this(new CardInquiryResponseV03()) { }

        public CardInquiryResponseV03Body(CardInquiryResponseV03 response)
        {
            this.Response = response;
        }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardInquiryReturnV03", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV03 Response { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardInquiryResponseV03  // : ISoapResponse
    {
        /// <remarks/>
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
        public AtmAccessType? AtmAccess { get; set; }

        /// <summary>
        /// Yes or No
        /// </summary>
        [XmlIgnore]
        public bool HasAtmAccess => AtmAccess == AtmAccessType.CashOnCard || AtmAccess == AtmAccessType.ExpressCash;

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
        public Nullable<CardStatusType> CardStatus { get; set; }  //string?

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
        /// 999.99
        /// </summary>
        [XmlElement(ElementName = "oilDollarLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? OilDollarLimit { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "oilDollarsUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? OilDollarsUsed { get; set; }

        /// <summary>
        /// 999
        /// </summary>
        [XmlElement(ElementName = "oilQuartLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? OilQuartLimit { get; set; }

        /// <summary>
        /// 9999
        /// </summary>
        [XmlElement(ElementName = "oilQuartsUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? OilQuartsUsed { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Oil else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "oilRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? OilRenewDayOfWeek { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "oneTimeCashLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? OneTimeCashLimit { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "oneTimePurchaseLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? OneTimePurchaseLimit { get; set; }

        /// <summary>
        /// Primary Card Nbr if flagged for Primary/Secondary Card else empty tag
        /// </summary>
        [XmlElement(ElementName = "primaryCardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? PrimaryCardNumber { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "purchaseLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public string? PurchaseLimit { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Fuel else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001 
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "purchaseRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? PurchaseRenewDayOfWeek { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "purchaseUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public string? PurchaseUsed { get; set; }

        /// <summary>
        /// 99999
        /// </summary>
        [XmlElement(ElementName = "reeferGallonLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? ReeferGallonLimit { get; set; }

        /// <summary>
        /// 0=Inquiry Successful 
        /// Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public int? ResponseCode { get; set; }  //public string ResponseCode { get; set; }

        /// <summary>
        /// Response Description
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public long? TrackingNumber { get; set; }  //public string? TrackingNumber { get; set; }

        /// <summary>
        /// Trailer number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "trailerNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? TrailerNumber { get; set; }

        /// <summary>
        /// Trip number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "cashRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public bool? CashRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "cashRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public bool? CashRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "companyStandards", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public bool? CompanyStandards { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "expressCash", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public bool? ExpressCash { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "fuelPurchase", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public bool? FuelPurchase { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "limitedNetworkByCard", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public bool? LimitedNetworkByCard { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "oilRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public bool? OilRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "oilRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public bool? OilRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "oneTimeFuelOffNetwork", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public bool? OneTimeFuelOffNetwork { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "purchaseRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public bool? PurchaseRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "purchaseRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public bool? PurchaseRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "vruAccess", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public bool? VruAccess { get; set; }  //string?

        /// <remarks/>
        [XmlElement(ElementName = "expCardEmployeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public string? ExpCardEmployeeNumber { get; set; }

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "ignore1HourCheck", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public bool? Ignore1HourCheck { get; set; }  //string?

        /// <remarks/>
        [XmlElement(ElementName = "otherQuantityLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public string? OtherQuantityLimit { get; set; }

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "oneTwoRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public bool? OneTwoRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Fuel else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001 
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "oneTwoRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public string? OneTwoRenewDayOfWeek { get; set; }

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "oneTwoRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public bool? OneTwoRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "reeferRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public bool? ReeferRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Fuel else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001 
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "reeferRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public string? ReeferRenewDayOfWeek { get; set; }

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "reeferRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public bool? ReeferRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "otherRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public bool? OtherRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)
        /// contingent upon card being flagged for Fuel else empty tag
        /// </summary>
        /// <example>
        /// For example: 1001001 
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "otherRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public string? OtherRenewDayOfWeek { get; set; }

        /// <summary>
        /// 0=No 1=Yes
        /// </summary>
        [XmlElement(ElementName = "otherRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public bool? OtherRenewResetByTrip { get; set; }  //string?

        // <summary>
        /// Trip number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public string? TripNumber2 { get; set; }

        // <summary>
        /// Trip number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? TripNumber3 { get; set; }

        /// <summary>
        /// Unit number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? UnitNumber { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "cardHoldAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? CardHoldAmount { get; set; }

        /// <summary>
        /// Token number is an alternative number that can be used for referencing the card.Typically used by customers to
        /// avoid storage of card numbers to mitigate security concerns.
        /// </summary>
        [XmlElement(ElementName = "tokenNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public string? TokenNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderAddress1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public string? CardHolderAddress1 { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderAddress2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public string? CardHolderAddress2 { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public string? CardHolderCity { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? CardHolderState { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderZip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? CardHolderZip { get; set; }

        /// <summary>
        /// B=Business, I = Individual
        /// </summary>
        [XmlElement(ElementName = "cardHolderType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 67)]
        public CardHolderType? CardHolderType { get; set; }  //string?

        /// <remarks/>
        [XmlElement(ElementName = "businessName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 68)]
        public string? BusinessName { get; set; }

        /// <summary>
        /// MMDDYYYY (YYYY will be masked with *)
        /// </summary>
        [XmlElement(ElementName = "cardHolderDOB", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 69)]
        public string? CardHolderDOB { get; set; }

        /// <summary>
        /// S=Social Security Number E = Employer ID
        /// </summary>
        [XmlElement(ElementName = "taxIdType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 70)]
        public TaxIdType? TaxIdType { get; set; }  //string?

        /// <summary>
        /// 999999999 (first 5 digits will be masked with *)
        /// </summary>
        [XmlElement(ElementName = "taxId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 71)]
        public string? TaxId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderEmail", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 72)]
        public string? CardHolderEmail { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderPhone", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 73)]
        public string? CardHolderPhone { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderWorkLocState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 74)]
        public string? CardHolderWorkLocState { get; set; }

        /// <summary>
        /// P=Payroll S = Settlement
        /// </summary>
        [XmlElement(ElementName = "cardHolderUseType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 75)]
        public CardHolderUseType? CardHolderUseType { get; set; }  //string?

        /// <summary>
        /// Y=send alert via email
        /// </summary>
        [XmlElement(ElementName = "cardHolderEmailAlertSignUp", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 76)]
        public string? CardHolderEmailAlertSignUp { get; set; }

        /// <summary>
        /// Y=send alert via phone number
        /// </summary>
        [XmlElement(ElementName = "cardHolderTextAlertSignUp", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 77)]
        public string? CardHolderTextAlertSignUp { get; set; }

        /// <summary>
        /// Y=CIP has passed, N=CIP has not been requested, P=CIP is pending approval, F = CIP has failed
        /// </summary>
        [XmlElement(ElementName = "cipFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 78)]
        public CipFlag? CipFlag { get; set; }  //string?

        /// <summary>
        /// If CIP has passed, this will be a date (MMDDYYYY)
        /// </summary>
        [XmlElement(ElementName = "cipDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 79)]
        public string? CipDate { get; set; }

        /// <summary>
        /// Y=This is an OnRoad card
        /// </summary>
        [XmlElement(ElementName = "onRoadCardIndicator", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 80)]
        public string? OnRoadCardIndicator { get; set; }
    }
}
