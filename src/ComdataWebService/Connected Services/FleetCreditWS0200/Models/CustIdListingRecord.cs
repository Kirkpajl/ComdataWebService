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
    public partial class CustIdListingRecord
    {
        /// <remarks/>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerIdName { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerIdStatus { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdCountry", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CustomerIdCountry { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdAddress1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? CustomerIdAddress1 { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdAddress2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? CustomerIdAddress2 { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? CustomerIdCity { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustomerIdState { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdZip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? CustomerIdZip { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdCardType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? CustomerIdCardType { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdCardStyle", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? CustomerIdCardStyle { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerIdCardExpirationDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class CustIdListingRecord
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerIdName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerIdStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdCountry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CustomerIdCountry { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdAddress1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? CustomerIdAddress1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdAddress2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? CustomerIdAddress2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdCity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? CustomerIdCity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustomerIdState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdZip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? CustomerIdZip { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdCardType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? CustomerIdCardType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdCardStyle", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? CustomerIdCardStyle { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerIdCardExpirationDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
>>>>>>> releases/v1.0.0
        public string? CustomerIdCardExpirationDate { get; set; }
    }
}
