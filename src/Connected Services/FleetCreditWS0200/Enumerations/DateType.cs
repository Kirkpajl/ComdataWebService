using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/domain/")]
    public enum DateType
    {
        [XmlEnum("")]
        Item,
        Transaction,
        Posted,
    }
}
