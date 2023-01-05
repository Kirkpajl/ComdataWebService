using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CardProfileLimitInquiryRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardProfileLimitsRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardProfileLimitRequestUtil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CardProfileLimitReqResUtil? CardProfileLimitRequestUtil;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<EmpNumCardNumFlag> EmpNumCardNumFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? EmpNumCardNumValue;



        public InquireCardProfileLimitsRequest()
        {
        }

        public InquireCardProfileLimitsRequest(Models.CardProfileLimitReqResUtil cardProfileLimitRequestUtil, System.Nullable<EmpNumCardNumFlag> empNumCardNumFlag, string empNumCardNumValue)
        {
            this.CardProfileLimitRequestUtil = cardProfileLimitRequestUtil;
            this.EmpNumCardNumFlag = empNumCardNumFlag;
            this.EmpNumCardNumValue = empNumCardNumValue;
        }
    }
}
