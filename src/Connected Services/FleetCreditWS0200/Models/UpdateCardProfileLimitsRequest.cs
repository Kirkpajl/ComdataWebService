using Comdata.FleetCreditWS0200.Enumerations;
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
    [MessageContract(WrapperName = "CardProfileLimitUpdateRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCardProfileLimitsRequest : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "requestUtil", Form = XmlSchemaForm.Unqualified)]
        public CardProfileLimitReqResUtil? RequestUtil { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "empNumCardNumFlag", Form = XmlSchemaForm.Unqualified)]
        public EmpNumCardNumFlag EmpNumCardNumFlag { get; set; } = default!;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "empNumCardNumValue", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string EmpNumCardNumValue { get; set; } = default!;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "profileLimits", Form = XmlSchemaForm.Unqualified)]
        public ProfileLimits? ProfileLimits { get; set; }



        public UpdateCardProfileLimitsRequest()
        {
        }

        public UpdateCardProfileLimitsRequest(CardProfileLimitReqResUtil requestUtil, EmpNumCardNumFlag empNumCardNumFlag, string empNumCardNumValue, ProfileLimits profileLimits)
        {
            this.RequestUtil = requestUtil;
            this.EmpNumCardNumFlag = empNumCardNumFlag;
            this.EmpNumCardNumValue = empNumCardNumValue;
            this.ProfileLimits = profileLimits;
        }
    }
}
