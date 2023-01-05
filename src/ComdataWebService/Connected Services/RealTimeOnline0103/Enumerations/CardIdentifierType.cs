using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CardIdentifierType
    {
        [XmlEnum(Name = "T")]
        Token,

        [XmlEnum(Name = "C")]
        CardNumber,

        [XmlEnum(Name = "E")]
        Employee
    }
}
