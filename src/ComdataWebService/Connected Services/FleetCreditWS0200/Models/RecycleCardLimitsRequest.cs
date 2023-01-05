using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RecycleCardLimitsRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class RecycleCardLimitsRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? AccountCode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CustomerId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardIdentifierType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<CardIdentifierType> CardIdentifierType;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardIdentifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardIdentifier;



        public RecycleCardLimitsRequest()
        {
        }

        public RecycleCardLimitsRequest(string accountCode, string customerId, System.Nullable<CardIdentifierType> cardIdentifierType, string cardIdentifier)
        {
            this.AccountCode = accountCode;
            this.CustomerId = customerId;
            this.CardIdentifierType = cardIdentifierType;
            this.CardIdentifier = cardIdentifier;
        }
    }
}
