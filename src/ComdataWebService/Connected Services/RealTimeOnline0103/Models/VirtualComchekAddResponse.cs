﻿using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualComchekAddResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekAddResponseBody : ISoapResponseBody<VirtualComchekAddResponse>
    {
        public VirtualComchekAddResponseBody() : this(new VirtualComchekAddResponse()) { }
        public VirtualComchekAddResponseBody(VirtualComchekAddResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "virtualComchekAddReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekAddResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualComchekAddResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekAddResponseBody
    {
        public VirtualComchekAddResponseBody() : this(new VirtualComchekAddResponse()) { }

        public VirtualComchekAddResponseBody(VirtualComchekAddResponse response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "virtualComchekAddReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekAddResponse Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualComchekAddResponse : ISoapResponse
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "CVC2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CVC2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expirationMMYY", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ExpirationMMYY { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public long? TrackingNumber { get; set; }
    }
}