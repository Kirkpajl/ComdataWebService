using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardMoveMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardMoveMaintenanceRequestBody : ISoapRequestBody<CardMoveMaintenanceRequest>
    {
        public CardMoveMaintenanceRequestBody() : this(new CardMoveMaintenanceRequest()) { }
        public CardMoveMaintenanceRequestBody(CardMoveMaintenanceRequest request) { Request = request; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardMoveMaintenanceRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardMoveMaintenanceRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardMoveMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardMoveMaintenanceRequestBody
    {
        public CardMoveMaintenanceRequestBody() : this(new CardMoveMaintenanceRequest()) { }

        public CardMoveMaintenanceRequestBody(CardMoveMaintenanceRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardMoveMaintenanceRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardMoveMaintenanceRequest Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardMoveMaintenanceRequest : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string? SecurityInfo { get; set; }  //public string? SecurityCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "moveFromAccountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string? MoveFromAccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "moveFromCustomerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string? MoveFromCustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "moveToAccountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string? MoveToAccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "moveToCustomerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string? MoveToCustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "moveSecurityCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string? MoveSecurityCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string? Password { get; set; }
    }
}
