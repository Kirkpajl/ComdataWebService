using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum CheckingAccountFlagType  //0=No 1=Yes or blank
    {
        /// <summary>
        /// Not a checking account
        /// </summary>
        [XmlEnum(Name = "N")]
        No,

        /// <summary>
        /// Checking Account
        /// </summary>
        [XmlEnum(Name = "Y")]
        Yes
    }
}
