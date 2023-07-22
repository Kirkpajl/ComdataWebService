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
    [MessageContract(WrapperName = "transferMaintenanceByCardtokenResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TransferMaintenanceByCardtokenResponseBody : IResponse<TransferMaintenanceByCardtokenResponse>
    {
        public TransferMaintenanceByCardtokenResponseBody() : this(new TransferMaintenanceByCardtokenResponse()) { }
        public TransferMaintenanceByCardtokenResponseBody(TransferMaintenanceByCardtokenResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "transferMaintenanceByCardtokenResponse", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public TransferMaintenanceByCardtokenResponse Content { get; set; }
    }



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class TransferMaintenanceByCardtokenResponse : IResponse
    {
        /// <remarks/>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }
    }
}
