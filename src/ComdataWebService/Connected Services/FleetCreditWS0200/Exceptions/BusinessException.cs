using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Exceptions
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fleetCredit.comdata.com/exception/")]
    public partial class BusinessException
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "messageCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public System.Nullable<long> MessageCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "message", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? Message { get; set; }
    }
}
