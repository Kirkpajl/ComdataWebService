﻿using Comdata.Models.Internals;
using Comdata.RealTimeOnline0103.Enumerations;
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
    [MessageContract(WrapperName = "expressCheckRetrieval", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class ExpressCheckRetrievalRequestBody : IRequest<ExpressCheckRetrievalRequest>
    {
        public ExpressCheckRetrievalRequestBody() : this(new ExpressCheckRetrievalRequest()) { }
        public ExpressCheckRetrievalRequestBody(ExpressCheckRetrievalRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "retrievalRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public ExpressCheckRetrievalRequest Content { get; set; }
    }



    /// <summary>
    /// The Express Check Retrieval 1.0 function allows you to request Express Codes from Comdata. Customer specific
    /// setup within the Comdata host determines which fields are required; contact Comdata for details.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class ExpressCheckRetrievalRequest : IRequest
    {
        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's  is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like
        /// returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Driver Number
        /// </summary>
        [XmlElement(ElementName = "driverNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DriverNumber { get; set; }

        /// <summary>
        /// Receiver First Name
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Fleet ID / Fleet Code
        /// </summary>
        [XmlElement(ElementName = "fleetId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? FleetId { get; set; }

        /// <summary>
        /// Receiver Last Name
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? LastName { get; set; }

        /// <summary>
        /// Merchant Code. Express Check Code must be used at point of first encashment.
        /// </summary>
        [XmlElement(ElementName = "locationCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? LocationCode { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? Password { get; set; }

        /// <summary>
        /// PIN Number
        /// </summary>
        [XmlElement(ElementName = "pin", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? Pin { get; set; }

        /// <summary>
        /// Purpose Code
        /// </summary>
        [XmlElement(ElementName = "purposeCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? PurposeCode { get; set; }

        /// <summary>
        /// Security Code/Codeword value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Trip Number
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Unit Number
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? UnitNumber { get; set; }

        /// <summary>
        /// 1 = Plus Fees; 2 = Less Fees
        /// </summary>
        [XmlElement(ElementName = "plusLessFlag", Form = XmlSchemaForm.Unqualified, Order = 15)]
        public PlusLessFlag PlusLessFlag { get; set; } = PlusLessFlag.PlusFees;  // string?

        /// <summary>
        /// Valid Amounts 0.01 to 9999.99
        /// </summary>
        [XmlElement(ElementName = "amount", Form = XmlSchemaForm.Unqualified, Order = 16)]
        public double Amount { get; set; }

        /// <summary>
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 17)]
        public long? TrackingNumber { get; set; }
    }
}
