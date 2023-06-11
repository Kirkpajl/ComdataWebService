using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using Comdata.RealTimeOnline0103.Enumerations;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardUpdateV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateRequestV02Body : IRequest  //ISoapRequestBody<CardUpdateRequestV02>
    {
        public CardUpdateRequestV02Body() : this(new CardUpdateRequestV02()) { }
        public CardUpdateRequestV02Body(CardUpdateRequestV02 request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "updateRequestV02", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardUpdateRequestV02 Request { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardUpdateV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateRequestV02Body
    {
        public CardUpdateRequestBodyV02() : this(new CardUpdateRequestV02()) { }

        public CardUpdateRequestBodyV02(CardUpdateRequestV02 request)
        {
            this.Request = request;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "updateRequestV02", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElementAttribute(ElementName = "updateRequestV02", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public CardUpdateRequestV02 Request { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardUpdateRequestV02// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// This is the card that needs to be inquired upon.  Include full 10-digit card number.
        /// The 6 digit BIN '560017' is not required on proprietary cards.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// 7 byte representation of 7-day week (Mon-Sun)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// Blank = No Update; Space = Update to space out
        /// </example>
        [XmlElement(ElementName = "cashRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public DayOfWeekType? CashRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit CustomerId's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Driver's License Number of Cardholder
        /// </summary>
        [XmlElement(ElementName = "driverLicenseNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? DriverLicenseNumber { get; set; }

        /// <summary>
        /// Driver's License State of Cardholder
        /// </summary>
        [XmlElement(ElementName = "driverLicenseState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? DriverLicenseState { get; set; }

        /// <summary>
        /// Cardholder Employee Number
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Cardholder First Name
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Cardholder Last Name
        /// </summary>
        /// <remarks>
        /// Must be at least 3 successive alpha characters; no spaces, special characters, or numbers.
        /// </remarks>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? LastName { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "oilRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public DayOfWeekType? OilRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "oneTwoRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public DayOfWeekType? OneTwoRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "reeferRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public DayOfWeekType? ReeferRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "otherRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public DayOfWeekType? OtherRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// Must be a secure card for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? Password { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "phoneRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public DayOfWeekType? PhoneRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// Primary Card Nbr if flagged for Primary/Secondary Card
        /// </summary>
        [XmlElement(ElementName = "primaryCardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? PrimaryCardNumber { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "purchaseRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? PurchaseRenewDayOfWeek { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Trailer Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "trailerNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? TrailerNumber { get; set; }

        /// <summary>
        /// Trip Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Unit Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? UnitNumber { get; set; }

        /// <summary>
        /// E = Express Cash, C = Cash on Card, B = Both, N = No
        /// </summary>
        [XmlElement(ElementName = "atmAccess", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public AtmAccessType? AtmAccess { get; set; }  //string?

        /// <summary>
        /// A = Active, B = Block, C = Clear, D = Delete, L = Lost
        /// </summary>
        [XmlElement(ElementName = "cardStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public CardStatusType? CardStatus { get; set; }  //string?

        /// <summary>
        /// 1=Voice; 2=Email; 3=Both; Blank or 0=No
        /// </summary>
        [XmlElement(ElementName = "voiceMailEmail", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public CardUpdateVoicemailEmail? VoiceMailEmail { get; set; }  //string?

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "cashLimit", Form = XmlSchemaForm.Unqualified, Order = 26)]
        public double CashLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "oneTimeCashLimit", Form = XmlSchemaForm.Unqualified, Order = 27)]
        public double OneTimeCashLimit { get; set; }

        /// <summary>
        /// 999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "oilDollarLimit", Form = XmlSchemaForm.Unqualified, Order = 28)]
        public double OilDollarLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "phoneLimit", Form = XmlSchemaForm.Unqualified, Order = 29)]
        public double PhoneLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "purchaseLimit", Form = XmlSchemaForm.Unqualified, Order = 30)]
        public double PurchaseLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "oneTimePurchaseLimit", Form = XmlSchemaForm.Unqualified, Order = 31)]
        public double OneTimePurchaseLimit { get; set; }

        /// <summary>
        /// Any Number
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 32)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "dieselGallonLimit", Form = XmlSchemaForm.Unqualified, Order = 33)]
        public int DieselGallonLimit { get; set; }

        /// <summary>
        /// 999 0=No Change
        /// </summary>
        [XmlElement(ElementName = "oilQuartLimit", Form = XmlSchemaForm.Unqualified, Order = 34)]
        public int OilQuartLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "reeferGallonLimit", Form = XmlSchemaForm.Unqualified, Order = 35)]
        public int ReeferGallonLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "reeferQuantityLimit", Form = XmlSchemaForm.Unqualified, Order = 36)]
        public int ReeferQuantityLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "oneTwoQuantityLimit", Form = XmlSchemaForm.Unqualified, Order = 37)]
        public int OneTwoQuantityLimit { get; set; }

        /// <summary>
        /// 99999.99 0=No Change
        /// </summary>
        [XmlElement(ElementName = "otherQuantityLimit", Form = XmlSchemaForm.Unqualified, Order = 38)]
        public int OtherQuantityLimit { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "cashRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public Nullable<bool> CashRenewDailyReset { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "cashRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public Nullable<bool> CashRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "companyStandards", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public Nullable<bool> CompanyStandards { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "conferenceCall", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public Nullable<bool> ConferenceCall { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "expressCash", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public Nullable<bool> ExpressCash { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "faxMail", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public Nullable<bool> FaxMail { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "fuelPurchase", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public Nullable<bool> FuelPurchase { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "informationService", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public Nullable<bool> InformationService { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "limitedNetworkByCard", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public Nullable<bool> LimitedNetworkByCard { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "messageService", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public Nullable<bool> MessageService { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "oilRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public Nullable<bool> OilRenewDailyReset { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "oilRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public Nullable<bool> OilRenewResetByTrip { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "OneTwoRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public Nullable<bool> OneTwoRenewDailyReset { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "oneTwoRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public Nullable<bool> OneTwoRenewResetByTrip { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "reeferRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public Nullable<bool> ReeferRenewDailyReset { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "reeferRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public Nullable<bool> ReeferRenewResetByTrip { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "otherRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public Nullable<bool> OtherRenewDailyReset { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "otherRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public Nullable<bool> OtherRenewResetByTrip { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "oneTimeFuelOffNetwork", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public Nullable<bool> OneTimeFuelOffNetwork { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "phoneRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public Nullable<bool> PhoneRenewDailyReset { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "phoneRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public Nullable<bool> PhoneRenewResetByTrip { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "phoneService", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public Nullable<bool> PhoneService { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "purchaseRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public Nullable<bool> PurchaseRenewDailyReset { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "purchaseRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public Nullable<bool> PurchaseRenewResetByTrip { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "vruAccess", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public Nullable<bool> VruAccess { get; set; }

        /// <summary>
        /// FALSE and 0 = No TRUE and 1 = Yes
        /// </summary>
        [XmlElement(ElementName = "ignore1HourCheck", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public Nullable<bool> Ignore1HourCheck { get; set; }

        /// <summary>
        /// Trip Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? TripNumber2 { get; set; }

        /// <summary>
        /// Trip Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? TripNumber3 { get; set; }
    }
}
