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
    [MessageContract(WrapperName = "CustomerProfileLimitUpdateResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCustomerProfileLimitsResponse : IResponse
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "responseUtil", Form = XmlSchemaForm.Unqualified)]
        public CustomerProfileLimitReqRespUtil? ResponseUtil { get; set; }

        /// <summary>
        /// 0=Success Anything Else=Error
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the response message should be: UPDATE SUCCESSFUL
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? ResponseDescription { get; set; }



        public UpdateCustomerProfileLimitsResponse()
        {
        }

        public UpdateCustomerProfileLimitsResponse(CustomerProfileLimitReqRespUtil responseUtil, string responseCode, string responseDescription)
        {
            this.ResponseUtil = responseUtil;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
