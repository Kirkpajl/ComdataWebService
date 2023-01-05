using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddCardResponseV03", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddCardV03Response
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardSecurityCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardSecurityCode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV03? CardDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amountLimits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public AmountLimits? AmountLimits;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mailingDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV02? MailingDetails;



        public AddCardV03Response()
        {
        }

        public AddCardV03Response(string cardNumber, string cardSecurityCode, CardRecordV03 cardDetails, AmountLimits amountLimits, MailingDetailsV02 mailingDetails)
        {
            this.CardNumber = cardNumber;
            this.CardSecurityCode = cardSecurityCode;
            this.CardDetails = cardDetails;
            this.AmountLimits = amountLimits;
            this.MailingDetails = mailingDetails;
        }
    }
}
