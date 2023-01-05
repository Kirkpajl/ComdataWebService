using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum DirectDepositInquiryDepositType
    {
        /// <summary>
        /// Percent of load amount is sent to ACH
        /// </summary>
        [XmlEnum(Name = "P")]
        Percent,

        /// <summary>
        /// Amount is sent to ACH
        /// </summary>
        [XmlEnum(Name = "A")]
        Amount,

        /// <summary>
        /// Amount of load kept in Express Cash; remainder is sent to ACH
        /// </summary>
        [XmlEnum(Name = "C")]
        ExpressCash
    }
}
