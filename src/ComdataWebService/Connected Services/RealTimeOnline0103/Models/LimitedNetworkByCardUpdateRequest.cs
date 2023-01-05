using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "limitedNetworkByCardUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LimitedNetworkByCardUpdateRequestBody : ISoapRequestBody<LimitedNetworkByCardUpdateRequest>
    {
        public LimitedNetworkByCardUpdateRequestBody() : this(new LimitedNetworkByCardUpdateRequest()) { }
        public LimitedNetworkByCardUpdateRequestBody(LimitedNetworkByCardUpdateRequest request) { Request = request; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LimitedNetworkByCardUpdateRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "limitedNetworkByCardUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LimitedNetworkByCardUpdateRequestBody
    {
        public LimitedNetworkByCardUpdateRequestBody() : this(new LimitedNetworkByCardUpdateRequest()) { }

        public LimitedNetworkByCardUpdateRequestBody(LimitedNetworkByCardUpdateRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LimitedNetworkByCardUpdateRequest Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class LimitedNetworkByCardUpdateRequest : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LocationCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxNum1Num2Quantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public double MaxNum1Num2Quantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxReeferQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public double MaxReeferQuantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxProdPurchases", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public double MaxProdPurchases { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxOtherQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public double MaxOtherQuantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxCashAdvance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public double MaxCashAdvance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expirationDateMMDDYY", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? ExpirationDateMMDDYY { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expirationTimeHHMM", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? ExpirationTimeHHMM { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "deleteReplaceFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? DeleteReplaceFlag { get; set; }
    }
}
