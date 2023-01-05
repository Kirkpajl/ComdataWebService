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

namespace Comdata.RealTimeOnline0103.Models
{
    /// <remarks/>
<<<<<<< HEAD
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
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class ProductElement
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "productCode", DataType = "integer", Order = 0)]
        public string? ProductCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "productFlag", Order = 1)]
>>>>>>> releases/v1.0.0
        public string? ProductFlag { get; set; }
    }
}
