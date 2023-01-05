using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using Comdata.RealTimeOnline0103.Enumerations;

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
    [MessageContract(WrapperName = "expressCheckMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckMaintenanceRequestBody : IRequest  //ISoapRequestBody<ExpressCheckMaintenanceRequest>
    {
        public ExpressCheckMaintenanceRequestBody() : this(new ExpressCheckMaintenanceRequest()) { }
        public ExpressCheckMaintenanceRequestBody(ExpressCheckMaintenanceRequest request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "maintRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckMaintenanceRequest Request { get; set; }
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
    public partial class ExpressCheckMaintenanceRequest// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Explanatory message for action taken (optional)
        /// </summary>
        [XmlElement(ElementName = "message", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? Message { get; set; }

        /// <summary>
        /// Must be a secure card or codeword for realtime processing.  Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? Password { get; set; }

        /// <summary>
        /// PIN Number
        /// </summary>
        [XmlElement(ElementName = "pin", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? Pin { get; set; }

        /// <summary>
        /// Security Code/Codeword value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Value of positions 6-10 of Express Check Code
        /// </summary>
        [XmlElement(ElementName = "sequenceNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? SequenceNumber { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// A = Activate; B = Block; C = Cancel
        /// </summary>
        [XmlElement(ElementName = "expressCheckFunction", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public ExpressCheckFunctionType ExpressCheckFunction { get; set; }  // string?

        /// <summary>
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public long? TrackingNumber { get; set; }
    }
}
