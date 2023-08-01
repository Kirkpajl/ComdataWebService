using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/domain/")]
    public enum IntradayDetailType
    {
        /// <summary>
        /// Product Details level data will be provided.
        /// </summary>
        /// <remarks>
        /// Product Details is a future feature that is not fully available yet.
        /// </remarks>
        [XmlEnum(Name = "PD")]
        ProductDetails,

        /// <summary>
        /// Only regular MasterCard Intraday fields will be returned.
        /// </summary>
        [XmlEnum(Name = "")]
        Regular
    }
}
