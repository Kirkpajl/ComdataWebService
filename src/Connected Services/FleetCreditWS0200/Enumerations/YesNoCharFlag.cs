using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    public enum YesNoCharFlag  // N=No; Y=Yes
    {
        /// <summary>
        /// No
        /// </summary>
        [XmlEnum(Name = "N")]
        No,

        /// <summary>
        /// Yes
        /// </summary>
        [XmlEnum(Name = "Y")]
        Yes
    }
}
