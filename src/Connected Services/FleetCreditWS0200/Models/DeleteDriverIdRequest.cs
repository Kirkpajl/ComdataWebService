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
    [MessageContract(WrapperName = "DriverIdDeleteRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class DeleteDriverIdRequest : IRequest
    {
        /// <summary>
        /// Numeric driver ID of 6 digits; the field permits <= 16 digits
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "driverId", Form = XmlSchemaForm.Unqualified)]
        public string DriverId { get; set; } = default!;

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



        public DeleteDriverIdRequest()
        {
        }

        public DeleteDriverIdRequest(string driverId, string accountNumber, string customerId)
        {
            this.DriverId = driverId;
            this.AccountNumber = accountNumber;
            this.CustomerId = customerId;
        }
    }
}
