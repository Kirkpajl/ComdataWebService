using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    /// <summary>
    /// P=Percent of load amount is sent to ACH; A=Amount is sent to ACH; C = Amount of load kept in Express Cash; the remainder is sent to ACH
    /// </summary>
    public enum DepositType
    {
        /// <summary>
        /// Percent of load amount is sent to ACH
        /// </summary>
        [XmlEnum(Name = "P")]
        PercentOfLoad,

        /// <summary>
        /// Amount is sent to ACH
        /// </summary>
        [XmlEnum(Name = "A")]
        AmountDeposited,

        /// <summary>
        /// Amount of load kept in Express Cash; the remainder is sent to ACH
        /// </summary>
        [XmlEnum(Name = "C")]
        AmountRetained
    }
}
