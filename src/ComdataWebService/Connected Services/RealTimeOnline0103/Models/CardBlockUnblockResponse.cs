using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardBlockUnblockResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardBlockUnblockResponseBody : ISoapResponseBody<CardBlockUnblockResponse>
    {
        public CardBlockUnblockResponseBody() : this(new CardBlockUnblockResponse()) { }
        public CardBlockUnblockResponseBody(CardBlockUnblockResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElementAttribute(ElementName = "cardBlockUnblockReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardBlockUnblockResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardBlockUnblockResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardBlockUnblockResponseBody
    {
        public CardBlockUnblockResponseBody()
        {
            this.Response = new CardBlockUnblockResponse();
        }

        public CardBlockUnblockResponseBody(CardBlockUnblockResponse response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElementAttribute(ElementName = "cardBlockUnblockReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardBlockUnblockResponse Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardBlockUnblockResponse : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata.  (4 digit CustomerId's will include leading zero)
        /// </summary>
        [XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }
    }
}
