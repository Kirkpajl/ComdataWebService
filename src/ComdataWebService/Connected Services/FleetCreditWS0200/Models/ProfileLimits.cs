using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
=======
>>>>>>> releases/v1.0.0

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class ProfileLimits
    {
        /// <summary>
        /// O=open, C=close
        /// </summary>
        [XmlElement(ElementName = "openCloseFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? OpenCloseFlag { get; set; }

        /// <summary>
        /// Y = Yes, N or blank = No
        /// </summary>
        [XmlElement(ElementName = "productAvailableFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? ProductAvailableFlag { get; set; }

        /// <summary>
        /// Spending limit per transaction
        /// </summary>
        [XmlElement(ElementName = "transactionDollarLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public Nullable<decimal> TransactionDollarLimit { get; set; }

        /// <summary>
        /// Limits number of transactions
        /// </summary>
        [XmlElement(ElementName = "transactionQuantityLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public Nullable<int> TransactionQuantityLimit { get; set; }

        /// <summary>
        /// Daily card spending limit
        /// </summary>
        [XmlElement(ElementName = "dailyDollarLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public Nullable<decimal> DailyDollarLimit { get; set; }

        /// <summary>
        /// Limits daily number of transactions
        /// </summary>
        [XmlElement(ElementName = "dailyTransactionLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public Nullable<int> DailyTransactionLimit { get; set; }

        /// <summary>
        /// Limits daily amount of spending
        /// </summary>
        [XmlElement(ElementName = "dailyQuantityLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public Nullable<int> DailyQuantityLimit { get; set; }

        /// <summary>
        /// Cycle card spending limit
        /// </summary>
        [XmlElement(ElementName = "cycleDollarLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public Nullable<decimal> CycleDollarLimit { get; set; }

        /// <summary>
        /// Limits number of transactions in cycle
        /// </summary>
        [XmlElement(ElementName = "cycleTransactionLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public Nullable<int> CycleTransactionLimit { get; set; }

        /// <summary>
        /// Limits amount of spending in cycle
        /// </summary>
        [XmlElement(ElementName = "cycleQuantityLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public Nullable<int> CycleQuantityLimit { get; set; }

        /// <summary>
        /// M = Monthly W = Weekly T = Never Reset, no blanks
        /// </summary>
        [XmlElement(ElementName = "cycleType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? CycleType { get; set; }

        /// <summary>
        /// Values M=01-31, W = 01000000 (Tuesday Reset), T = None
        /// </summary>
        [XmlElement(ElementName = "cycleDay", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class ProfileLimits
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openCloseFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? OpenCloseFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productAvailableFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? ProductAvailableFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "transactionDollarLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public System.Nullable<decimal> TransactionDollarLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "transactionQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public System.Nullable<int> TransactionQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dailyDollarLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public System.Nullable<decimal> DailyDollarLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dailyTransactionLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public System.Nullable<int> DailyTransactionLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dailyQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public System.Nullable<int> DailyQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cycleDollarLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public System.Nullable<decimal> CycleDollarLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cycleTransactionLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public System.Nullable<int> CycleTransactionLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cycleQuantityLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public System.Nullable<int> CycleQuantityLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cycleType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? CycleType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cycleDay", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
>>>>>>> releases/v1.0.0
        public string? CycleDay { get; set; }
    }
}
