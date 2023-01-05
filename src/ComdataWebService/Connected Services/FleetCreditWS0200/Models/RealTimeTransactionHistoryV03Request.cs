using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RtTransactionRequestV03", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class RealTimeTransactionHistoryV03Request
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "criteria", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RtTransactionCriteriaV03? Criteria;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? PageNbr;



        public RealTimeTransactionHistoryV03Request()
        {
        }

        public RealTimeTransactionHistoryV03Request(RtTransactionCriteriaV03 criteria, string pageNbr)
        {
            this.Criteria = criteria;
            this.PageNbr = pageNbr;
        }
    }
}
