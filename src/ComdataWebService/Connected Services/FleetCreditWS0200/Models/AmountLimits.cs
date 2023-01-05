using System;
<<<<<<< HEAD
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
=======
using System.Collections.Generic;
using System.Text;
>>>>>>> releases/v1.0.0

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
<<<<<<< HEAD
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
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class AmountLimits
    {

        private System.Nullable<decimal> dailyAmountLimitField;

        private System.Nullable<decimal> dailyAmountLimitUsedField;

        private System.Nullable<decimal> dailyAmountLimitHoldField;

        private System.Nullable<decimal> dailyAmountLimitAvailableField;

        private System.Nullable<int> dailyTxnLimitField;

        private System.Nullable<int> dailyTxnLimitUsedField;

        private System.Nullable<int> dailyTxnLimitHoldField;

        private System.Nullable<int> dailyTxnLimitAvailableField;

        private System.Nullable<decimal> cycleAmountLimitField;

        private System.Nullable<decimal> cycleAmountLimitUsedField;

        private System.Nullable<decimal> cycleAmountLimitHoldField;

        private System.Nullable<decimal> cycleAmountLimitAvailableField;

        private System.Nullable<int> cycleTxnLimitField;

        private System.Nullable<int> cycleTxnLimitUsedField;

        private System.Nullable<int> cycleTxnLimitHoldField;

        private System.Nullable<int> cycleTxnLimitAvailableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public System.Nullable<decimal> dailyAmountLimit
        {
            get
            {
                return this.dailyAmountLimitField;
            }
            set
            {
                this.dailyAmountLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public System.Nullable<decimal> dailyAmountLimitUsed
        {
            get
            {
                return this.dailyAmountLimitUsedField;
            }
            set
            {
                this.dailyAmountLimitUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public System.Nullable<decimal> dailyAmountLimitHold
        {
            get
            {
                return this.dailyAmountLimitHoldField;
            }
            set
            {
                this.dailyAmountLimitHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public System.Nullable<decimal> dailyAmountLimitAvailable
        {
            get
            {
                return this.dailyAmountLimitAvailableField;
            }
            set
            {
                this.dailyAmountLimitAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public System.Nullable<int> dailyTxnLimit
        {
            get
            {
                return this.dailyTxnLimitField;
            }
            set
            {
                this.dailyTxnLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public System.Nullable<int> dailyTxnLimitUsed
        {
            get
            {
                return this.dailyTxnLimitUsedField;
            }
            set
            {
                this.dailyTxnLimitUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public System.Nullable<int> dailyTxnLimitHold
        {
            get
            {
                return this.dailyTxnLimitHoldField;
            }
            set
            {
                this.dailyTxnLimitHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public System.Nullable<int> dailyTxnLimitAvailable
        {
            get
            {
                return this.dailyTxnLimitAvailableField;
            }
            set
            {
                this.dailyTxnLimitAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public System.Nullable<decimal> cycleAmountLimit
        {
            get
            {
                return this.cycleAmountLimitField;
            }
            set
            {
                this.cycleAmountLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public System.Nullable<decimal> cycleAmountLimitUsed
        {
            get
            {
                return this.cycleAmountLimitUsedField;
            }
            set
            {
                this.cycleAmountLimitUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public System.Nullable<decimal> cycleAmountLimitHold
        {
            get
            {
                return this.cycleAmountLimitHoldField;
            }
            set
            {
                this.cycleAmountLimitHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public System.Nullable<decimal> cycleAmountLimitAvailable
        {
            get
            {
                return this.cycleAmountLimitAvailableField;
            }
            set
            {
                this.cycleAmountLimitAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public System.Nullable<int> cycleTxnLimit
        {
            get
            {
                return this.cycleTxnLimitField;
            }
            set
            {
                this.cycleTxnLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public System.Nullable<int> cycleTxnLimitUsed
        {
            get
            {
                return this.cycleTxnLimitUsedField;
            }
            set
            {
                this.cycleTxnLimitUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public System.Nullable<int> cycleTxnLimitHold
        {
            get
            {
                return this.cycleTxnLimitHoldField;
            }
            set
            {
                this.cycleTxnLimitHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public System.Nullable<int> cycleTxnLimitAvailable
        {
            get
            {
                return this.cycleTxnLimitAvailableField;
            }
            set
            {
                this.cycleTxnLimitAvailableField = value;
            }
        }
>>>>>>> releases/v1.0.0
    }
}
