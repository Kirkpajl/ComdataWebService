using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class ProfileLimits
    {
        /// <summary>
        /// O=open, C=close
        /// </summary>
        [XmlElement(ElementName = "openCloseFlag", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public OpenCloseCharFlag OpenCloseFlag { get; set; }  //string?

        /// <summary>
        /// Y = Yes, N or blank = No
        /// </summary>
        [XmlElement(ElementName = "productAvailableFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public YesNoCharFlag? ProductAvailableFlag { get; set; }  //string?

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
        [XmlElement(ElementName = "cycleType", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public CycleType CycleType { get; set; }  // string?

        /// <summary>
        /// Values M=01-31, W = 01000000 (Tuesday Reset), T = None
        /// </summary>
        [XmlElement(ElementName = "cycleDay", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? CycleDay { get; set; }
    }
}
