using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum LocationType
    {
        /// <summary>
        /// Service Center
        /// </summary>
        [XmlEnum(Name = "0")]
        ServiceCenter,

        /// <summary>
        /// Chain
        /// </summary>
        [XmlEnum(Name = "1")]
        Chain,

        /// <summary>
        /// Corp
        /// </summary>
        [XmlEnum(Name = "2")]
        Corp
    }
}
