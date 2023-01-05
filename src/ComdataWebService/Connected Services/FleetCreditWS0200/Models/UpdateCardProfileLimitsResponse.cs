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
    [MessageContract(WrapperName = "CardProfileLimitUpdateResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCardProfileLimitsResponse : IResponse
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "responseUtil", Form = XmlSchemaForm.Unqualified)]
        public CardProfileLimitReqResUtil? ResponseUtil { get; set; }

        /// <summary>
        /// 0=Update Complete Anything Else=Error
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? ResponseCode { get; set; }

        /// <summary>
        /// Response description
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? ResponseDescription { get; set; }



        public UpdateCardProfileLimitsResponse()
        {
        }

        public UpdateCardProfileLimitsResponse(Models.CardProfileLimitReqResUtil responseUtil, string responseCode, string responseDescription)
        {
            this.ResponseUtil = responseUtil;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
