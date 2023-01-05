using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "loadMoneyComchekResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyComchekResponseBody : ISoapResponseBody<LoadMoneyComchekResponse>
    {
        public LoadMoneyComchekResponseBody() : this(new LoadMoneyComchekResponse()) { }
        public LoadMoneyComchekResponseBody(LoadMoneyComchekResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "loadMoneyComchekReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyComchekResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "loadMoneyComchekResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyComchekResponseBody
    {
        public LoadMoneyComchekResponseBody() : this(new LoadMoneyComchekResponse()) { }

        public LoadMoneyComchekResponseBody(LoadMoneyComchekResponse response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "loadMoneyComchekReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyComchekResponse Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyComchekResponse : ISoapResponse
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "loadAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public double LoadAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "charges", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public double Charges { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "referenceNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public long ReferenceNumber { get; set; }
    }
}
