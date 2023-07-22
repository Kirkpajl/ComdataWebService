using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    public enum OpenCloseCharFlag  // O=Open; C=Close
    {
        /// <summary>
        /// Open
        /// </summary>
        [XmlEnum(Name = "O")]
        Open,

        /// <summary>
        /// Close
        /// </summary>
        [XmlEnum(Name = "C")]
        Close
    }
}
