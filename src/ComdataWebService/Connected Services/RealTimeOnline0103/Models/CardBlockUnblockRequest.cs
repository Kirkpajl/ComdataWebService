using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Xml.Serialization;
using Comdata.Models.Internals;
using System.Xml.Schema;
<<<<<<< HEAD
using System.Diagnostics;
using System.CodeDom.Compiler;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardBlockUnblock", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardBlockUnblockRequestBody : IRequest  //, ISoapRequestBody<CardBlockUnblockRequest> 
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContractAttribute(WrapperName = "cardBlockUnblock", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardBlockUnblockRequestBody : ISoapRequestBody<CardBlockUnblockRequest> 
>>>>>>> releases/v1.0.0
    {
        public CardBlockUnblockRequestBody() : this(new CardBlockUnblockRequest()) { }
        public CardBlockUnblockRequestBody(CardBlockUnblockRequest request) { Request = request; }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
=======
        [MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
>>>>>>> releases/v1.0.0
        [XmlElement(ElementName = "blockRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardBlockUnblockRequest Request { get; set; }
    }

<<<<<<< HEAD
    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardBlockUnblock", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
=======
    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContractAttribute(WrapperName = "cardBlockUnblock", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
>>>>>>> releases/v1.0.0
    public partial class CardBlockUnblockRequestBody
    {
        public CardBlockUnblockRequestBody()
        {
            this.Request = new CardBlockUnblockRequest();
        }

        public CardBlockUnblockRequestBody(CardBlockUnblockRequest request)
        {
            this.Request = request;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
=======
        [MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
>>>>>>> releases/v1.0.0
        [XmlElement(ElementName = "blockRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardBlockUnblockRequest Request { get; set; }
    }*/



    /// <remarks/>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardBlockUnblockRequest// : ISoapRequest
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardBlockUnblockRequest : ISoapRequest
>>>>>>> releases/v1.0.0
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// This is the card that needs to be modified.  Include full 10-digit card number.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get;set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit CustomerId's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData {get;set; }

        /// <summary>
        /// Must be a secure card for real-time processing.  Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? Password { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Any Number
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 1 and TRUE = TRUE
        /// 0 and FALSE = FALSE
        /// </summary>
        [XmlElement(ElementName = "cardActive", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public bool CardActive { get; set; }
    }
}
