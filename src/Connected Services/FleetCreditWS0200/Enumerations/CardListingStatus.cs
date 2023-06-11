using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    public enum CardListingStatus
    {
        [XmlEnum(Name = "A")]
        Active,

        [XmlEnum(Name = "B")]
        Blocked,

        [XmlEnum(Name = "C")]
        Clear,

        [XmlEnum(Name = "F")]
        Fraud,

        [XmlEnum(Name = "L")]
        Lost,

        [XmlEnum(Name = "S")]
        Stolen,

        [XmlEnum(Name = "X")]
        PermanentBlock
    }
}
