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
    public partial class RtTransactionRecordV04 : RtTransactionRecordV03
    {
        /// <remarks/>
        [XmlElement(ElementName = "cardToken", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public string? CardToken { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "rejectDesc", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? RejectDesc { get; set; }
    }
}
