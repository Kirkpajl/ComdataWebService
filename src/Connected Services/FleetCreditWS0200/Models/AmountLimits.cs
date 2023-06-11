using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class AmountLimits
    {
        /// <summary>
        /// Daily card spending limit
        /// </summary>
        [XmlElement(ElementName = "dailyAmountLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public Nullable<decimal> DailyAmountLimit { get; set; }

        /// <summary>
        /// Amount posted to the card for the day
        /// </summary>
        [XmlElement(ElementName = "dailyAmountLimitUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public Nullable<decimal> DailyAmountLimitUsed { get; set; }

        /// <summary>
        /// Amount authorized on the card but not yet posted for the day
        /// </summary>
        [XmlElement(ElementName = "dailyAmountLimitHold", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public Nullable<decimal> DailyAmountLimitHold { get; set; }

        /// <summary>
        /// Amount of daily spend limit remaining after posted and authorized transactions
        /// </summary>
        [XmlElement(ElementName = "dailyAmountLimitAvailable", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public Nullable<decimal> DailyAmountLimitAvailable { get; set; }

        /// <summary>
        /// Daily card transaction limit
        /// </summary>
        [XmlElement(ElementName= "dailyTxnLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public Nullable<int> DailyTxnLimit { get; set; }

        /// <summary>
        /// Number of transactions posted to the card for the day
        /// </summary>
        [XmlElement(ElementName = "dailyTxnLimitUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public Nullable<int> DailyTxnLimitUsed { get; set; }

        /// <summary>
        /// Number of transactions authorized but not yet posted for the day
        /// </summary>
        [XmlElement(ElementName = "dailyTxnLimitHold", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public Nullable<int> DailyTxnLimitHold { get; set; }

        /// <summary>
        /// Number of daily transactions remaining after posted and authorized transactions
        /// </summary>
        [XmlElement(ElementName = "dailyTxnLimitAvailable", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public Nullable<int> DailyTxnLimitAvailable { get; set; }

        /// <summary>
        /// Cycle card spending limit
        /// </summary>
        [XmlElement(ElementName = "cycleAmountLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public Nullable<decimal> CycleAmountLimit { get; set; }

        /// <summary>
        /// Amount posted to the card for the cycle
        /// </summary>
        [XmlElement(ElementName = "cycleAmountLimitUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public Nullable<decimal> CycleAmountLimitUsed { get; set; }

        /// <summary>
        /// Amount authorized for the card but not yet posted for the cycle
        /// </summary>
        [XmlElement(ElementName = "cycleAmountLimitHold", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public Nullable<decimal> CycleAmountLimitHold { get; set; }

        /// <summary>
        /// Amount of cycle spending limit remaining after posted and authorized transactions
        /// </summary>
        [XmlElement(ElementName = "cycleAmountLimitAvailable", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public Nullable<decimal> CycleAmountLimitAvailable { get; set; }

        /// <summary>
        /// Cycle card transaction limit
        /// </summary>
        [XmlElement(ElementName = "cycleTxnLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public Nullable<int> CycleTxnLimit { get; set; }

        /// <summary>
        /// Number of card transactions posted for the cycle
        /// </summary>
        [XmlElement(ElementName = "cycleTxnLimitUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public Nullable<int> CycleTxnLimitUsed { get; set; }

        /// <summary>
        /// Number of transactions authorized but not yet posted for the cycle
        /// </summary>
        [XmlElement(ElementName = "cycleTxnLimitHold", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public Nullable<int> CycleTxnLimitHold { get; set; }

        /// <summary>
        /// Number of cycle transactions remaining after posted and authorized transactions
        /// </summary>
        [XmlElement(ElementName = "cycleTxnLimitAvailable", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public Nullable<int> CycleTxnLimitAvailable { get; set; }
    }
}
