﻿using System;
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
    public partial class AvailableCreditInquiryRecord
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// A=active
        /// B=blocked
        /// D = Deleted
        /// </summary>
        [XmlElement(ElementName = "accountStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? AccountStatus { get; set; }

        /// <summary>
        /// 999999999.99
        /// </summary>
        [XmlElement(ElementName = "creditLimit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CreditLimit { get; set; }

        /// <summary>
        /// 999999999.99
        /// </summary>
        [XmlElement(ElementName = "accountBalance", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? AccountBalance { get; set; }

        /// <summary>
        /// 999999999.99
        /// </summary>
        [XmlElement(ElementName = "lastDepositAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? LastDepositAmount { get; set; }

        /// <summary>
        /// MM/DD
        /// </summary>
        [XmlElement(ElementName = "lastDepositDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? LastDepositDate { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "preAuthAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? PreAuthAmount { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "unbilledAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? UnbilledAmount { get; set; }

        /// <summary>
        /// Response code 0 indicates a successful request; all other response codes indicates errors
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? ResponseCode { get; set; }

        /// <summary>
        /// Description of response code
        /// </summary>
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class AvailableCreditInquiryRecord
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? AccountStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "creditLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CreditLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountBalance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? AccountBalance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastDepositAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? LastDepositAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastDepositDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? LastDepositDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "preAuthAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? PreAuthAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "unbilledAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? UnbilledAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
>>>>>>> releases/v1.0.0
        public string? ResponseDescription { get; set; }
    }
}
