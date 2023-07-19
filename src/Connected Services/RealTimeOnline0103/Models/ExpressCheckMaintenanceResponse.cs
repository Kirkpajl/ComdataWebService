using Comdata.Models.Internals;
using Comdata.RealTimeOnline0103.Enumerations;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Express Check Maintenance 1.0 function is used by the customer to change the status of an Express Check
    /// Code. It is important to note that other values assigned to an Express Check code at the time of Retrieval or
    /// Issuance such as amount, driver number, first name, last name, location code, purpose code, trip number, and
    /// unit number cannot be altered.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "expressCheckMaintenanceResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckMaintenanceResponseBody : IResponse //ISoapResponseBody<ExpressCheckMaintenanceResponse>
    {
        public ExpressCheckMaintenanceResponseBody() : this(new ExpressCheckMaintenanceResponse()) { }
        public ExpressCheckMaintenanceResponseBody(ExpressCheckMaintenanceResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "expressCheckMaintenanceReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckMaintenanceResponse Content { get; set; }
    }



    /// <summary>
    /// The Express Check Maintenance 1.0 function is used by the customer to change the status of an Express Check
    /// Code. It is important to note that other values assigned to an Express Check code at the time of Retrieval or
    /// Issuance such as amount, driver number, first name, last name, location code, purpose code, trip number, and
    /// unit number cannot be altered.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckMaintenanceResponse  // : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "codeBalance", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public double CodeBalance { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Merchant Code
        /// </summary>
        [XmlElement(ElementName = "locationCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? LocationCode { get; set; }

        /// <summary>
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "originalAmount", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public double OriginalAmount { get; set; }

        /// <summary>
        /// 0 = OK; Anything else = Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description. No value returned if retrieval successful.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// A = Activate; B = Block; C = Cancel
        /// </summary>
        [XmlElement(ElementName = "status", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public ExpressCheckStatusType Status { get; set; } = ExpressCheckStatusType.Active;  // string?

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public long? TrackingNumber { get; set; }
    }
}
