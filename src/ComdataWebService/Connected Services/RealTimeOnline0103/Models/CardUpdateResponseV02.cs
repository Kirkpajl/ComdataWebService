using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardUpdateResponseV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateResponseV02Body : ISoapResponseBody<CardUpdateResponseV02>
    {
        public CardUpdateResponseV02Body() : this(new CardUpdateResponseV02()) { }
        public CardUpdateResponseV02Body(CardUpdateResponseV02 response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardUpdateReturnV02", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardUpdateResponseV02 Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cardUpdateResponseV02", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardUpdateResponseV02Body
    {
        public CardUpdateResponseV02Body() : this(new CardUpdateResponseV02()) { }

        public CardUpdateResponseV02Body(CardUpdateResponseV02 response)
        {
            this.Response = response;
        }




        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardUpdateReturnV02", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardUpdateResponseV02 Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardUpdateResponseV02 : ISoapResponse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }
    }
}
