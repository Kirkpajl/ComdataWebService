using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum AtmAccessType
    {
        /// <summary>
        /// Cash on Card
        /// </summary>
        [XmlEnum(Name = "C")]
        CashOnCard,

        /// <summary>
        /// Express Cash
        /// </summary>
        [XmlEnum(Name = "E")]
        ExpressCash,

        /// <summary>
        /// No
        /// </summary>
        [XmlEnum(Name = "N")]
        No,

        /// <summary>
        /// Both
        /// </summary>
        [XmlEnum(Name = "B")]
        Both,

        [XmlEnum(Name = "")]
        Blank
    }
}
