using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CardInquiryResponseV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardV02Response
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV02? CardDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amountLimits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public AmountLimits? AmountLimits;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mailingDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV02? MailingDetails;



        public InquireCardV02Response()
        {
        }

        public InquireCardV02Response(string cardNumber, CardRecordV02 cardDetails, AmountLimits amountLimits, MailingDetailsV02 mailingDetails)
        {
            this.CardNumber = cardNumber;
            this.CardDetails = cardDetails;
            this.AmountLimits = amountLimits;
            this.MailingDetails = mailingDetails;
        }
    }
}
