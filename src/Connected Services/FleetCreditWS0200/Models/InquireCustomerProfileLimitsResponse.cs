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
    [MessageContract(WrapperName = "CustomerProfileLimitInquiryResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCustomerProfileLimitsResponse : IResponse
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "responseUtil", Form = XmlSchemaForm.Unqualified)]
        public CustomerProfileLimitReqRespUtil ResponseUtil { get; set; } = default!;  //CustomerProfileLimitReqRespUtil?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "profileLimits", Form = XmlSchemaForm.Unqualified)]
        public ProfileLimits ProfileLimits { get; set; } = default!;  //ProfileLimits?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified)]
        public int ResponseCode { get; set; }  //string?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified)]
        public string ResponseDescription { get; set; } = default!;



        public InquireCustomerProfileLimitsResponse()
        {
        }

        public InquireCustomerProfileLimitsResponse(CustomerProfileLimitReqRespUtil responseUtil, ProfileLimits profileLimits, int responseCode, string responseDescription)
        {
            this.ResponseUtil = responseUtil;
            this.ProfileLimits = profileLimits;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
