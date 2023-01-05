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
    /// <summary>
    /// The Express Check Batch 1.0 function is used by the customer to request Express Check Seed Code. Express
    /// Check Seed Code are part of the key building blocks used in calculating Express Check codes.Instructions for
    /// calculating Express Check codes are provided separately upon request.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "expressCheckBatchResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckBatchResponseBody : IResponse //ISoapResponseBody<ExpressCheckBatchResponse>
    {
        public ExpressCheckBatchResponseBody() : this(new ExpressCheckBatchResponse()) { }
        public ExpressCheckBatchResponseBody(ExpressCheckBatchResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "expressCheckBatchReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckBatchResponse Content { get; set; }
    }



    /// <summary>
    /// The Express Check Batch 1.0 function is used by the customer to request Express Check Seed Code. Express
    /// Check Seed Code are part of the key building blocks used in calculating Express Check codes.Instructions for
    /// calculating Express Check codes are provided separately upon request.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckBatchResponse  // : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "amountFactor", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? AmountFactor { get; set; }

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
        /// 0 = OK; Anything else = Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.  No value returned if retrieval successful.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Nested array of seed code
        /// </summary>
        [XmlArray(ElementName = "seedCodeArray", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public SeedCode[]? SeedCodeArray { get; set; }

        /// <summary>
        /// No Value. Refer to seedCodeArray.
        /// </summary>
        [XmlElement(ElementName = "sequenceNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? SequenceNumber { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public long? TrackingNumber { get; set; }
    }
}
