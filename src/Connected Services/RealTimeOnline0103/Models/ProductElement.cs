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
    public partial class ProductElement
    {
        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "productCode", DataType = "integer", Order = 0)]
        public string? ProductCode { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified, ElementName = "productFlag", Order = 1)]
        public string? ProductFlag { get; set; }
    }
}
