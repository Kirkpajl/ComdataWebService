using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum TaxIdType
    {
        /// <summary>
        /// Social Security Number
        /// </summary>
        [XmlEnum(Name = "S")]
        SocialSecurityNumber,

        /// <summary>
        /// Employer ID
        /// </summary>
        [XmlEnum(Name = "E")]
        EmployerId
    }
}
