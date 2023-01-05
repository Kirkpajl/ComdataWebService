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
    [MessageContract(WrapperName = "CustomerProfileLimitInquiryRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCustomerProfileLimitsRequest : IRequest
    {

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "requestUtil", Form = XmlSchemaForm.Unqualified)]
        public CustomerProfileLimitReqRespUtil? RequestUtil { get; set; }



        public InquireCustomerProfileLimitsRequest()
        {
        }

        public InquireCustomerProfileLimitsRequest(CustomerProfileLimitReqRespUtil requestUtil)
        {
            this.RequestUtil = requestUtil;
        }
    }
}
