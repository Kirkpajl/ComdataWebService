using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Exceptions
{
    [DebuggerStepThrough()]
    [XmlType(AnonymousType = true, Namespace = "http://fleetCredit.comdata.com/exception/")]
    public partial class BusinessException
    {
        [XmlElement(ElementName = "messageCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public long? MessageCode { get; set; }

        [XmlElement(ElementName = "message", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? Message { get; set; }
    }
}
