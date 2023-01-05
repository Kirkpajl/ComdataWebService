using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddCardRequestV03", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddCardV03Request
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV03? CardDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mailingDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV02? MailingDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileLimits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProfileLimits? ProfileLimits;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maskCard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool MaskCard;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool SecurityCode;



        public AddCardV03Request()
        {
        }

        public AddCardV03Request(CardRecordV03 cardDetails, MailingDetailsV02 mailingDetails, ProfileLimits profileLimits, bool maskCard, bool securityCode)
        {
            this.CardDetails = cardDetails;
            this.MailingDetails = mailingDetails;
            this.ProfileLimits = profileLimits;
            this.MaskCard = maskCard;
            this.SecurityCode = securityCode;
        }
    }
}
