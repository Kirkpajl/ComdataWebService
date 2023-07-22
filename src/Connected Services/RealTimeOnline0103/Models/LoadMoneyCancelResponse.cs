using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Express Cash Load Money Cancel 1.0 function is used for cancelling Express Cash Loads.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "loadMoneyCancelResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyCancelResponseBody : IResponse<LoadMoneyCancelResponse>
    {
        public LoadMoneyCancelResponseBody() : this(new LoadMoneyCancelResponse()) { }
        public LoadMoneyCancelResponseBody(LoadMoneyCancelResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadMoneyCancelReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyCancelResponse Content { get; set; }
    }



    /// <summary>
    /// The Express Cash Load Money Cancel 1.0 function is used for cancelling Express Cash Loads.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyCancelResponse : IResponse
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
        /// 0=Load Successfully Canceled; Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.
        /// </summary>
        /// <remarks>
        /// 'ORDER CANCELED' returned if cancel successful.
        /// </remarks>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// (Overrides the tracking number submitted.)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }
    }
}
