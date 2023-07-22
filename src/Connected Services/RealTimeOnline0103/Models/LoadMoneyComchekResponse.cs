using Comdata.Models.Internals;
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
    [MessageContract(WrapperName = "loadMoneyComchekResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyComchekResponseBody : IResponse<LoadMoneyComchekResponse>
    {
        public LoadMoneyComchekResponseBody() : this(new LoadMoneyComchekResponse()) { }
        public LoadMoneyComchekResponseBody(LoadMoneyComchekResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadMoneyComchekReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyComchekResponse Content { get; set; }
    }



    /// <summary>
    /// The Load Money Comchek 1.0 function is used for sending money to registered Comchek Mobile users.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyComchekResponse : IResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata.  (4 digit Customer Id's will
        /// include leading zero)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the
        /// corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// 0=Load Successful Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.
        /// No value returned if load successful.
        /// </summary>
        /// <remarks>
        /// Common errors:
        /// 
        /// Response Code: 01391
        /// Response Message: Load Amt Exceeded on Carrier
        /// 
        /// Response Code: 01440
        /// Response Message: Comchek Card Balance Max Exceeded
        /// 
        /// Response Code: 32639
        /// Response Message: If you populate the Label, Value, or Display
        /// fields for one of the User Defined Field(UDF) sections(1, 2 or 3),
        /// then all of the fields for that UDF section are required.
        /// 
        /// In the event of other errors, please contact your Comdata account
        /// representative.
        /// </remarks>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// 99999.99, 0.0 returned if load unsuccessful.
        /// </summary>
        [XmlElement(ElementName = "loadAmount", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public double LoadAmount { get; set; }

        /// <summary>
        /// 99999.99, 0.0 returned if load unsuccessful.
        /// </summary>
        [XmlElement(ElementName = "charges", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public double Charges { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// (Overrides the tracking number submitted.)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Reference Number issued by Comdata if load successful.
        /// 0=Load was not completed as requested.
        /// </summary>
        [XmlElement(ElementName = "referenceNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public long ReferenceNumber { get; set; }
    }
}
