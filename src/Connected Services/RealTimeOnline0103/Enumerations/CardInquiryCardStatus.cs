using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CardInquiryCardStatus
    {
        [XmlEnum(Name = "A")]
        Active,

        [XmlEnum(Name = "B")]
        Blocked,

        [XmlEnum(Name = "C")]
        Clear,

        [XmlEnum(Name = "D")]
        Delete
    }
}
