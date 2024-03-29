﻿using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Express Check Retrieval 1.0 function allows you to request Express Codes from Comdata. Customer specific
    /// setup within the Comdata host determines which fields are required; contact Comdata for details.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "expressCheckRetrievalResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckRetrievalResponseBody : IResponse<ExpressCheckRetrievalResponse>
    {
        public ExpressCheckRetrievalResponseBody() : this(new ExpressCheckRetrievalResponse()) { }
        public ExpressCheckRetrievalResponseBody(ExpressCheckRetrievalResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "expressCheckRetrievalReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckRetrievalResponse Content { get; set; }
    }



    /// <summary>
    /// The Express Check Retrieval 1.0 function allows you to request Express Codes from Comdata. Customer specific
    /// setup within the Comdata host determines which fields are required; contact Comdata for details.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckRetrievalResponse : IResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 9999.99
        /// </summary>
        /// <remarks>"0.0" returned if Retrieval Unsuccessful</remarks>
        [XmlElement(ElementName = "codeAmount", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public double CodeAmount { get; set; }

        /// <summary>
        /// 999.99
        /// </summary>
        [XmlElement(ElementName = "codeFee", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public double CodeFee { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's  is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Valid Express Check Code
        /// </summary>
        [XmlElement(ElementName = "expressCheckNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ExpressCheckNumber { get; set; }

        /// <summary>
        /// 0 = OK; Anything else = Error
        /// </summary>
        /// <remarks>"0" returned if Express Check code retrieved successfully.</remarks>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.        
        /// </summary>
        /// <remarks>No value returned if retrieval successful.</remarks>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public long? TrackingNumber { get; set; }
    }
}
