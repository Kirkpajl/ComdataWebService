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
    [MessageContract(WrapperName = "CardProfileLimitInquiryResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardProfileLimitsResponse : IResponse
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "responseUtil", Form = XmlSchemaForm.Unqualified)]
        public CardProfileLimitReqResUtil? ResponseUtil { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "profileLimits", Form = XmlSchemaForm.Unqualified)]
        public ProfileLimits ProfileLimits { get; set; } = new ProfileLimits();

        /// <summary>
        /// 0=Success Anything Else=Error
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified)]
        public int ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message will be: INQUIRY SUCCESSFUL
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? ResponseDescription { get; set; }



        public InquireCardProfileLimitsResponse()
        {
        }

        public InquireCardProfileLimitsResponse(Models.CardProfileLimitReqResUtil responseUtil, ProfileLimits profileLimits, int responseCode, string responseDescription)
        {
            this.ResponseUtil = responseUtil;
            this.ProfileLimits = profileLimits;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
