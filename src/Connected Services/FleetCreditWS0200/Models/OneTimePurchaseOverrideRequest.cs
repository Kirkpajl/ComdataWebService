using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "OneTimePurchaseOverrideRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class OneTimePurchaseOverrideRequest : IRequest
    {
        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified)]
        public string AccountCode { get; set; } = default!;

        /// <summary>
        /// Value assigned by Comdata (4-digit Customer IDs will include a leading zero)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified)]
        public string CustomerId { get; set; } = default!;

        /// <summary>
        /// Card number, card token, or employee number
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "cardIdentifier", Form = XmlSchemaForm.Unqualified)]
        public string CardIdentifier { get; set; } = default!;

        /// <summary>
        /// C = Card number, T = Card token, E = Employee number
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "cardIdentifierType", Form = XmlSchemaForm.Unqualified)]
        public CardIdentifierType CardIdentifierType { get; set; }

        /// <summary>
        /// The amount to add for the One-Time Purchase: 99999999.99
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "oneTimePurchaseAmount", Form = XmlSchemaForm.Unqualified)]
        public decimal OneTimePurchaseAmount { get; set; }



        public OneTimePurchaseOverrideRequest()
        {
        }

        public OneTimePurchaseOverrideRequest(string accountCode, string customerId, string cardIdentifier, CardIdentifierType cardIdentifierType, decimal oneTimePurchaseAmount)
        {
            this.AccountCode = accountCode;
            this.CustomerId = customerId;
            this.CardIdentifier = cardIdentifier;
            this.CardIdentifierType = cardIdentifierType;
            this.OneTimePurchaseAmount = oneTimePurchaseAmount;
        }
    }
}
