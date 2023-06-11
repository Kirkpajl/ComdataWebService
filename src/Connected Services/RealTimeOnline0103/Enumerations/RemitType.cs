using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum RemitType  // E = Email (or) M = SMS (Mobile)
    {
        /// <summary>
        /// Email
        /// </summary>
        [XmlEnum(Name = "E")]
        Email,

        /// <summary>
        /// SMS (Mobile)
        /// </summary>
        [XmlEnum(Name = "M")]
        Mobile
    }
}
