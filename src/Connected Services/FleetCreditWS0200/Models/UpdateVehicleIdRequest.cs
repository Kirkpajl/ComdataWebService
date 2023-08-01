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
    [MessageContract(WrapperName = "VehicleIdUpdateRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateVehicleIdRequest : IRequest<VehicleIdRecord>
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "record", Form = XmlSchemaForm.Unqualified)]
        public VehicleIdRecord Content { get; set; } = default!;



        public UpdateVehicleIdRequest()
        {
        }

        public UpdateVehicleIdRequest(VehicleIdRecord record)
        {
            this.Content = record;
        }
    }
}
