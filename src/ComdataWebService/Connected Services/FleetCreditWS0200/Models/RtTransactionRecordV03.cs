using Comdata.FleetCreditWS0200.Enumerations;
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
    public partial class RtTransactionRecordV03 : RtTransactionRecordV02
    {
        /// <summary>
        /// POS entry mode
        /// </summary>
        [XmlElement(ElementName = "posEMode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? PosEMode { get; set; }

        /// <summary>
        /// POS entry description
        /// </summary>
        [XmlElement(ElementName = "posEModeDesc", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public string? PosEModeDesc { get; set; }

        /// <summary>
        /// Acceptor ID
        /// </summary>
        [XmlElement(ElementName = "acceptorId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? AcceptorId { get; set; }
    }
}
