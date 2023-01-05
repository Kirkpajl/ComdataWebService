using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum PlusLessFlag
    {
        /// <summary>
        /// Plus Fees
        /// </summary>
        [XmlEnum(Name = "1")]
        PlusFees,

        /// <summary>
        /// Less Fees
        /// </summary>
        [XmlEnum(Name = "2")]
        LessFees
    }
}
