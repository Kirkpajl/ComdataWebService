using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.Models.Internals;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "UpdateCardRequestV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class UpdateCardV02Request : IRequest
    {
        /// <summary>
        /// C, E, T, c, e, or t (Card Number, Employee Number, Card Token used for the cardIdentifierType)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "cardIdentifierType", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardIdentifierType> CardIdentifierType;

        /// <summary>
        /// Employee number, card number, or card token used to search
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "cardIdentifier", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardIdentifier;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "cardDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV01? CardDetails;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "mailingDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV02? MailingDetails;

        /// <summary>
        /// Y(yes) returns a masked card number. Space or null returns the full card number as long as the accountlevel access allows
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public YesNoNullCharFlag? MaskCardFlag;  //string?



        public UpdateCardV02Request()
        {
        }

        public UpdateCardV02Request(System.Nullable<CardIdentifierType> cardIdentifierType, string cardIdentifier, CardRecordV01 cardDetails, MailingDetailsV02 mailingDetails, YesNoNullCharFlag maskCardFlag)
        {
            this.CardIdentifierType = cardIdentifierType;
            this.CardIdentifier = cardIdentifier;
            this.CardDetails = cardDetails;
            this.MailingDetails = mailingDetails;
            this.MaskCardFlag = maskCardFlag;
        }
    }
}
