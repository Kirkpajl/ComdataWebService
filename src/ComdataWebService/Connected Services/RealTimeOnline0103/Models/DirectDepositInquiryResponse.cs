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
    [MessageContract(WrapperName = "directDepositInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositInquiryResponseBody : IResponse //ISoapResponseBody<DirectDepositInquiryResponse>
    {
        public DirectDepositInquiryResponseBody() : this(new DirectDepositInquiryResponse()) { }
        public DirectDepositInquiryResponseBody(DirectDepositInquiryResponse content) { Content = content; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "directDepositInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositInquiryResponse Content { get; set; }
    }



    /// <summary>
    /// The Direct Deposit Inquiry request is used to inquire into the direct deposit information set up for an employee.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class DirectDepositInquiryResponse  // : ISoapResponse
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
        /// Any discretionary data from the request message (optional).
        /// The response will be truncated to 10 characters.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// (Overrides the tracking number submitted.)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 0=success 
        /// All other response codes=error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message should be: OK
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Customer ID of the employee with the direct deposit account
        /// </summary>
        [XmlElement(ElementName = "employeeCustomerId", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public string? EmployeeCustomerId { get; set; }

        /// <summary>
        /// Employee number assigned to this card
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Card number assigned to employee
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// First name of cardholder
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of cardholder
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? LastName { get; set; }

        /// <summary>
        /// Bank Accounts associated with employee
        /// </summary>
        [XmlArray(ElementName = "ArrayOfDirectDeposits", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        [XmlArrayItem("directDeposits", Form = XmlSchemaForm.Unqualified)]
        public BankAccountRecord[]? BankAccounts { get; set; }
    }
}
