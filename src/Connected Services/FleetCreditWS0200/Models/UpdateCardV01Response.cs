using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "UpdateCardResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCardV01Response : IResponse<CardAddUpdateResponse>
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "response", Form = XmlSchemaForm.Unqualified)]
        public CardAddUpdateResponse Content { get; set; } = default!;



        public UpdateCardV01Response()
        {
        }

        public UpdateCardV01Response(Models.CardAddUpdateResponse response)
        {
            this.Content = response;
        }
    }
}
