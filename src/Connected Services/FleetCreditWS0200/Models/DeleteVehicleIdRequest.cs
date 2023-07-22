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
    [MessageContract(WrapperName = "VehicleIdDeleteRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class DeleteVehicleIdRequest : IRequest
    {
        /// <summary>
        /// Numeric vehicle ID of 6 digits; the field permits 16 digits
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "vehicleId", Form = XmlSchemaForm.Unqualified)]
        public string VehicleId { get; set; } = default!;

        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "acctNbr", Form = XmlSchemaForm.Unqualified)]
        public string AccountNumber { get; set; } = default!;

        /// <summary>
        /// Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "custId", Form = XmlSchemaForm.Unqualified)]
        public string CustomerId { get; set; } = default!;



        public DeleteVehicleIdRequest()
        {
        }

        public DeleteVehicleIdRequest(string vehicleId, string accountNumber, string customerId)
        {
            this.VehicleId = vehicleId;
            this.AccountNumber = accountNumber;
            this.CustomerId = customerId;
        }
    }
}
