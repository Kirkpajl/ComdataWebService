using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
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
        public string? terminalId { get; set; }
    }
}
