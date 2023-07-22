using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/domain/")]
    public enum CardIdentifierType
    {
        /// <summary>
        /// Card number.
        /// </summary>
        [XmlEnum(Name = "C")]  //, XmlEnum(Name = "c")
        CardNumber,

        /// <summary>
        /// Card token.
        /// </summary>
        [XmlEnum(Name = "T")]  //, XmlEnum(Name = "t")
        CardToken,

        /// <summary>
        /// Employee number.
        /// </summary>
        [XmlEnum(Name = "E")]  //, XmlEnum(Name = "e")
        EmployeeNumber
    }
}
