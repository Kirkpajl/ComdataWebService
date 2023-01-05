using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CardInquiryVoicemailEmail
    {
        [XmlEnum(Name = "V")]
        Voice,

        [XmlEnum(Name = "E")]
        Email,

        [XmlEnum(Name = "B")]
        Both,

        [XmlEnum(Name = "N")]
        None
    }
}
