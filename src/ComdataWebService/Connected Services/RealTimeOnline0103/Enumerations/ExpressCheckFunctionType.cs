using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum ExpressCheckFunctionType  // A = Activate; B = Block; C = Cancel
    {
        /// <summary>
        /// Activate
        /// </summary>
        [XmlEnum(Name = "A")]
        Activate,

        /// <summary>
        /// Block
        /// </summary>
        [XmlEnum(Name = "B")]
        Block,

        /// <summary>
        /// Cancel
        /// </summary>
        [XmlEnum(Name = "C")]
        Cancel
    }
}
