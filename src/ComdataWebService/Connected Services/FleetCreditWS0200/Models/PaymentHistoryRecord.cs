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
    public partial class PaymentHistoryRecord
    {
        /// <remarks/>
        [XmlElement(ElementName = "paymentDate", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? PaymentDate { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "paymentAmt", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public decimal PaymentAmt { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "paymentSrcCd", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? PaymentSrcCd { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "paymentDesc", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public string? PaymentDesc { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "paymentStatus", Form = XmlSchemaForm.Unqualified, Order = 4)]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class PaymentHistoryRecord
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "paymentDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? PaymentDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "paymentAmt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public decimal PaymentAmt { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "paymentSrcCd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string? PaymentSrcCd { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "paymentDesc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string? PaymentDesc { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "paymentStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
>>>>>>> releases/v1.0.0
        public string? PaymentStatus { get; set; }
    }
}
