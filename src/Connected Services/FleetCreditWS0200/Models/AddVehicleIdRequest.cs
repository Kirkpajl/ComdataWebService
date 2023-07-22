using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "VehicleIdAddRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddVehicleIdRequest : IRequest<VehicleIdRecord>
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "record", Form = XmlSchemaForm.Unqualified)]
        public VehicleIdRecord Content { get; set; } = default!;



        public AddVehicleIdRequest()
        {
        }

        public AddVehicleIdRequest(VehicleIdRecord criteria)
        {
            this.Content = criteria;
        }
    }
}
