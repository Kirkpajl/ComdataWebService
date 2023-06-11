using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    /// <summary>
    /// The status of the direct deposit account
    /// </summary>
    public enum DirectDepositInquiryAccountStatus
    {
        [XmlEnum(Name = "A")]
        Activated,

        [XmlEnum(Name = "B")]
        Blocked,

        /// <summary>
        /// Pending Pre-note
        /// </summary>
        [XmlEnum(Name = "P")]
        Pending
    }
}
