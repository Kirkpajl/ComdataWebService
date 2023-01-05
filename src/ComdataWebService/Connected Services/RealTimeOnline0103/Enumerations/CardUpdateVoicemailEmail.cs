using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CardUpdateVoicemailEmail
    {
        [XmlEnum(Name = "1")]
        Voice,

        [XmlEnum(Name = "2")]
        Email,

        [XmlEnum(Name = "3")]
        Both,

        [XmlEnum(Name = "0")]
        None
    }
}
