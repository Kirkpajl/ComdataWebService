using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "CardProfileLimitInquiryRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardProfileLimitsRequest : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "cardProfileLimitRequestUtil", Form = XmlSchemaForm.Unqualified)]
        public CardProfileLimitReqResUtil? CardProfileLimitRequestUtil { get; set; }

        /// <summary>
        /// C, E, c, or e (Card Number or Employee Number): this specifies the type of number used in empNumCardNumValue
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "empNumCardNumFlag", Form = XmlSchemaForm.Unqualified)]
        public EmpNumCardNumFlag EmpNumCardNumFlag { get; set; } = default!;

        /// <summary>
        /// Employee number or card number used to search
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "empNumCardNumValue", Form = XmlSchemaForm.Unqualified)]
        public string EmpNumCardNumValue { get; set; } = default!;



        public InquireCardProfileLimitsRequest()
        {
        }

        public InquireCardProfileLimitsRequest(CardProfileLimitReqResUtil cardProfileLimitRequestUtil, EmpNumCardNumFlag empNumCardNumFlag, string empNumCardNumValue)
        {
            this.CardProfileLimitRequestUtil = cardProfileLimitRequestUtil;
            this.EmpNumCardNumFlag = empNumCardNumFlag;
            this.EmpNumCardNumValue = empNumCardNumValue;
        }
    }
}
