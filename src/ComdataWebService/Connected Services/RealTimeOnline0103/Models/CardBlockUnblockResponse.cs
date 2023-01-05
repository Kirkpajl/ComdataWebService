using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.CodeDom.Compiler;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardBlockUnblockResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardBlockUnblockResponseBody : IResponse  //, ISoapResponseBody<CardBlockUnblockResponse>
    {
        public CardBlockUnblockResponseBody() : this(new CardBlockUnblockResponse()) { }
        public CardBlockUnblockResponseBody(CardBlockUnblockResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardBlockUnblockReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardBlockUnblockResponse Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardBlockUnblockResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
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



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardBlockUnblockReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardBlockUnblockResponse Response { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class CardBlockUnblockResponse  // : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata.  (4 digit CustomerId's will include leading zero)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// 0=Update Complete Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record. (Overrides the tracking number submitted.)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }
    }
}
