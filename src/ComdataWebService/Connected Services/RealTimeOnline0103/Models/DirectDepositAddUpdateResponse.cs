using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
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
    [MessageContract(WrapperName = "directDepositAddUpdateResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositAddUpdateResponseBody : IResponse //ISoapResponseBody<DirectDepositAddUpdateResponse>
    {
        public DirectDepositAddUpdateResponseBody() : this(new DirectDepositAddUpdateResponse()) { }
        public DirectDepositAddUpdateResponseBody(DirectDepositAddUpdateResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "directDepositAddUpdateReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositAddUpdateResponse Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "directDepositAddUpdateResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class DirectDepositAddUpdateResponseBody
    {
        public DirectDepositAddUpdateResponseBody() : this(new DirectDepositAddUpdateResponse()) { }

        public DirectDepositAddUpdateResponseBody(DirectDepositAddUpdateResponse response)
        {
            this.Response = response;
        }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "directDepositAddUpdateReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public DirectDepositAddUpdateResponse Response { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class DirectDepositAddUpdateResponse  // : ISoapResponse
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
        /// Any discretionary data from the request message (optional). The response will be truncated to 10 characters.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record. (Overrides the tracking number submitted.)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 0=success; All other response codes=error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message should be: OK
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Employee's Customer ID
        /// </summary>
        [XmlElement(ElementName = "employeeCustomerId", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public string? EmployeeCustomerId { get; set; }

        /// <summary>
        /// Employee number assigned to this card
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// A=Add C=Change D=Delete E=Employee Number Change
        /// </summary>
        [XmlElement(ElementName = "functionCode", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public FunctionCodeType? FunctionCode { get; set; }  // string?

        /// <summary>
        /// Numeric value of 1 through 5        
        /// </summary>
        /// <remarks>The default value is 1 for an employee number change</remarks>
        [XmlElement(ElementName = "bankAccountSequence", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public int? BankAccountSequence { get; set; }  // string?

        /// <summary>
        /// Bank routing and transit number
        /// </summary>
        [XmlElement(ElementName = "routingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? RoutingNumber { get; set; }

        /// <summary>
        /// Bank account number
        /// </summary>
        [XmlElement(ElementName = "bankAccountNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? BankAccountNumber { get; set; }

        /// <summary>
        /// Name on the bank account
        /// </summary>
        [XmlElement(ElementName = "accountName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? AccountName { get; set; }

        /// <summary>
        /// Y=Checking account; N=Other/Not a checking account
        /// </summary>
        [XmlElement(ElementName = "checkingAccountFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public CheckingAccountFlagType? CheckingAccountFlag { get; set; }  // string?

        /// <summary>
        /// P=Percent of load amount is sent to ACH; A=Amount is sent to ACH; C = Amount of load kept in Express Cash; the remainder is sent to ACH
        /// </summary>
        [XmlElement(ElementName = "depositType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public DepositType? DepositType { get; set; }  // string?

        /// <summary>
        /// 99999.99
        /// </summary>
        [XmlElement(ElementName = "amountOrPercent", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public Nullable<double> AmountOrPercent { get; set; }

        /// <summary>
        /// Updates the status of the direct deposit account
        /// </summary>
        /// <remarks>A=Activate; B=Block; P=Pending Pre-Note</remarks>
        [XmlElement(ElementName = "status", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public DirectDepositAccountStatusType? Status { get; set; }

        /// <summary>
        /// Card Number assigned to employee
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// First name of cardholder
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of cardholder
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? LastName { get; set; }

        /// <summary>
        /// Date the last pre-note was done, MM/DD/YY
        /// </summary>
        [XmlElement(ElementName = "lastPreNoteDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? LastPreNoteDate { get; set; }

        /// <summary>
        /// Time the last pre-note was done, HH:MM:SS
        /// </summary>
        [XmlElement(ElementName = "lastPreNoteTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? LastPreNoteTime { get; set; }
    }
}
