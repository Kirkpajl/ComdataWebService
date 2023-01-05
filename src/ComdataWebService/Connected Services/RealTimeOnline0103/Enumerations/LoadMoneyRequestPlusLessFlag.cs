using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum LoadMoneyRequestPlusLessFlag
    {
        /// <summary>
        /// Full Load Amt applied to Card Balance
        /// </summary>
        [XmlEnum(Name = "1")]
        PlusFees = 1,

        /// <summary>
        /// Load Amt less Fees applied to Card Balance
        /// </summary>
        [XmlEnum(Name = "2")]
        LessFees = 2
    }
}
