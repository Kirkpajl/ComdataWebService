using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    public enum IntradayDetailType  // (blank)=Regular; Y=Yes
    {
        /// <summary>
        /// Only regular  MasterCard Intraday fields will be returned.
        /// </summary>
        [XmlEnum(Name = " ")]
        Regular,

        /// <summary>
        /// Product Details level data will be provided.
        /// </summary>
        [XmlEnum(Name = "PD")]
        ProductDetails
    }
}
