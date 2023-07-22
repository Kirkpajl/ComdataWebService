using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardInquiry", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryRequestV01Body : IRequest<CardInquiryRequestV01>
    {
        public CardInquiryRequestV01Body() : this(new CardInquiryRequestV01()) { }
        public CardInquiryRequestV01Body(CardInquiryRequestV01 request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "inquiryRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryRequestV01 Content { get; set; }
    }



    /// <summary>
    /// Requests the current attributes of a Comdata Proprietary Card.  
    /// No card updates are performed.It is an information only request.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardInquiryRequestV01 : IRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// This is the card that needs to be inquired upon.  Include full 10-digit card number.
        /// The 6 digit BIN '560017' is not required on proprietary cards.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit CustomerId's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value assigned by Comdata.
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
    }
}
