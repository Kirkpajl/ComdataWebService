using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Virtual Card Add 1.0 function is used to request a Comdata Virtual MasterCard.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualCardAddResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualCardAddResponseBody : IResponse<VirtualCardAddResponse>
    {
        public VirtualCardAddResponseBody() : this(new VirtualCardAddResponse()) { }
        public VirtualCardAddResponseBody(VirtualCardAddResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "virtualCardAddReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualCardAddResponse Content { get; set; }
    }



    /// <summary>
    /// The Virtual Card Add 1.0 function is used to request a Comdata Virtual MasterCard.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualCardAddResponse : IResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Full 16 digit Comdata MasterCard.  Null value returned if card was NOT added.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by Comdata.  (4 digit Customer Id's will include leading zero).
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Security code value for card authenticity.
        /// </summary>
        [XmlElement(ElementName = "CVC2", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public short CVC2 { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// If MM < 10 then Expiration Date in MYY format.
        /// If MM >= 10 then Expiration Date in MMYY format.
        /// </summary>
        [XmlElement(ElementName = "expirationMMYY", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public int ExpirationMMYY { get; set; }

        /// <summary>
        /// 0 = OK; Anything else = error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.  'CARD ADDED' returned if card add successful.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public long? TrackingNumber { get; set; }
    }
}
