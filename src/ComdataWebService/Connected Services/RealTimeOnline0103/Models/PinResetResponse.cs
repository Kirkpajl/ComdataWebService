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

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Pin Reset 1.0 function is used to reset a card's PIN (Personal Identification Number). Once complete, a new
    /// PIN is then able to be assigned to a card.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "pinResetResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class PinResetResponseBody : IResponse //ISoapResponseBody<PinResetResponse>
    {
        public PinResetResponseBody() : this(new PinResetResponse()) { }
        public PinResetResponseBody(PinResetResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "pinResetReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public PinResetResponse Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "pinResetResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "pinResetResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class PinResetResponseBody : ISoapResponseBody<PinResetResponse>
    {
        public PinResetResponseBody() : this(new PinResetResponse()) { }
        public PinResetResponseBody(PinResetResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pinResetReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public PinResetResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "pinResetResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
>>>>>>> releases/v1.0.0
    public partial class PinResetResponseBody
    {
        public PinResetResponseBody() : this(new PinResetResponse()) { }

        public PinResetResponseBody(PinResetResponse response)
        {
            this.Response = response;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "pinResetReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pinResetReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public PinResetResponse Response { get; set; }
    }*/



<<<<<<< HEAD
    /// <summary>
    /// The Pin Reset 1.0 function is used to reset a card's PIN (Personal Identification Number). Once complete, a new
    /// PIN is then able to be assigned to a card.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class PinResetResponse  // : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata.  (4 digit Customer Id's will
        /// include leading zero)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the
        /// corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// 0=PIN Reset Successful; Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.
        /// 'PIN HAS BEEN DELETED' returned if PIN Reset successful.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// (Overrides the tracking number submitted.)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 5)]
=======
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class PinResetResponse : ISoapResponse
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
>>>>>>> releases/v1.0.0
        public long? TrackingNumber { get; set; }
    }
}
