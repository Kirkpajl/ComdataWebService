using Comdata.Models.Internals;
using Comdata.RealTimeOnline0103.Enumerations;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Load Money Comchek 1.0 function is used for sending money to registered Comchek Mobile users.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "loadMoneyComchek", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyComchekRequestBody : IRequest<LoadMoneyComchekRequest>
    {
        public LoadMoneyComchekRequestBody() : this(new LoadMoneyComchekRequest()) { }
        public LoadMoneyComchekRequestBody(LoadMoneyComchekRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadComchekRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyComchekRequest Content { get; set; }
    }



    /// <summary>
    /// The Load Money Comchek 1.0 function is used for sending money to registered Comchek Mobile users.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyComchekRequest : IRequest
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
        /// Any discretionary data that the requestor would like returned
        /// in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value
        /// assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? Password { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by
        /// Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by
        /// Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Unique ID assigned to the sender; value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "senderId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SenderId { get; set; }

        /// <summary>
        /// Unique ID assigned to the receiver of the funds; it is the Username of Comchek Mobile user
        /// </summary>
        [XmlElement(ElementName = "receiverId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ReceiverId { get; set; }

        /// <summary>
        /// User Defined Field Label. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>Example: "Invoice number"</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField1Label", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? UdfField1Label { get; set; }

        /// <summary>
        /// User Defined Field Value. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>Example: "Inv123456"</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField1Value", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? UdfField1Value { get; set; }

        /// <summary>
        /// User Defined Field Display. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>"IR" = Display in sender's and receiver's app; "IO" = Display in sender's app only</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField1Display", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public UdfFieldDisplay? UdfField1Display { get; set; }  //string?

        /// <summary>
        /// User Defined Field Label. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>Example: "Invoice number"</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField2Label", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? UdfField2Label { get; set; }

        /// <summary>
        /// User Defined Field Value. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>Example: "Inv123456"</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField2Value", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? UdfField2Value { get; set; }

        /// <summary>
        /// User Defined Field Display. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>"IR" = Display in sender's and receiver's app; "IO" = Display in sender's app only</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField2Display", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public UdfFieldDisplay? UdfField2Display { get; set; }  //string?

        /// <summary>
        /// User Defined Field Label. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>Example: "Invoice number"</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField3Label", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? UdfField3Label { get; set; }

        /// <summary>
        /// User Defined Field Value. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>Example: "Inv123456"</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField3Value", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? UdfField3Value { get; set; }

        /// <summary>
        /// User Defined Field Display. Used for display in Comchek Mobile app.
        /// </summary>
        /// <example>"IR" = Display in sender's and receiver's app; "IO" = Display in sender's app only</example>
        /// <remarks>
        /// Note: If either Label, Value, or Display are populated for one of
        /// the User Defined Field(UDF) sections(1, 2 or 3), then all of the
        /// fields for that UDF set are required.
        /// </remarks>
        [XmlElement(ElementName = "udfField3Display", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public UdfFieldDisplay? UdfField3Display { get; set; }  //string?

        /// <summary>
        /// Any discretionary data that the requestor would like attached
        /// to this load. (optional)
        /// </summary>
        [XmlElement(ElementName = "miscellaneousData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? MiscellaneousData { get; set; }

        /// <summary>
        /// Minimum .01 Maximum 99999.99
        /// </summary>
        [XmlElement(ElementName = "loadAmount", Form = XmlSchemaForm.Unqualified, Order = 18)]
        public double LoadAmount { get; set; }

        /// <summary>
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 19)]
        public long? TrackingNumber { get; set; }  // <-- Not included in XML Schema
    }
}
