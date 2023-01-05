using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CardHolderType
    {
        [XmlEnum(Name = "B")]
        Business,

        [XmlEnum(Name = "I")]
        Individual
    }
}
