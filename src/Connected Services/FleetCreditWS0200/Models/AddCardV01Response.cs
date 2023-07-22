using Comdata.Models.Internals;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [MessageContract(WrapperName = "AddCardResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddCardV01Response : IResponse<CardAddUpdateResponse>
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "response", Form = XmlSchemaForm.Unqualified)]
        public CardAddUpdateResponse Content { get; set; } = default!;



        public AddCardV01Response()
        {
        }

        public AddCardV01Response(CardAddUpdateResponse response)
        {
            Content = response;
        }
    }
}
