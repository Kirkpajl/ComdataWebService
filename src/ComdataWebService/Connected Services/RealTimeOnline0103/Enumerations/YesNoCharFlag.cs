using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum YesNoCharFlag  // N=No; Y=Yes
    {
        /// <summary>
        /// No
        /// </summary>
        [XmlEnum(Name = "N")]
        No,

        /// <summary>
        /// Yes
        /// </summary>
        [XmlEnum(Name = "Y")]
        Yes
    }
}
