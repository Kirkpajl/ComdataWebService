using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum ExpressCheckStatusType
    {
        /// <summary>
        /// Active
        /// </summary>
        [XmlEnum(Name = "A")]
        Active,

        /// <summary>
        /// Block
        /// </summary>
        [XmlEnum(Name = "B")]
        Blocked,

        /// <summary>
        /// Cancelled
        /// </summary>
        [XmlEnum(Name = "C")]
        Cancelled,

        /// <summary>
        /// Used
        /// </summary>
        [XmlEnum(Name = "U")]
        Used
    }
}
