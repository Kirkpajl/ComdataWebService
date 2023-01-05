using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CustomerProfileLimitUpdateRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCustomerProfileLimitsRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "requestUtil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerProfileLimitReqRespUtil? RequestUtil;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileLimits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProfileLimits? ProfileLimits;



        public UpdateCustomerProfileLimitsRequest()
        {
        }

        public UpdateCustomerProfileLimitsRequest(CustomerProfileLimitReqRespUtil requestUtil, ProfileLimits profileLimits)
        {
            this.RequestUtil = requestUtil;
            this.ProfileLimits = profileLimits;
        }
    }
}
