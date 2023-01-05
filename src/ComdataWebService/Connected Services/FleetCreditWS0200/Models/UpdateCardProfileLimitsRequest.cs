using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CardProfileLimitUpdateRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCardProfileLimitsRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "requestUtil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CardProfileLimitReqResUtil? requestUtil;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<EmpNumCardNumFlag> empNumCardNumFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? empNumCardNumValue;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileLimits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProfileLimits? profileLimits;



        public UpdateCardProfileLimitsRequest()
        {
        }

        public UpdateCardProfileLimitsRequest(Models.CardProfileLimitReqResUtil requestUtil, System.Nullable<EmpNumCardNumFlag> empNumCardNumFlag, string empNumCardNumValue, ProfileLimits profileLimits)
        {
            this.requestUtil = requestUtil;
            this.empNumCardNumFlag = empNumCardNumFlag;
            this.empNumCardNumValue = empNumCardNumValue;
            this.profileLimits = profileLimits;
        }
    }
}
