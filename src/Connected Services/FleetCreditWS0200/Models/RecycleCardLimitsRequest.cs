using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "RecycleCardLimitsRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class RecycleCardLimitsRequest : IRequest
    {
        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified)]
        public string AccountCode { get; set; } = default!;

        /// <summary>
        /// Value assigned by Comdata (4-digit customer IDs will include a leading zero)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified)]
        public string CustomerId { get; set; } = default!;

        /// <summary>
        /// Card number, card token, or employee number
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "cardIdentifierType", Form = XmlSchemaForm.Unqualified)]
        public CardIdentifierType CardIdentifierType { get; set; }

        /// <summary>
        /// C = Card number, T = Card token, E = Employee number
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "cardIdentifier", Form = XmlSchemaForm.Unqualified)]
        public string CardIdentifier { get; set; } = default!;



        public RecycleCardLimitsRequest()
        {
        }

        public RecycleCardLimitsRequest(string accountCode, string customerId, CardIdentifierType cardIdentifierType, string cardIdentifier)
        {
            this.AccountCode = accountCode;
            this.CustomerId = customerId;
            this.CardIdentifierType = cardIdentifierType;
            this.CardIdentifier = cardIdentifier;
        }
    }
}
