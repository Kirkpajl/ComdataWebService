using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class TrackCardShipment
    {
        /// <remarks/>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "dateOrderReceived", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DateOrderReceived { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardHolderName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CardHolderName { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "orderStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? OrderStatus { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "exception", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? Exception { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "dateOrderShipped", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? DateOrderShipped { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? TrackingNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "trackingURL", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? TrackingURL { get; set; }
    }
}
