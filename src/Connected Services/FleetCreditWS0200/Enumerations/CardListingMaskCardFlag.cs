using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    public enum CardListingMaskCardFlag
    {
        [XmlEnum(Name = "Y")]
        Yes,

        [XmlEnum(Name = "")]  //[XmlEnum(Name = "N")]
        No
    }
}
