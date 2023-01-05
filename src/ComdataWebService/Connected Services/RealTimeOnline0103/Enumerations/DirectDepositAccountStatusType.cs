using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum DirectDepositAccountStatusType
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
        /// Pending Pre-Note
        /// </summary>
        [XmlEnum(Name = "P")]
        PendingPreNote
    }
}
