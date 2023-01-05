using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CardHolderUseType
    {
        [XmlEnum(Name = "P")]
        Payroll,

        [XmlEnum(Name = "S")]
        Settlement
    }
}
