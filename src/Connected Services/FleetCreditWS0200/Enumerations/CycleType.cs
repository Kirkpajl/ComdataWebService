using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/domain/")]
    public enum CycleType  // M = Monthly W = Weekly T = Never Reset, no blanks
    {
        /// <summary>
        /// Monthly
        /// </summary>
        [XmlEnum(Name = "M")]
        Monthly,

        /// <summary>
        /// Weekly
        /// </summary>
        [XmlEnum(Name = "W")]
        Weekly,

        /// <summary>
        /// Never Reset
        /// </summary>
        [XmlEnum(Name = "T")]
        NeverReset
    }
}
