﻿using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System.Xml.Linq;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Pin Set 1.0 function is used to establish a card's PIN (Personal Identification Number).
    /// 
    /// Encryption algorithm instructions are detailed in a separate document.Please consult your Comdata Technical
    /// Representative.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "pinSet", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class PinSetRequestBody : IRequest  //ISoapRequestBody<PinSetRequest>
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "pinSet", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class PinSetRequestBody : ISoapRequestBody<PinSetRequest>
>>>>>>> releases/v1.0.0
    {
        public PinSetRequestBody() : this(new PinSetRequest()) { }
        public PinSetRequestBody(PinSetRequest request) { Request = request; }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "setRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public PinSetRequest Request { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "pinSet", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "setRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public PinSetRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "pinSet", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
>>>>>>> releases/v1.0.0
    public partial class PinSetRequestBody
    {
        public PinSetRequestBody() : this(new PinSetRequest()) { }

        public PinSetRequestBody(PinSetRequest request)
        {
            this.Request = request;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "setRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "setRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public PinSetRequest Request { get; set; }
    }*/



<<<<<<< HEAD
    /// <summary>
    /// The Pin Set 1.0 function is used to establish a card's PIN (Personal Identification Number).
    /// 
    /// Encryption algorithm instructions are detailed in a separate document.Please consult your Comdata Technical
    /// Representative.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class PinSetRequest// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Full 16-digit card number. (BIN required).
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned
        /// in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value
        /// assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? Password { get; set; }

        /// <summary>
        /// Encryption algorithm instructions provided in separate document.
        /// </summary>
        [XmlElement(ElementName = "pin", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? Pin { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by
        /// Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by
        /// Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
=======
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class PinSetRequest : ISoapRequest
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? Pin { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
>>>>>>> releases/v1.0.0
        public long? TrackingNumber { get; set; }
    }
}
