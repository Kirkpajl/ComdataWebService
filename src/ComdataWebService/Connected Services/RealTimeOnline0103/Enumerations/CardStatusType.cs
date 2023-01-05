using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CardStatusType
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
        /// Clear
        /// </summary>
        [XmlEnum(Name = "C")]
        Clear,

        /// <summary>
        /// Delete
        /// </summary>
        [XmlEnum(Name = "D")]
        Deleted,

        /// <summary>
        /// Lost
        /// </summary>
        [XmlEnum(Name = "L")]
        Lost
    }
}
