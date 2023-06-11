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
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardInquiryResponseV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseV02Body : IResponse  //, ISoapResponseBody<CardInquiryResponseV02>
    {
        public CardInquiryResponseV02Body() : this(new CardInquiryResponseV02()) { }
        public CardInquiryResponseV02Body(CardInquiryResponseV02 response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardInquiryReturnV02", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryResponseV02 Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardInquiryResponseV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryResponseBodyV02
    {
        public CardInquiryResponseBodyV02() : this(new CardInquiryResponseV02()) { }

        public CardInquiryResponseBodyV02(CardInquiryResponseV02 response)
        {
            this.Response = response;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardInquiryReturnV02", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElementAttribute(ElementName = "cardInquiryReturnV02", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public CardInquiryResponseV02 Response { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardInquiryResponseV02  // : ISoapResponse
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
        [XmlElement(ElementName = "oilDollarLimit", Form = XmlSchemaForm.Unqualified, Order = 16)]
        public double OilDollarLimit { get; set; }

        /// <summary>
        /// 999999.99
        /// </summary>
        [XmlElement(ElementName = "oilDollarsUsed", Form = XmlSchemaForm.Unqualified, Order = 17)]
        public double OilDollarsUsed { get; set; }

        /// <summary>
        /// 999
        /// </summary>
        [XmlElement(ElementName = "oilQuartLimit", Form = XmlSchemaForm.Unqualified, Order = 18)]
        public int OilQuartLimit { get; set; }

        /// <summary>
        /// 9999
        /// </summary>
        [XmlElement(ElementName = "oilQuartsUsed", Form = XmlSchemaForm.Unqualified, Order = 19)]
        public int OilQuartsUsed { get; set; }

        /// <summary>
        /// 7 byte representation of 7-day week (Sun-Sat)*
        /// * contingent upon card being flagged for Oil else empty tag
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
        [XmlElement(ElementName = "oneTimeCashLimit", Form = XmlSchemaForm.Unqualified, Order = 21)]
        public double OneTimeCashLimit { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "oneTimePurchaseLimit", Form = XmlSchemaForm.Unqualified, Order = 22)]
        public double OneTimePurchaseLimit { get; set; }

        /// <summary>
        /// Primary Card Number if flagged for Primary/Secondary Card else empty tag
        /// </summary>
        [XmlElement(ElementName = "primaryCardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? PrimaryCardNumber { get; set; }

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "purchaseLimit", Form = XmlSchemaForm.Unqualified, Order = 24)]
        public double PurchaseLimit { get; set; }

        /// <summary>
        /// 7 byte representation of 7-day week (Sun-Sat)*
        /// * contingent upon card being flagged for Fuel else empty tag
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
        [XmlElement(ElementName = "purchaseUsed", Form = XmlSchemaForm.Unqualified, Order = 26)]
        public double PurchaseUsed { get; set; }

        /// <summary>
        /// 99999
        /// </summary>
        [XmlElement(ElementName = "reeferGallonLimit", Form = XmlSchemaForm.Unqualified, Order = 27)]
        public int ReeferGallonLimit { get; set; }

        /// <summary>
        /// 0=Inquiry Successful; Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 28)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 30)]
        public long? TrackingNumber { get; set; }

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
        /// Unit number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? UnitNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cashRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 34)]
        public bool CashRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cashRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 35)]
        public bool CashRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "companyStandards", Form = XmlSchemaForm.Unqualified, Order = 36)]
        public bool CompanyStandards { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "expressCash", Form = XmlSchemaForm.Unqualified, Order = 37)]
        public bool ExpressCash { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "fuelPurchase", Form = XmlSchemaForm.Unqualified, Order = 38)]
        public bool FuelPurchase { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "limitedNetworkByCard", Form = XmlSchemaForm.Unqualified, Order = 39)]
        public bool LimitedNetworkByCard { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oilRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 40)]
        public bool OilRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oilRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 41)]
        public bool OilRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTimeFuelOffNetwork", Form = XmlSchemaForm.Unqualified, Order = 42)]
        public bool OneTimeFuelOffNetwork { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "purchaseRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 43)]
        public bool PurchaseRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "purchaseRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 44)]
        public bool PurchaseRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "vruAccess", Form = XmlSchemaForm.Unqualified, Order = 45)]
        public bool VruAccess { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "expCardEmployeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? ExpCardEmployeeNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "ignore1HourCheck", Form = XmlSchemaForm.Unqualified, Order = 47)]
        public bool Ignore1HourCheck { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherQuantityLimit", Form = XmlSchemaForm.Unqualified, Order = 48)]
        public int OtherQuantityLimit { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTwoRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 49)]
        public bool OneTwoRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTwoRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public string? OneTwoRenewDayOfWeek { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "oneTwoRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 51)]
        public bool OneTwoRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "reeferRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 52)]
        public bool ReeferRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "reeferRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public string? ReeferRenewDayOfWeek { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "reeferRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 54)]
        public bool ReeferRenewResetByTrip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherRenewDailyReset", Form = XmlSchemaForm.Unqualified, Order = 55)]
        public bool OtherRenewDailyReset { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherRenewDayOfWeek", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public string? OtherRenewDayOfWeek { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "otherRenewResetByTrip", Form = XmlSchemaForm.Unqualified, Order = 57)]
        public bool OtherRenewResetByTrip { get; set; }

        /// <summary>
        /// Trip number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? TripNumber2 { get; set; }

        /// <summary>
        /// Trip number assigned to card.
        /// </summary>
        [XmlElement(ElementName = "tripNumber3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? TripNumber3 { get; set; }

        /// <summary>
        /// Token number is an alternative number that can be used for referencing the card.Typically used by customers to
        /// avoid storage of card numbers to mitigate security concerns.
        /// </summary>
        [XmlElement(ElementName = "tokenNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? TokenNumber { get; set; }
    }
}
