using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    public enum YesNoNullCharFlag  // Space/null=No; Y=Yes
    {
        /// <summary>
        /// No
        /// </summary>
        [XmlEnum(Name = "")]
        No,

        /// <summary>
        /// Yes
        /// </summary>
        [XmlEnum(Name = "Y")]
        Yes
    }
}
