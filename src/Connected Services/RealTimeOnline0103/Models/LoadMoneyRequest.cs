using Comdata.Models.Internals;
using Comdata.RealTimeOnline0103.Enumerations;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "loadMoney", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyRequestBody : IRequest<LoadMoneyRequest>
    {
        public LoadMoneyRequestBody() : this(new LoadMoneyRequest()) { }
        public LoadMoneyRequestBody(LoadMoneyRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyRequest Content { get; set; }
    }



    /// <summary>
    /// Request Record Express Cash Load Money 1.0
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyRequest : IRequest
    {
        //[XmlElement(ElementName = "availableDateTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        //public Nullable<System.DateTime> AvailableDateTime { get; set; }

        //private const string _availableDateTimeFormat = "yyyy-MM-ddTHH:mm:ss";
        private const string _availableDateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ";

        /// <summary>
        /// Today's date required for today.
        /// </summary>
        [XmlIgnore]
        public DateTime? AvailableDateTime { get; set; }

        [XmlElement(ElementName = "availableDateTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AvailableDateTimeString
        {
            //get { return AvailableDateTime?.ToLocalTime().ToString(_availableDateTimeFormat); }
            get { return AvailableDateTime?.ToUniversalTime().ToString(_availableDateTimeFormat); }
            //set { AvailableDateTime = value == null ? (DateTime?)null : DateTime.ParseExact(value, _availableDateTimeFormat, CultureInfo.InvariantCulture); }
            set { AvailableDateTime = value == null ? (DateTime?)null : DateTime.Parse(value, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal); }
        }

        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Either the Card Number OR the Employee Number of the
        /// Card Number to be loaded.Card Number must be 10 digits.
        /// The 6 digit BIN '560017' is not required on proprietary cards.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned
        /// in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like attached
        /// to this load. (optional)
        /// </summary>
        [XmlElement(ElementName = "miscellaneousData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? MiscellaneousData { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value
        /// assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? Password { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by
        /// Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by
        /// Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Trip Number related to this Load Request
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// A=Add S=Subtract REMINDER: CASE SENSITIVE!
        /// DO NOT USE "1", "2", blank, or any other value
        /// </summary>
        [XmlElement(ElementName = "addSubtractFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public LoadMoneyAddSubtractFlag? AddSubtractFlag { get; set; }

        /// <summary>
        /// 1=Plus Fees (Full Load Amt applied to Card Balance)
        /// 2=Less Fees(Load Amt less Fees applied to Card Balance)
        /// DO NOT USE "P", "L", blank, or any other value.
        /// If not specified, defaults to Customer Id setup value.
        /// </summary>
        [XmlElement(ElementName = "plusLessFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public LoadMoneyRequestPlusLessFlag? PlusLessFlag { get; set; }

        /// <summary>
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 12)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Minimum .01 Maximum 99999.99
        /// </summary>
        [XmlElement(ElementName = "loadAmount", Form = XmlSchemaForm.Unqualified, Order = 13)]
        public double LoadAmount { get; set; }

        /// <summary>
        /// Represents if the funds will either load to the card or deposit cardholder's bank account.
        /// </summary>
        /// <remarks>
        /// N = No (Funds load to card)
        /// Y = Yes (Funds deposits to bank account)
        /// </remarks>
        [XmlElement(ElementName = "directDeposit", Form = XmlSchemaForm.Unqualified, Order = 14)]
        public bool DirectDeposit { get; set; }
    }
}
