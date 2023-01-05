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
    /// <summary>
    /// The Express Check Inquiry 1.0 function provides the customer a general purpose inquiry into the status,
    /// properties, and last useage of an Express Check Code.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "expressCheckInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckInquiryResponseBody : IResponse //ISoapResponseBody<ExpressCheckInquiryResponse>
    {
        public ExpressCheckInquiryResponseBody() : this(new ExpressCheckInquiryResponse()) { }
        public ExpressCheckInquiryResponseBody(ExpressCheckInquiryResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "expressCheckInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckInquiryResponse Content { get; set; }
    }



    /// <summary>
    /// The Express Check Inquiry 1.0 function provides the customer a general purpose inquiry into the status,
    /// properties, and last useage of an Express Check Code.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckInquiryResponse  // : ISoapResponse
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
        /// Any discretionary data that the requestor included in the corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// First 10 positions of Driver Number value
        /// </summary>
        [XmlElement(ElementName = "driverNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DriverNumber { get; set; }

        /// <summary>
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "expressCheckAmount", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public double ExpressCheckAmount { get; set; }

        /// <summary>
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "expressCheckBalance", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public double ExpressCheckBalance { get; set; }

        /// <summary>
        /// Full Express Check Code
        /// </summary>
        [XmlElement(ElementName = "expressCheckCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? ExpressCheckCode { get; set; }

        /// <summary>
        /// Valid Amounts 0.01 to 999.99
        /// </summary>
        [XmlElement(ElementName = "expressCheckFee", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public double ExpressCheckFee { get; set; }

        /// <summary>
        /// Fleet ID / Fleet Code
        /// </summary>
        [XmlElement(ElementName = "fleetId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? FleetId { get; set; }

        /// <summary>
        /// City where Express Check code was last used
        /// </summary>
        [XmlElement(ElementName = "lastUseCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? LastUseCity { get; set; }

        /// <summary>
        /// If the code has been used, this value is the date & time of last use.  If the code has not been used, this 
        /// value is the date that the code was retrieved from the Comdata host and the default time of "05:00:00.000".
        /// 
        /// Format: YYYY-MM-DD + "T" + HH:MM:SS:000 + "Z"
        /// </summary>
        /// <example>Example:  2011-03-17T19:59:00.000Z</example>
        [XmlElement(ElementName = "lastUseDateTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public Nullable<System.DateTime> LastUseDateTime { get; set; }

        /// <summary>
        /// Location Code/Merchant Code where code last used.
        /// </summary>
        /// <remarks>'NOUSE' returned if code has not been used yet.</remarks>
        [XmlElement(ElementName = "lastUseLocationCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? LastUseLocationCode { get; set; }

        /// <summary>
        /// Format: [Last Name], [First Name]
        /// </summary>
        [XmlElement(ElementName = "name", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? Name { get; set; }

        /// <summary>
        /// Purpose Code
        /// </summary>
        [XmlElement(ElementName = "purposeCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? PurposeCode { get; set; }

        /// <summary>
        /// 0 = OK; Anything else = Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 14)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.  No value returned if retrieval successful.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// A = Active; B = Blocked; C = Cancelled; U = Used
        /// </summary>
        [XmlElement(ElementName = "status", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public ExpressCheckStatusType? Status { get; set; }  // string?

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 17)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Trip Number
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Unit Number
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "expressCheckInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckInquiryResponseBody : ISoapResponseBody<ExpressCheckInquiryResponse>
    {
        public ExpressCheckInquiryResponseBody() : this(new ExpressCheckInquiryResponse()) { }
        public ExpressCheckInquiryResponseBody(ExpressCheckInquiryResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCheckInquiryReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckInquiryResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "expressCheckInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckInquiryResponseBody
    {
        public ExpressCheckInquiryResponseBody() : this(new ExpressCheckInquiryResponse()) { }

        public ExpressCheckInquiryResponseBody(ExpressCheckInquiryResponse response)
        {
            this.Response = response;
        }




        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCheckInquiryReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckInquiryResponse Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckInquiryResponse : ISoapResponse
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCheckAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public double ExpressCheckAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCheckBalance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public double ExpressCheckBalance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCheckCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? ExpressCheckCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCheckFee", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public double ExpressCheckFee { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fleetId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? FleetId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastUseCity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? LastUseCity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastUseDateTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public System.Nullable<System.DateTime> LastUseDateTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastUseLocationCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? LastUseLocationCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purposeCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? PurposeCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? Status { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? TripNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "unitNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
>>>>>>> releases/v1.0.0
        public string? UnitNumber { get; set; }
    }
}
