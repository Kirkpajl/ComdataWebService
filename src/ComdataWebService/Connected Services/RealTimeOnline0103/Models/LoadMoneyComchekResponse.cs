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
using static System.Collections.Specialized.BitVector32;
using System.Numerics;
using System.Security.Policy;
using System.Security.Principal;
using System.Threading;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Load Money Comchek 1.0 function is used for sending money to registered Comchek Mobile users.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "loadMoneyComchekResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyComchekResponseBody : IResponse //ISoapResponseBody<LoadMoneyComchekResponse>
    {
        public LoadMoneyComchekResponseBody() : this(new LoadMoneyComchekResponse()) { }
        public LoadMoneyComchekResponseBody(LoadMoneyComchekResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadMoneyComchekReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyComchekResponse Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "loadMoneyComchekResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "loadMoneyComchekResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyComchekResponseBody : ISoapResponseBody<LoadMoneyComchekResponse>
    {
        public LoadMoneyComchekResponseBody() : this(new LoadMoneyComchekResponse()) { }
        public LoadMoneyComchekResponseBody(LoadMoneyComchekResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "loadMoneyComchekReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyComchekResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "loadMoneyComchekResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
>>>>>>> releases/v1.0.0
    public partial class LoadMoneyComchekResponseBody
    {
        public LoadMoneyComchekResponseBody() : this(new LoadMoneyComchekResponse()) { }

        public LoadMoneyComchekResponseBody(LoadMoneyComchekResponse response)
        {
            this.Response = response;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadMoneyComchekReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "loadMoneyComchekReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public LoadMoneyComchekResponse Response { get; set; }
    }*/



<<<<<<< HEAD
    /// <summary>
    /// The Load Money Comchek 1.0 function is used for sending money to registered Comchek Mobile users.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyComchekResponse  // : ISoapResponse
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
=======
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyComchekResponse : ISoapResponse
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "loadAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public double LoadAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "charges", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public double Charges { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "referenceNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
>>>>>>> releases/v1.0.0
        public long ReferenceNumber { get; set; }
    }
}
