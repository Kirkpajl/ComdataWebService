using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DriverIdAddRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddDriverIdRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "record", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DriverIdRecord? Record;



        public AddDriverIdRequest()
        {
        }

        public AddDriverIdRequest(DriverIdRecord record)
        {
            this.Record = record;
        }
    }
}
