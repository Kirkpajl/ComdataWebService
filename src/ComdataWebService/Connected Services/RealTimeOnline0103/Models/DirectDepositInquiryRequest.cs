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
    [MessageContract(WrapperName = "directDepositInquiry", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositInquiryRequestBody : IRequest  //ISoapRequestBody<DirectDepositInquiryRequest>
    {
        public DirectDepositInquiryRequestBody() : this(new DirectDepositInquiryRequest()) { }
        public DirectDepositInquiryRequestBody(DirectDepositInquiryRequest request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "directDepositInquiryRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositInquiryRequest Request { get; set; }
    }



    /// <summary>
    /// The Direct Deposit Inquiry request is used to inquire into the direct deposit information set up for an employee.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class DirectDepositInquiryRequest// : ISoapRequest
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID under which the card was assigned
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data (optional). Will be truncated to 10 characters.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Any number
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public string? Password { get; set; }

        /// <summary>
        /// Customer ID of the employee with the direct deposit account
        /// </summary>
        [XmlElement(ElementName = "employeeCustomerId", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public string? EmployeeCustomerId { get; set; }

        /// <summary>
        /// 560017 + Card Number
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Employee number assigned to this card
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public string? EmployeeNumber { get; set; }
    }
}
