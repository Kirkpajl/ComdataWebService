using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CipFlag  //Y=CIP has passed, N=CIP has not been requested, P=CIP is pending approval, F = CIP has failed
    {
        /// <summary>
        /// CIP has passed
        /// </summary>
        [XmlEnum(Name = "Y")]
        Passed,

        /// <summary>
        /// CIP has not been requested
        /// </summary>
        [XmlEnum(Name = "N")]
        NotRequested,

        /// <summary>
        /// CIP is pending approval
        /// </summary>
        [XmlEnum(Name = "P")]
        PendingApproval,

        /// <summary>
        /// CIP has failed
        /// </summary>
        [XmlEnum(Name = "F")]
        Failed
    }
}
