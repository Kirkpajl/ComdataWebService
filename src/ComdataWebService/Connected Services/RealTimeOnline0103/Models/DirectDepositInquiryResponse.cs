using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

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
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID under which the card was assigned
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data from the request message (optional).
        /// The response will be truncated to 10 characters.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// (Overrides the tracking number submitted.)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 0=success 
        /// All other response codes=error
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message should be: OK
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeCustomerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string? EmployeeCustomerId { get; set; }

        /// <summary>
        /// Employee number assigned to this card
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Card number assigned to employee
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// First name of cardholder
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of cardholder
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? LastName { get; set; }

        /// <summary>
        /// Bank Accounts associated with employee
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "ArrayOfDirectDeposits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("directDeposits", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccountRecord[]? BankAccounts { get; set; }
    }
}
