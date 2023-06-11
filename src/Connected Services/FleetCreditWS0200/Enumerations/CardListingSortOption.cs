using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    public enum CardListingSortOption
    {
        /// <summary>
        /// Sort by Card Number
        /// </summary>
        [XmlEnum(Name = "C")]
        CardNumber,

        /// <summary>
        /// Sort by Token
        /// </summary>
        [XmlEnum(Name = "T")]
        Token
    }
}
