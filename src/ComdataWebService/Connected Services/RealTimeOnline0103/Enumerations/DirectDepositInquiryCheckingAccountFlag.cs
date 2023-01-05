using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    public enum DirectDepositInquiryCheckingAccountFlag
    {
        [XmlEnum(Name = "Y")]
        CheckingAccount,

        [XmlEnum(Name = "N")]
        OtherAccount
    }
}
