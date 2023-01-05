using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum DeleteReplaceFlag  //D = Delete; R = Replace; No value or any value other than D or R is treated as an add request.
    {
        /// <summary>
        /// Delete
        /// </summary>
        [XmlEnum(Name = "D")]
        Delete,

        /// <summary>
        /// Replace
        /// </summary>
        [XmlEnum(Name = "R")]
        Replace,

        /// <summary>
        /// Add
        /// </summary>
        [XmlEnum(Name = "")]
        Add
    }
}
