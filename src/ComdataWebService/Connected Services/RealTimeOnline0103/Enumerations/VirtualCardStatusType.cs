using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum VirtualCardStatusType
    {
        /// <summary>
        /// Active
        /// </summary>
        [XmlEnum(Name = "A")]
        Active,

        /// <summary>
        /// Blocked
        /// </summary>
        [XmlEnum(Name = "B")]
        Blocked,

        /// <summary>
        /// Fraud
        /// </summary>
        [XmlEnum(Name = "F")]
        Fraud,

        /// <summary>
        /// Stolen
        /// </summary>
        [XmlEnum(Name = "S")]
        Stolen
    }
}
