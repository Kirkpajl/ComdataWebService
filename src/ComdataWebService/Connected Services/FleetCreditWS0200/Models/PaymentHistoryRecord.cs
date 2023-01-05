using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
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
        public string? PaymentStatus { get; set; }
    }
}
