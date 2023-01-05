using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "transferMaintenanceByCardtoken", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TransferMaintenanceByCardtokenRequestBody : IRequest  //ISoapRequestBody<TransferMaintenanceByCardtokenRequest>
    {
        public TransferMaintenanceByCardtokenRequestBody() : this(new TransferMaintenanceByCardtokenRequest()) { }
        public TransferMaintenanceByCardtokenRequestBody(TransferMaintenanceByCardtokenRequest request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "transferMaintenanceByCardtokenRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public TransferMaintenanceByCardtokenRequest Request { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "transferMaintenanceByCardtoken", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TransferMaintenanceByCardtokenRequestBody
    {
        public TransferMaintenanceByCardtokenRequestBody() : this(new TransferMaintenanceByCardtokenRequest()) { }

        public TransferMaintenanceByCardtokenRequestBody(TransferMaintenanceByCardtokenRequest request)
        {
            this.Request = request;
        }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "transferMaintenanceByCardtokenRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public TransferMaintenanceByCardtokenRequest Request { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class TransferMaintenanceByCardtokenRequest// : ISoapRequest
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
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public Nullable<long> TrackingNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? Password { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "securityCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SecurityInfo { get; set; }  //public string? SecurityCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardAccountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? CardAccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardCustomerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CardCustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "transferFromCardToken", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? TransferFromCardToken { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "transferToCardToken", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? TransferToCardToken { get; set; }
    }
}
