using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateCardRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCardV01Request
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<EmpNumCardNumFlag> EmpNumCardNumFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? EmpNumCardNumValue;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV01? CardDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mailingDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV01? MailingDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maskCardFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag;



        public UpdateCardV01Request()
        {
        }

        public UpdateCardV01Request(System.Nullable<EmpNumCardNumFlag> empNumCardNumFlag, string empNumCardNumValue, CardRecordV01 cardDetails, MailingDetailsV01 mailingDetails, string maskCardFlag)
        {
            this.EmpNumCardNumFlag = empNumCardNumFlag;
            this.EmpNumCardNumValue = empNumCardNumValue;
            this.CardDetails = cardDetails;
            this.MailingDetails = mailingDetails;
            this.MaskCardFlag = maskCardFlag;
        }
    }
}
