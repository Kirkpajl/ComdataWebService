using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum YesNo10Flag  //0=No 1=Yes or blank
    {
        /// <summary>
        /// No
        /// </summary>
        [XmlEnum(Name = "0")]
        No,

        /// <summary>
        /// Yes
        /// </summary>
        [XmlEnum(Name = "1")]
        Yes
    }
}
