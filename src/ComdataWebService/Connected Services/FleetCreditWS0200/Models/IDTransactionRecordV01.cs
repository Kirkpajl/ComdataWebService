using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Net.NetworkInformation;
using System.Text;
using System.Transactions;
using TransactionStatus = Comdata.FleetCreditWS0200.Enumerations.TransactionStatus;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [XmlInclude(typeof(IDTransactionRecordV02))]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class IDTransactionRecordV01
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID under which the card was assigned
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Name associated with the account
        /// </summary>
        [XmlElement(ElementName = "customerName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Alphanumeric. This field will be blank unless the account falls under a corporate ID.
        /// </summary>
        [XmlElement(ElementName = "corporateCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CorporateCode { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// If the transaction has posted, this information matches the Posted Date field
        /// </summary>
        [XmlElement(ElementName = "transactionDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? TransactionDate { get; set; }

        /// <summary>
        /// HH:MM:SS
        /// H = hour between 1 and 23; m = minutes; s = seconds
        /// </summary>
        [XmlElement(ElementName = "transactionTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? TransactionTime { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// </summary>
        /// <remarks>*Note: Posting only field.</remarks>
        [XmlElement(ElementName = "postedDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? PostedDate { get; set; }

        /// <summary>
        /// HH:MM:SS
        /// H = hour between 1 and 23; m = minutes; s = seconds
        /// </summary>
        /// <remarks>*Note: Posting only field.</remarks>
        [XmlElement(ElementName = "postedTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? PostedTime { get; set; }

        /// <summary>
        /// Authorized, Posted, Declined, Credit
        /// </summary>
        [XmlElement(ElementName = "transactionType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public Nullable<TransactionStatus> TransactionType { get; set; }

        /// <summary>
        /// 16-digit card number (number masked if maskCardFlag flagged "Y" in the request; for example, "999999XXXXXX9999")
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Name associated with the card; first name followed by last name
        /// </summary>
        [XmlElement(ElementName = "cardholderName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? CardholderName { get; set; }

        /// <summary>
        /// 4-digit card expiration date in MMYY format
        /// </summary>
        [XmlElement(ElementName = "cardExpireDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? CardExpireDate { get; set; }

        /// <summary>
        /// Numeric (0-9). Code for a declined transaction.
        /// </summary>
        [XmlElement(ElementName = "declineCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? DeclineCode { get; set; }

        /// <summary>
        /// Message explaining the decline code, if applicable
        /// </summary>
        [XmlElement(ElementName = "declineMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? DeclineMessage { get; set; }

        /// <summary>
        /// Message describing the suggested action in response to the decline code
        /// </summary>
        [XmlElement(ElementName = "correctiveAction", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? CorrectiveAction { get; set; }

        /// <summary>
        /// <= 16-digit ID number that can authorize a transaction or show what is entered at the POS(like a PIN)
        /// </summary>
        [XmlElement(ElementName = "promptedId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? PromptedId { get; set; }

        /// <summary>
        /// Merchant Category Code group
        /// </summary>
        [XmlElement(ElementName = "mccGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? MccGroup { get; set; }

        /// <summary>
        /// 4-digit Merchant Category Code for the merchant receiving the payment
        /// </summary>
        [XmlElement(ElementName = "mccNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? MccNumber { get; set; }

        /// <summary>
        /// Message identifying the MCC
        /// </summary>
        [XmlElement(ElementName = "mccDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? MccDescription { get; set; }

        /// <summary>
        /// The merchant receiving the card payment
        /// </summary>
        [XmlElement(ElementName = "merchantName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? MerchantName { get; set; }

        /// <summary>
        /// Physical street address for the merchant
        /// </summary>
        [XmlElement(ElementName = "merchantAddress", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? MerchantAddress { get; set; }

        /// <summary>
        /// City for the merchant
        /// </summary>
        [XmlElement(ElementName = "merchantCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? MerchantCity { get; set; }

        /// <summary>
        /// State/province for the merchant
        /// </summary>
        [XmlElement(ElementName = "merchantState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? MerchantState { get; set; }

        /// <summary>
        /// Postal code for the merchant
        /// </summary>
        [XmlElement(ElementName = "merchantZip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? MerchantZip { get; set; }

        /// <summary>
        /// Merchant information from their POS device
        /// </summary>
        [XmlElement(ElementName = "acceptLocation", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public string? AcceptLocation { get; set; }

        /// <summary>
        /// If the authorized amount is a credit, the value will be preceded by a minus sign(for example, -26.31)
        /// </summary>
        [XmlElement(ElementName = "preAuthAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public Nullable<double> PreAuthAmount { get; set; }

        /// <summary>
        /// The amount in US dollars and cents posted in the transaction (for example, 26.31)
        /// </summary>
        /// <remarks>*Note: Posting only field.</remarks>
        [XmlElement(ElementName = "postedAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public Nullable<double> PostedAmount { get; set; }

        /// <summary>
        /// Authorization number given for the transaction
        /// </summary>
        [XmlElement(ElementName = "approvalCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? ApprovalCode { get; set; }

        /// <summary>
        /// Y (Yes) or N (No) Indicates if the transaction is an authorization reversal.
        /// </summary>
        [XmlElement(ElementName = "reversalFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public string? ReversalFlag { get; set; }

        /// <summary>
        /// Alphanumeric
        /// </summary>
        [XmlElement(ElementName = "cardToken", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? CardToken { get; set; }

        /// <summary>
        /// Surcharge amount
        /// </summary>
        [XmlElement(ElementName = "surcharge", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public Nullable<double> Surcharge { get; set; }

        /// <summary>
        /// The point of sale entry mode description:
        /// * UNKNOWN
        /// * KEYED TRANSACTION
        /// * SWIPED TRX.ON OUTDATED POS
        /// * SWIPED TRX.VIA OCR
        /// * SWIPED TRX.VIA CHIP
        /// * MANUAL ENTRY OF CHIP CARD
        /// * CHIP CRD DEFAULT TO MAG STRIPE
        /// * ECOMMERCE
        /// * SWIPED TRANSACTION
        /// * COMDATA MANUAL AUTHORIZATION
        /// </summary>
        [XmlElement(ElementName = "posEModeDesc", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? PosEModeDesc { get; set; }

        /// <summary>
        /// Transaction ID match to cross reference authorization records, posted records and reconciliation records(AC files)
        /// </summary>
        [XmlElement(ElementName = "idMatchNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? IdMatchNumber { get; set; }

        /// <summary>
        /// Employee number assigned to card
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// VIN #
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "VINNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public string? VINNumber { get; set; }

        /// <summary>
        /// POS First Name
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "POSFirstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? POSFirstName { get; set; }

        /// <summary>
        /// POS Last Name
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "POSLastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public string? POSLastName { get; set; }

        /// <summary>
        /// Vendor Address 2
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "merchantAddress2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? MerchantAddress2 { get; set; }

        /// <summary>
        /// Misc 1
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "misc1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public string? Misc1 { get; set; }

        /// <summary>
        /// Misc 2
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "misc2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public string? Misc2 { get; set; }

        /// <summary>
        /// Transaction Fees
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "transactionFees", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public Nullable<double> TransactionFees { get; set; }

        /// <summary>
        /// Vehicle Number
        /// </summary>
        /// <remarks>*Note: Future field. Not fully available yet.</remarks>
        [XmlElement(ElementName = "vehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public string? VehicleNumber { get; set; }

        /// <remarks/>
        [XmlArray(ElementName = "ProductDetailsRecord", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public ProductDetailsRecord[]? ProductDetailsRecord { get; set; }
    }
}
