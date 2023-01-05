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
    public partial class SeedCode
    {
        /// <summary>
        /// Used to calculate the code amount
        /// </summary>
        [XmlElement(ElementName = "amountFactor", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AmountFactor { get; set; }

        /// <summary>
        /// Value of positions 6-10 of Express Check Code
        /// </summary>
        [XmlElement(ElementName = "sequenceNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? SequenceNumber { get; set; }
    }
}
