using Comdata.RealTimeOnline0103.Enumerations;
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
    [MessageContract(WrapperName = "cardInquiryV03", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardInquiryRequestV03Body : IRequest<CardInquiryRequestV03>
    {
        public CardInquiryRequestV03Body() : this(new CardInquiryRequestV03()) { }
        public CardInquiryRequestV03Body(CardInquiryRequestV03 request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "inquiryRequestV03", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardInquiryRequestV03 Content { get; set; }
    }



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardInquiryRequestV03 : IRequest
    {
        /// <remarks/>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardIdentifier", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardIdentifier { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? Password { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? MaskCardFlag { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardIdentifierType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public CardIdentifierType? CardIdentifierType { get; set; }
    }
}
