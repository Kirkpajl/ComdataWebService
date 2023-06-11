using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System.Reflection.Emit;
using System.ServiceModel.Channels;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Express Check Batch 1.0 function is used by the customer to request Express Check Seed Code. Express
    /// Check Seed Code are part of the key building blocks used in calculating Express Check codes.Instructions for
    /// calculating Express Check codes are provided separately upon request.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "expressCheckBatch", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckBatchRequestBody : IRequest  //ISoapRequestBody<ExpressCheckBatchRequest>
    {
        public ExpressCheckBatchRequestBody() : this(new ExpressCheckBatchRequest()) { }
        public ExpressCheckBatchRequestBody(ExpressCheckBatchRequest request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "batchRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckBatchRequest Request { get; set; }
    }



    /// <summary>
    /// The Express Check Batch 1.0 function is used by the customer to request Express Check Seed Code. Express
    /// Check Seed Code are part of the key building blocks used in calculating Express Check codes.Instructions for
    /// calculating Express Check codes are provided separately upon request.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckBatchRequest// : ISoapRequest
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
        /// Valid Values 1 to 9999
        /// </summary>
        [XmlElement(ElementName = "numberOfCodes", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public short NumberOfCodes { get; set; }

        /// <summary>
        /// Must be a secure card or codeword for realtime processing.Value assigned by Comdata.
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
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public long? TrackingNumber { get; set; }
    }
}
