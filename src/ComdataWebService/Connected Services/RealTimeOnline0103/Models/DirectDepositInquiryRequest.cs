using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "directDepositInquiry", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositInquiryRequestBody : ISoapRequestBody<DirectDepositInquiryRequest>
    {
        public DirectDepositInquiryRequestBody() : this(new DirectDepositInquiryRequest()) { }
        public DirectDepositInquiryRequestBody(DirectDepositInquiryRequest request) { Request = request; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "directDepositInquiryRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositInquiryRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "directDepositInquiry", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositInquiryRequestBody
    {
        public DirectDepositInquiryRequestBody() : this(new DirectDepositInquiryRequest()) { }

        public DirectDepositInquiryRequestBody(DirectDepositInquiryRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "directDepositInquiryRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositInquiryRequest Request { get; set; }
    }*/



    /// <summary>
    /// Request Record - Direct Deposit Inquiry
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class DirectDepositInquiryRequest : ISoapRequest
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
        /// Any discretionary data (optional). Will be truncated to 10 characters.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Any number
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string? Password { get; set; }

        /// <summary>
        /// Customer ID of the employee with the direct deposit account
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeCustomerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string? EmployeeCustomerId { get; set; }

        /// <summary>
        /// 560017 + Card Number
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Employee number assigned to this card
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string? EmployeeNumber { get; set; }
    }
}
