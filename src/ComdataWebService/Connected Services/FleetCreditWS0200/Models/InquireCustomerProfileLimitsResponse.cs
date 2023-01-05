using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CustomerProfileLimitInquiryResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCustomerProfileLimitsResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseUtil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerProfileLimitReqRespUtil? ResponseUtil;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileLimits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProfileLimits? ProfileLimits;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? ResponseCode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? ResponseDescription;



        public InquireCustomerProfileLimitsResponse()
        {
        }

        public InquireCustomerProfileLimitsResponse(CustomerProfileLimitReqRespUtil responseUtil, ProfileLimits profileLimits, string responseCode, string responseDescription)
        {
            this.ResponseUtil = responseUtil;
            this.ProfileLimits = profileLimits;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
