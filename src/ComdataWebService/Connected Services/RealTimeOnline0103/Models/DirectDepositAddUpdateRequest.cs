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
using Comdata.RealTimeOnline0103.Enumerations;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "directDepositAddUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositAddUpdateRequestBody : IRequest  //ISoapRequestBody<DirectDepositAddUpdateRequest>
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "directDepositAddUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositAddUpdateRequestBody : ISoapRequestBody<DirectDepositAddUpdateRequest>
>>>>>>> releases/v1.0.0
    {
        public DirectDepositAddUpdateRequestBody() : this(new DirectDepositAddUpdateRequest()) { }
        public DirectDepositAddUpdateRequestBody(DirectDepositAddUpdateRequest request) { Request = request; }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "directDepositAddUpdateRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositAddUpdateRequest Request { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "directDepositAddUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "directDepositAddUpdateRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositAddUpdateRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "directDepositAddUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
>>>>>>> releases/v1.0.0
    public partial class DirectDepositAddUpdateRequestBody
    {
        public DirectDepositAddUpdateRequestBody() : this(new DirectDepositAddUpdateRequest()) { }

        public DirectDepositAddUpdateRequestBody(DirectDepositAddUpdateRequest request)
        {
            this.Request = request;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "directDepositAddUpdateRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "directDepositAddUpdateRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public DirectDepositAddUpdateRequest Request { get; set; }
    }*/



    /// <remarks/>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class DirectDepositAddUpdateRequest// : ISoapRequest
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
        /// Must be a secure card for real-time processing. Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? Password { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Any discretionary data (optional). Will be truncated to 10 characters.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Any number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Employee's Customer ID
        /// </summary>
        [XmlElement(ElementName = "employeeCustomerId", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public string? EmployeeCustomerId { get; set; }

        /// <summary>
        /// 560017 + Card Number
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Employee number assigned to the card
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// A=Add; C=Change; D=Delete; E=Employee Number Change
        /// </summary>
        /// <remarks>
        /// Note: If you delete an ACH entry, it will have to be added and Pre-Noted
        /// </remarks>
        [XmlElement(ElementName = "functionCode", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public FunctionCodeType FunctionCode { get; set; }  // string?

        /// <summary>
        /// New employee number        
        /// </summary>
        /// <remarks>
        /// Note: If the New Employee Number field is already populated, only the Employee Number will be updated.
        /// </remarks>
        [XmlElement(ElementName = "newEmployeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? NewEmployeeNumber { get; set; }

        /// <summary>
        /// Numeric value of 1 through 5        
        /// </summary>
        /// <remarks>
        /// The default value is 1 for an employee number change
        /// </remarks>
        [XmlElement(ElementName = "bankAccountSequence", Form = XmlSchemaForm.Unqualified, Order = 11)]
        public int BankAccountSequence { get; set; } = 1;  // string?

        /// <summary>
        /// Bank routing and transit number
        /// </summary>
        [XmlElement(ElementName = "routingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? RoutingNumber { get; set; }

        /// <summary>
        /// Bank account number
        /// </summary>
        [XmlElement(ElementName = "bankAccountNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? BankAccountNumber { get; set; }

        /// <summary>
        /// Name on the bank account
        /// </summary>
        [XmlElement(ElementName = "accountName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? AccountName { get; set; }

        /// <summary>
        /// Y=Checking account; N=Other/Not a checking account
        /// </summary>
        [XmlElement(ElementName = "checkingAccountFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public CheckingAccountFlagType? CheckingAccountFlag { get; set; }  // string?

        /// <summary>
        /// P=Percent of load amount is sent to ACH; A=Amount is sent to ACH; C = Amount of load kept in Express Cash; the remainder is sent to ACH
        /// </summary>
        [XmlElement(ElementName = "depositType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public DepositType? DepositType { get; set; }  // string?

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "amountOrPercent", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public Nullable<double> AmountOrPercent { get; set; }

        /// <summary>
        /// Updates the status of the direct deposit account
        /// </summary>
        /// <remarks>A=Activate; B=Block</remarks>
        [XmlElement(ElementName = "status", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public DirectDepositAccountStatusType? Status { get; set; }  // string?
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class DirectDepositAddUpdateRequest : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeCustomerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string? EmployeeCustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string? EmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "functionCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string? FunctionCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "newEmployeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? NewEmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bankAccountSequence", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string? BankAccountSequence { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "routingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? RoutingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bankAccountNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? BankAccountNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? AccountName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "checkingAccountFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? CheckingAccountFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "depositType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? DepositType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amountOrPercent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public System.Nullable<double> AmountOrPercent { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? Status { get; set; }
>>>>>>> releases/v1.0.0
    }
}
