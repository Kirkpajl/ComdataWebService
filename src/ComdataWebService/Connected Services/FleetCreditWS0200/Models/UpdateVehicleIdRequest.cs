using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "VehicleIdUpdateRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateVehicleIdRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "record", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VehicleIdRecord? Record;



        public UpdateVehicleIdRequest()
        {
        }

        public UpdateVehicleIdRequest(VehicleIdRecord record)
        {
            this.Record = record;
        }
    }
}
