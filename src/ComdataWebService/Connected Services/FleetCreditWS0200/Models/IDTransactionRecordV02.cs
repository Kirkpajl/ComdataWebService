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
    public partial class IDTransactionRecordV02 : IDTransactionRecordV01
    {
        /// <remarks/>
        [XmlElement(ElementName = "acquirerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? acquirerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "acceptorId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? acceptorId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "terminalId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class IDTransactionRecordV02 : IDTransactionRecordV01
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "acquirerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? acquirerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "acceptorId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? acceptorId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "terminalId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
>>>>>>> releases/v1.0.0
        public string? terminalId { get; set; }
    }
}
