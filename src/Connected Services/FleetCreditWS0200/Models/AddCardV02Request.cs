using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.Models.Internals;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [MessageContract(WrapperName = "AddCardRequestV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddCardV02Request : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "cardDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV02? CardDetails;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "mailingDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV01? MailingDetails;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public YesNoCharFlag? MaskCardFlag;  //string?



        public AddCardV02Request()
        {
        }

        public AddCardV02Request(CardRecordV02 cardDetails, MailingDetailsV01 mailingDetails, YesNoCharFlag maskCardFlag)
        {
            CardDetails = cardDetails;
            MailingDetails = mailingDetails;
            MaskCardFlag = maskCardFlag;
        }
    }
}
