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
    [MessageContract(WrapperName = "transferToBank", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TransferToBankRequestBody : IRequest<TransferToBankRequest>
    {
        public TransferToBankRequestBody() : this(new TransferToBankRequest()) { }
        public TransferToBankRequestBody(TransferToBankRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "updateRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public TransferToBankRequest Content { get; set; }
    }



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class TransferToBankRequest : IRequest
    {
        /// <remarks/>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? Password { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? Amount { get; set; }
    }
}
