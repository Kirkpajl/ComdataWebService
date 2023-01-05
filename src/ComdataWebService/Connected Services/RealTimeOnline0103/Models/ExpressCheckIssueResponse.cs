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
    /// The Express Check Issue 1.0 function should be used by customers who have established internal processes in
    /// adherence to Comdata's Express Check Code Calculation Instructions (provided separately upon request) to
    /// calculate their own Express Check codes.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "expressCheckIssueResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckIssueResponseBody : IResponse //ISoapResponseBody<ExpressCheckIssueResponse>
    {
        public ExpressCheckIssueResponseBody() : this(new ExpressCheckIssueResponse()) { }
        public ExpressCheckIssueResponseBody(ExpressCheckIssueResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "expressCheckIssueReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckIssueResponse Content { get; set; }
    }



    /// <summary>
    /// The Express Check Issue 1.0 function should be used by customers who have established internal processes in
    /// adherence to Comdata's Express Check Code Calculation Instructions (provided separately upon request) to
    /// calculate their own Express Check codes.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckIssueResponse  // : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "amountDue", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public double AmountDue { get; set; }

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
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "expressCheckAmount", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public double ExpressCheckAmount { get; set; }

        /// <summary>
        /// Valid Amounts 0.01 to 999.99
        /// </summary>
        [XmlElement(ElementName = "expressCheckFee", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public double ExpressCheckFee { get; set; }

        /// <summary>
        /// Next Available Amount Factor
        /// </summary>
        [XmlElement(ElementName = "nextAmountFactor", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? NextAmountFactor { get; set; }

        /// <summary>
        /// Next Available Sequence
        /// </summary>
        [XmlElement(ElementName = "nextSequenceAvailable", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? NextSequenceAvailable { get; set; }

        /// <summary>
        /// 0 = OK; Anything else = Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.  No value returned if retrieval successful.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public long? TrackingNumber { get; set; }
    }
}
