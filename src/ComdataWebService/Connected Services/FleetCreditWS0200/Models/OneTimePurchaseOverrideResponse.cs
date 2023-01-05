using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "OneTimePurchaseOverrideResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class OneTimePurchaseOverrideResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string? ResponseCode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string? ResponseDescription;



        public OneTimePurchaseOverrideResponse()
        {
        }

        public OneTimePurchaseOverrideResponse(string responseCode, string responseDescription)
        {
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
