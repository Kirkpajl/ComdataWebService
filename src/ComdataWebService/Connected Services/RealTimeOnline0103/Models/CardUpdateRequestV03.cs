using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System.Security.Cryptography;
using Comdata.RealTimeOnline0103.Enumerations;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardUpdateV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateRequestV03Body : IRequest  //ISoapRequestBody<CardUpdateRequestV03>
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardUpdateV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateRequestV03Body : ISoapRequestBody<CardUpdateRequestV03>
>>>>>>> releases/v1.0.0
    {
        public CardUpdateRequestV03Body() : this(new CardUpdateRequestV03()) { }
        public CardUpdateRequestV03Body(CardUpdateRequestV03 request) { Request = request; }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "updateRequestV03", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardUpdateRequestV03 Request { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardUpdateV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "updateRequestV03", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardUpdateRequestV03 Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardUpdateV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
>>>>>>> releases/v1.0.0
    public partial class CardUpdateRequestV03Body
    {
        public CardUpdateRequestV03Body() : this(new CardUpdateRequestV03()) { }

        public CardUpdateRequestV03Body(CardUpdateRequestV03 request)
        {
            this.Request = request;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "updateRequestV03", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "updateRequestV03", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public CardUpdateRequestV03 Request { get; set; }
    }*/



    /// <remarks/>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardUpdateRequestV03// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "cardIdentifierType", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public CardIdentifierType? CardIdentifierType { get; set; }  //string?

        /// <summary>
        /// This is the card that needs to be inquired upon.  Include full 10-digit card number.
        /// The 6 digit BIN '560017' is not required on proprietary cards.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// 7 byte representation of 7-day week (Mon-Sun)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// Blank = No Update; Space = Update to space out
        /// </example>
        [XmlElement(ElementName = "cashRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public DayOfWeekType? CashRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit CustomerId's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Driver's License Number of Cardholder
        /// </summary>
        [XmlElement(ElementName = "driverLicenseNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? DriverLicenseNumber { get; set; }

        /// <summary>
        /// Driver's License State of Cardholder
        /// </summary>
        [XmlElement(ElementName = "driverLicenseState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? DriverLicenseState { get; set; }

        /// <summary>
        /// Cardholder Employee Number
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Cardholder First Name
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Cardholder Last Name
        /// </summary>
        /// <remarks>
        /// Must be at least 3 successive alpha characters; no spaces, special characters, or numbers.
        /// </remarks>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? LastName { get; set; }

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "oilRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public DayOfWeekType? OilRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "oneTwoRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public DayOfWeekType? OneTwoRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "reeferRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public DayOfWeekType? ReeferRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// 7-byte representation of 7-day week (Sun-Sat)        
        /// </summary>
        /// <example>
        /// For example: 1001001
        /// 0=No 1=Yes
        /// </example>
        [XmlElement(ElementName = "otherRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public DayOfWeekType? OtherRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// Must be a secure card for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, Order = 15)]
        public string? Password { get; set; }

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
        public DayOfWeekType? PurchaseRenewDayOfWeek { get; set; }  //string?

        /// <summary>
        /// Full 16-digit security card number. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, Order = 18)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, Order = 19)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Trailer Number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "trailerNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? TrailerNumber { get; set; }

        /// <summary>
        /// Trip Number assigned to card.
        /// </summary>
        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
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
        /// 99999.99        
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "cashLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public double? CashLimit { get; set; }  //string?

        /// <summary>
        /// 99999.99        
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "oneTimeCashLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public double? OneTimeCashLimit { get; set; }  //string?

        /// <summary>
        /// 999.99
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "oilDollarLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public double? OilDollarLimit { get; set; }  //string?

        /// <summary>
        /// 99999.99        
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "purchaseLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public double? PurchaseLimit { get; set; }  //string?

        /// <summary>
        /// 99999.99        
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "oneTimePurchaseLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public double? OneTimePurchaseLimit { get; set; }  //string?

        /// <summary>
        /// Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public long? TrackingNumber { get; set; }  //public string? TrackingNumber { get; set; }

        /// <summary>
        /// 999        
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "oilQuartLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public int? OilQuartLimit { get; set; }  //string?

        /// <summary>
        /// 99999
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "reeferQuantityLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public int? ReeferQuantityLimit { get; set; }  //string?

        /// <summary>
        /// 99999
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "oneTwoQuantityLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public int? OneTwoQuantityLimit { get; set; }  //string?

        /// <summary>
        /// 99999
        /// </summary>
        /// <remarks>
        /// Blank=No Update; 0 = Update to 0.0
        /// </remarks>
        [XmlElement(ElementName = "otherQuantityLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public int? OtherQuantityLimit { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "cashRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public bool? CashRenewDailyReset { get; set; } //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "cashRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public bool? CashRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "companyStandards", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public bool? CompanyStandards { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "expressCash", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public bool? ExpressCash { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "fuelPurchase", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public bool? FuelPurchase { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "limitedNetworkByCard", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public bool? LimitedNetworkByCard { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "oilRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public bool? OilRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "oilRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public bool? OilRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "oneTwoRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public bool? OneTwoRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "oneTwoRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public bool? OneTwoRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "reeferRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public bool? ReeferRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "reeferRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public bool? ReeferRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "otherRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public bool? OtherRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "otherRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public bool? OtherRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "oneTimeFuelOffNetwork", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public bool? OneTimeFuelOffNetwork { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "purchaseRenewDailyReset", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public bool? PurchaseRenewDailyReset { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "purchaseRenewResetByTrip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public bool? PurchaseRenewResetByTrip { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "vruAccess", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public bool? VruAccess { get; set; }  //string?

        /// <summary>
        /// FALSE and 0 = No; TRUE and 1 = Yes; Blank = No Update
        /// </summary>
        [XmlElement(ElementName = "ignore1HourCheck", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public bool? Ignore1HourCheck { get; set; }  //string?

        /// <summary>
        /// Trip Number assigned to card.
        /// </summary>
        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
        [XmlElement(ElementName = "tripNumber2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public string? TripNumber2 { get; set; }

        /// <summary>
        /// Trip Number assigned to card.
        /// </summary>
        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
        [XmlElement(ElementName = "tripNumber3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public string? TripNumber3 { get; set; }

        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
        [XmlElement(ElementName = "cardHolderAddress1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public string? CardHolderAddress1 { get; set; }

        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
        [XmlElement(ElementName = "cardHolderAddress2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public string? CardHolderAddress2 { get; set; }

        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
        [XmlElement(ElementName = "cardHolderCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? CardHolderCity { get; set; }

        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
        [XmlElement(ElementName = "cardHolderState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? CardHolderState { get; set; }

        /// <remarks>
        /// Blank=No Update Space=Update to space out
        /// </remarks>
        [XmlElement(ElementName = "cardHolderZip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? CardHolderZip { get; set; }

        /// <summary>
        /// B=Business; I=Individual
        /// </summary>
        /// <remarks>
        /// Can not change after CIP check
        /// </remarks>
        [XmlElement(ElementName = "cardHolderType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public CardHolderType? CardHolderType { get; set; }  //string?

        /// <remarks>Blank=No Update</remarks>
        [XmlElement(ElementName = "businessName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public string? BusinessName { get; set; }

        /// <summary>mmddyyyy</summary>
        /// <remarks>Blank=No Update</remarks>
        [XmlElement(ElementName = "cardHolderDOB", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public string? CardHolderDOB { get; set; }

        /// <summary>
        /// S=Social Security Number; E=Employer Identification Number
        /// </summary>
        /// <remarks>
        /// Cannot change after CIP check
        /// </remarks>
        [XmlElement(ElementName = "taxIdType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public TaxIdType? TaxIdType { get; set; }  //string?

        /// <remarks>Blank=No Update</remarks>
        [XmlElement(ElementName = "taxId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? TaxId { get; set; }

        /// <remarks>Blank=No Update</remarks>
        [XmlElement(ElementName = "cardHolderEmail", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? CardHolderEmail { get; set; }

        /// <remarks>Blank=No Update; Space=Update to space out</remarks>
        [XmlElement(ElementName = "cardHolderPhone", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 67)]
        public string? CardHolderPhone { get; set; }

        /// <remarks>Blank=No Update</remarks>
        [XmlElement(ElementName = "cardHolderWorkLocState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 68)]
        public string? CardHolderWorkLocState { get; set; }

        /// <summary>
        /// P = Payroll, S = Settlement
        /// </summary>
        [XmlElement(ElementName = "cardHolderUseType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 69)]
        public CardHolderUseType? CardHolderUseType { get; set; }  // string?

        /// <summary>Y/N - Y requires email address</summary>
        /// <remarks>Blank=No Update</remarks>
        [XmlElement(ElementName = "cardHolderEmailAlertSignUp", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 70)]
        public bool? CardHolderEmailAlertSignUp { get; set; }  //string?

        /// <summary>Y/N - Y requires phone number</summary>
        /// <remarks>Blank=No Update</remarks>
        [XmlElement(ElementName = "cardHolderTextAlertSignUp", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 71)]
        public bool? CardHolderTextAlertSignUp { get; set; }  //string?
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardUpdateRequestV03 : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardIdentifierType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string? CardIdentifierType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CashRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? DriverLicenseNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? DriverLicenseState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? EmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? FirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? LastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? OilRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? OneTwoRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? ReeferRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? OtherRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "primaryCardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? PrimaryCardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDayOfWeek", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? PurchaseRenewDayOfWeek { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? CashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeCashLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public string? OneTimeCashLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilDollarLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? OilDollarLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public string? PurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimePurchaseLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? OneTimePurchaseLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public long? TrackingNumber { get; set; }  //public string? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilQuartLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? OilQuartLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? ReeferQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? OneTwoQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public string? OtherQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? CashRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public string? CashRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "companyStandards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? CompanyStandards { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCash", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public string? ExpressCash { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fuelPurchase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public string? FuelPurchase { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedNetworkByCard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public string? LimitedNetworkByCard { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public string? OilRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public string? OilRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public string? OneTwoRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTwoRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public string? OneTwoRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public string? ReeferRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? ReeferRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public string? OtherRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public string? OtherRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oneTimeFuelOffNetwork", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public string? OneTimeFuelOffNetwork { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewDailyReset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public string? PurchaseRenewDailyReset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseRenewResetByTrip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public string? PurchaseRenewResetByTrip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vruAccess", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public string? VruAccess { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ignore1HourCheck", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public string? Ignore1HourCheck { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public string? TripNumber2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public string? TripNumber3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderAddress1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public string? CardHolderAddress1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderAddress2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public string? CardHolderAddress2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderCity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? CardHolderCity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? CardHolderState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderZip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? CardHolderZip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public string? CardHolderType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "businessName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public string? BusinessName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderDOB", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public string? CardHolderDOB { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "taxIdType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public string? TaxIdType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "taxId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? TaxId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderEmail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? CardHolderEmail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderPhone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 67)]
        public string? CardHolderPhone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderWorkLocState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 68)]
        public string? CardHolderWorkLocState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderUseType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 69)]
        public string? CardHolderUseType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderEmailAlertSignUp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 70)]
        public string? CardHolderEmailAlertSignUp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardHolderTextAlertSignUp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 71)]
        public string? CardHolderTextAlertSignUp { get; set; }
>>>>>>> releases/v1.0.0
    }
}
