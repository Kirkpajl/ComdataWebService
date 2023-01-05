using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Exceptions
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(AnonymousType = true, Namespace = "http://fleetCredit.comdata.com/exception/")]
    public partial class BusinessException
    {
        /// <remarks/>
        [XmlElement(ElementName = "messageCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public Nullable<long> MessageCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "message", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? Message { get; set; }
    }
}
