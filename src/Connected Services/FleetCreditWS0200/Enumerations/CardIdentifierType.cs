using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/domain/")]
    public enum CardIdentifierType
    {
        c,
        e,
        C,
        E,
        t,
        T,
    }
}
