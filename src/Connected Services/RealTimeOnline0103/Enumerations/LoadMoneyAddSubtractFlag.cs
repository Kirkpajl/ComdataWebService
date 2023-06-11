using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum LoadMoneyAddSubtractFlag
    {
        [XmlEnum(Name = "A")]
        Add,
        [XmlEnum(Name = "S")]
        Subtract
    }
}
