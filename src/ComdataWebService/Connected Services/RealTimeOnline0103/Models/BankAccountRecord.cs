using Comdata.RealTimeOnline0103.Enumerations;
using System;
<<<<<<< HEAD
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
=======
using System.Collections.Generic;
>>>>>>> releases/v1.0.0
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <remarks/>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
>>>>>>> releases/v1.0.0
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class BankAccountRecord
    {
        /// <summary>
        /// Numeric value between 1 and 5
        /// 
        /// The response record can include up to 5 direct deposit bank accounts(sequences 1 through 5 below), depending on
        /// the number of accounts set up for the employee.
        /// </summary>
        [XmlElement(ElementName = "bankAccountSequence", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? BankAccountSequence { get; set; }

        /// <summary>
        /// Bank routing and transit number
        /// </summary>
        [XmlElement(ElementName = "routingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? RoutingNumber { get; set; }

        /// <summary>
        /// Bank account number
        /// </summary>
        [XmlElement(ElementName = "bankAccountNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? BankAccountNumber { get; set; }

        /// <summary>
        /// Name on the bank account
        /// </summary>
        [XmlElement(ElementName = "accountName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? AccountName { get; set; }

        /// <summary>
        /// Y = checking account
        /// N = other/not a checking account
        /// </summary>
        [XmlElement(ElementName = "checkingAccountFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public Nullable<DirectDepositInquiryCheckingAccountFlag> CheckingAccountFlag { get; set; }  //string?

        /// <summary>
        /// P = percent of load amount is sent to ACH
        /// A = amount is sent to ACH
        /// C = amount of load kept in Express Cash; remainder is sent to ACH
        /// </summary>
        [XmlElement(ElementName = "depositType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public Nullable<DirectDepositInquiryDepositType> DepositType { get; set; }  //string?

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "amountOrPercent", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public Nullable<double> AmountOrPercent { get; set; }

        /// <summary>
        /// The status of the direct deposit account
        /// A = Activate; B = Block; P = Pending Pre-Note
        /// </summary>
        [XmlElement(ElementName = "status", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public Nullable<DirectDepositInquiryAccountStatus> Status { get; set; } //string?

        /// <summary>
        /// Date the last pre-note was done; MM/DD/YY
        /// </summary>
        [XmlElement(ElementName = "lastPreNoteDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LastPreNoteDate { get; set; }

        /// <summary>
        /// Time the last pre-note was done; HH:MM:SS
        /// </summary>
        [XmlElement(ElementName = "lastPreNoteTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? LastPreNoteTime { get; set; }

        /// <summary>
        /// Timestamp when the last pre-note was done
        /// </summary>
        [XmlIgnore]
        public DateTime? LastPreNote => !string.IsNullOrWhiteSpace(LastPreNoteDate) && !string.IsNullOrWhiteSpace(LastPreNoteTime)
            ? DateTime.Parse(LastPreNoteDate).Add(TimeSpan.Parse(LastPreNoteTime))
            : (DateTime?)null;
    }
}
