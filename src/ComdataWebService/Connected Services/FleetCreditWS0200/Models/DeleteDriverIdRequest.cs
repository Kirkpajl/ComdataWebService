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
    [MessageContract(WrapperName = "DriverIdDeleteRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class DeleteDriverIdRequest : IRequest
    {
        /// <summary>
        /// Numeric driver ID of 6 digits; the field permits <= 16 digits
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "driverId", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? DriverId { get; set; }

        /// <summary>
        /// Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "custId", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "acctNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? AccountNumber { get; set; }



        public DeleteDriverIdRequest()
        {
        }

        public DeleteDriverIdRequest(string driverId, string custId, string acctNbr)
        {
            this.DriverId = driverId;
            this.CustomerId = custId;
            this.AccountNumber = acctNbr;
        }
    }
}
