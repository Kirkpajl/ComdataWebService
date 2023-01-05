using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ProprietaryIntradayRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class ProprietaryIntradayRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxRows", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaxRows;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "startDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartDate;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maskCardFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? PageNbr;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "startTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartTime;



        public ProprietaryIntradayRequest()
        {
        }

        public ProprietaryIntradayRequest(string maxRows, string startDate, string maskCardFlag, string pageNbr, string startTime)
        {
            this.MaxRows = maxRows;
            this.StartDate = startDate;
            this.MaskCardFlag = maskCardFlag;
            this.PageNbr = pageNbr;
            this.StartTime = startTime;
        }
    }
}
