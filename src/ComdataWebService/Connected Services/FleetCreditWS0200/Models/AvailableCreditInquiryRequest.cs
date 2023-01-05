using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AvailableCreditInquiryRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AvailableCreditInquiryRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "accountCodes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[]? AccountCodes;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "activeAccountsOnly", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<bool> ActiveAccountsOnly;



        public AvailableCreditInquiryRequest()
        {
        }

        public AvailableCreditInquiryRequest(string[] accountCodes, System.Nullable<bool> activeAccountsOnly)
        {
            this.AccountCodes = accountCodes;
            this.ActiveAccountsOnly = activeAccountsOnly;
        }
    }
}
