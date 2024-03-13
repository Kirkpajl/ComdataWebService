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
    [MessageContract(WrapperName = "VehicleIdDeleteResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class DeleteVehicleIdResponse : IResponse
    {
        /// <summary>
        /// Number of records updated
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "numberChanges", Form = XmlSchemaForm.Unqualified)]
        public int NumberChanges { get; set; }  //Nullable<int>

        /// <summary>
        /// 0=Success Anything Else=Error
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified)]
        public int ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message should be: OK
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified)]
        public string ResponseDescription { get; set; } = string.Empty;



        public DeleteVehicleIdResponse()
        {
        }

        public DeleteVehicleIdResponse(int numberChanges, int responseCode, string responseDescription)
        {
            this.NumberChanges = numberChanges;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
