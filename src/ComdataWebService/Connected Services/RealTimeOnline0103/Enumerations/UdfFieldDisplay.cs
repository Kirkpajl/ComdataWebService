using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum UdfFieldDisplay  //"IR" = Display in sender's and receiver's app; "IO" = Display in sender's app only
    {
        /// <summary>
        /// Display in sender's and receiver's app
        /// </summary>
        [XmlEnum(Name = "IR")]
        Both,

        /// <summary>
        /// Display in sender's app only
        /// </summary>
        [XmlEnum(Name = "IO")]
        SenderOnly
    }
}
