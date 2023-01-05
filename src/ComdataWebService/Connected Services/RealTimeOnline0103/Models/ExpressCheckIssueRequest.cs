﻿using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System.Reflection.Emit;
using System.Drawing;
using Comdata.RealTimeOnline0103.Enumerations;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Express Check Issue 1.0 function should be used by customers who have established internal processes in
    /// adherence to Comdata's Express Check Code Calculation Instructions (provided separately upon request) to
    /// calculate their own Express Check codes.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "expressCheckIssue", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckIssueRequestBody : IRequest  //ISoapRequestBody<ExpressCheckIssueRequest>
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "expressCheckIssue", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckIssueRequestBody : ISoapRequestBody<ExpressCheckIssueRequest>
>>>>>>> releases/v1.0.0
    {
        public ExpressCheckIssueRequestBody() : this(new ExpressCheckIssueRequest()) { }
        public ExpressCheckIssueRequestBody(ExpressCheckIssueRequest request) { Request = request; }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "issueRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckIssueRequest Request { get; set; }
    }



    /// <summary>
    /// The Express Check Issue 1.0 function should be used by customers who have established internal processes in
    /// adherence to Comdata's Express Check Code Calculation Instructions (provided separately upon request) to
    /// calculate their own Express Check codes.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckIssueRequest// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Customer
        /// </summary>
        [XmlElement(ElementName = "driverNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DriverNumber { get; set; }

        /// <summary>
        /// Full Express Check Code
        /// </summary>
        [XmlElement(ElementName = "expressCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ExpressCode { get; set; }

        /// <summary>
        /// Receiver First Name
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Fleet ID / Fleet Code
        /// </summary>
        [XmlElement(ElementName = "fleetId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? FleetId { get; set; }

        /// <summary>
        /// Receiver Last Name
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? LastName { get; set; }

        /// <summary>
        /// Merchant Code. Express Check Code must be used at point of first encashment.
        /// </summary>
        [XmlElement(ElementName = "locationCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LocationCode { get; set; }

        /// <summary>
        /// Must be a secure card or codeword for realtime processing.  Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? Password { get; set; }

        /// <summary>
        /// PIN Number
        /// </summary>
        [XmlElement(ElementName = "pin", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? Pin { get; set; }

        /// <summary>
        /// Purpose Code
        /// </summary>
        [XmlElement(ElementName = "purposeCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? PurposeCode { get; set; }

        /// <summary>
        /// Security Code/Codeword value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Trip Number
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Unit Number
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? UnitNumber { get; set; }

        /// <summary>
        /// 1 = Plus Fees; 2 = Less Fees
        /// </summary>
        [XmlElement(ElementName = "plusLessFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public PlusLessFlag PlusLessFlag { get; set; }  // string?

        /// <summary>
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "amount", Form = XmlSchemaForm.Unqualified, Order = 17)]
        public double Amount { get; set; }

        /// <summary>
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 18)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "issueRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckIssueRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "expressCheckIssue", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckIssueRequestBody
    {
        public ExpressCheckIssueRequestBody() : this(new ExpressCheckIssueRequest()) { }

        public ExpressCheckIssueRequestBody(ExpressCheckIssueRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "issueRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckIssueRequest Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckIssueRequest : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DriverNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ExpressCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? FirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fleetId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? FleetId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? LastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LocationCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? Pin { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purposeCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? PurposeCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? TripNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "unitNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? UnitNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "plusLessFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? PlusLessFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public double Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
>>>>>>> releases/v1.0.0
        public long? TrackingNumber { get; set; }
    }
}
