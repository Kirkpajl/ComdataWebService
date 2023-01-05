using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
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
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "directDepositInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositInquiryResponseBody : ISoapResponseBody<DirectDepositInquiryResponse>
    {
        public DirectDepositInquiryResponseBody() : this(new DirectDepositInquiryResponse()) { }
        public DirectDepositInquiryResponseBody(DirectDepositInquiryResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "directDepositInquiryReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositInquiryResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "directDepositInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositInquiryResponseBody
    {
        public DirectDepositInquiryResponseBody() : this(new DirectDepositInquiryResponse()) { }

        public DirectDepositInquiryResponseBody(DirectDepositInquiryResponse response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "directDepositInquiryReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositInquiryResponse Response { get; set; }
    }*/



    /// <summary>
    /// Response Record - Direct Deposit Inquiry
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class DirectDepositInquiryResponse : ISoapResponse
>>>>>>> releases/v1.0.0
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
>>>>>>> releases/v1.0.0
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID under which the card was assigned
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
>>>>>>> releases/v1.0.0
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data from the request message (optional).
        /// The response will be truncated to 10 characters.
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, Order = 2)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
>>>>>>> releases/v1.0.0
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// (Overrides the tracking number submitted.)
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 3)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
>>>>>>> releases/v1.0.0
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 0=success 
        /// All other response codes=error
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 4)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
>>>>>>> releases/v1.0.0
        public int? ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message should be: OK
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Customer ID of the employee with the direct deposit account
        /// </summary>
        [XmlElement(ElementName = "employeeCustomerId", Form = XmlSchemaForm.Unqualified, Order = 6)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeCustomerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
>>>>>>> releases/v1.0.0
        public string? EmployeeCustomerId { get; set; }

        /// <summary>
        /// Employee number assigned to this card
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, Order = 7)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
>>>>>>> releases/v1.0.0
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Card number assigned to employee
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
>>>>>>> releases/v1.0.0
        public string? CardNumber { get; set; }

        /// <summary>
        /// First name of cardholder
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
>>>>>>> releases/v1.0.0
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of cardholder
        /// </summary>
<<<<<<< HEAD
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
=======
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
>>>>>>> releases/v1.0.0
        public string? LastName { get; set; }

        /// <summary>
        /// Bank Accounts associated with employee
        /// </summary>
<<<<<<< HEAD
        [XmlArray(ElementName = "ArrayOfDirectDeposits", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        [XmlArrayItem("directDeposits", Form = XmlSchemaForm.Unqualified)]
=======
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "ArrayOfDirectDeposits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("directDeposits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
>>>>>>> releases/v1.0.0
        public BankAccountRecord[]? BankAccounts { get; set; }
    }
}
