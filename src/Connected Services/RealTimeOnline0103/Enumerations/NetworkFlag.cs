using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum NetworkFlag  //0=One Time O=Open C=Close or blank
    {
        /// <summary>
        /// One Time
        /// </summary>
        [XmlEnum(Name = "0")]
        OneTime,

        /// <summary>
        /// Open
        /// </summary>
        [XmlEnum(Name = "O")]
        Open,

        /// <summary>
        /// Close
        /// </summary>
        [XmlEnum(Name = "C")]
        Close
    }
}
