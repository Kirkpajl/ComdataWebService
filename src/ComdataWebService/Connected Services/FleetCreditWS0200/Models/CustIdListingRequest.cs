using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CustIdListingRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CustIdListingRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxRows", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? maxRows;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("accountCodes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[]? accountCodes;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "customerIds", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[]? customerIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string? pageNbr;



        public CustIdListingRequest()
        {
        }

        public CustIdListingRequest(string maxRows, string[] accountCodes, string[] customerIds, string pageNbr)
        {
            this.maxRows = maxRows;
            this.accountCodes = accountCodes;
            this.customerIds = customerIds;
            this.pageNbr = pageNbr;
        }
    }
}
