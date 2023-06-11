using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum LoadMoneyResponsePlusLessFlag
    {
        /// <summary>
        /// Full Load Amt applied to Card Balance
        /// </summary>
        [XmlEnum(Name = "P")]
        PlusFees = 1,

        /// <summary>
        /// Load Amt less Fees applied to Card Balance
        /// </summary>
        [XmlEnum(Name = "L")]
        LessFees = 2
    }
}
