using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateCardRequestV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCardV02Request
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardIdentifierType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<CardIdentifierType> CardIdentifierType;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardIdentifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardIdentifier;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV01? CardDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mailingDetails", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV02? MailingDetails;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maskCardFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag;



        public UpdateCardV02Request()
        {
        }

        public UpdateCardV02Request(System.Nullable<CardIdentifierType> cardIdentifierType, string cardIdentifier, CardRecordV01 cardDetails, MailingDetailsV02 mailingDetails, string maskCardFlag)
        {
            this.CardIdentifierType = cardIdentifierType;
            this.CardIdentifier = cardIdentifier;
            this.CardDetails = cardDetails;
            this.MailingDetails = mailingDetails;
            this.MaskCardFlag = maskCardFlag;
        }
    }
}
