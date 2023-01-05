using Comdata.RealTimeOnline0103.Enumerations;
using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
<<<<<<< HEAD
using System.Diagnostics;
using System.ServiceModel;
using System.CodeDom.Compiler;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "loadMoneyResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyResponseBody : IResponse //ISoapResponseBody<LoadMoneyResponse>
    {
        public LoadMoneyResponseBody() : this(new LoadMoneyResponse()) { }
        public LoadMoneyResponseBody(LoadMoneyResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadMoneyReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyResponse Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "loadMoneyResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "loadMoneyResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LoadMoneyResponseBody : ISoapResponseBody<LoadMoneyResponse>
    {
        public LoadMoneyResponseBody() : this(new LoadMoneyResponse()) { }
        public LoadMoneyResponseBody(LoadMoneyResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "loadMoneyReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "loadMoneyResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
>>>>>>> releases/v1.0.0
    public partial class LoadMoneyResponseBody
    {
        public LoadMoneyResponseBody() : this(new LoadMoneyResponse()) { }

        public LoadMoneyResponseBody(LoadMoneyResponse response)
        {
            this.Response = response;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
>>>>>>> releases/v1.0.0
        [XmlElement(ElementName = "loadMoneyReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LoadMoneyResponse Response { get; set; }
    }*/



    /// <summary>
    /// Response Record Express Cash Load Money 1.0
    /// </summary>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyResponse  // : ISoapResponse
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class LoadMoneyResponse : ISoapResponse
>>>>>>> releases/v1.0.0
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// A=Add S=Subtract
        /// No value returned if load unsuccessful.
        /// </summary>
        [XmlElement(ElementName = "addSubtractFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public Nullable<LoadMoneyAddSubtractFlag> AddSubtractFlag { get; set; }

        /// <summary>
        /// 999999.99 to -999999.99
        /// 0.0 returned if load unsuccessful.
        /// </summary>
        [XmlElement(ElementName = "cardBalance", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public double CardBalance { get; set; }

        /// <summary>
        /// 999999.99 to -999999.99
        /// 0.0 returned if load unsuccessful or Direct Deposit=False
        /// </summary>
        [XmlElement(ElementName = "cardBalanceAfterDepositPosted", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public double CardBalanceAfterDepositPosted { get; set; }

        /// <summary>
        /// 99999.99
        /// 0.0 returned if load unsuccessful.
        /// </summary>
        [XmlElement(ElementName = "charges", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public double Charges { get; set; }

        /// <summary>
        /// Value assigned by Comdata.  (4 digit Customer Id's will
        /// include leading zero)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the
        /// corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// 99999.99
        /// 0.0 returned if load unsuccessful.
        /// </summary>
        [XmlElement(ElementName = "loadAmount", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public double LoadAmount { get; set; }

        /// <summary>
        /// 1=Plus Fees (Full Load Amt applied to Card Balance)
        /// 2=Less Fees(Load Amt less Fees applied to Card Balance)
        /// No value returned if load unsuccessful.
        /// </summary>
        [XmlElement(ElementName = "plusLessFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public Nullable<LoadMoneyResponsePlusLessFlag> PlusLessFlag { get; set; }

        /// <summary>
        /// Reference Number issued by Comdata if load successful.
        /// 0=Load was not completed as requested.  Refer to
        /// responseCode and responseMessage for explanation.
        /// </summary>
        [XmlElement(ElementName = "referenceNumber", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public long ReferenceNumber { get; set; }

        /// <summary>
        /// 0=Load Successful Anything Else=Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.
        /// No value returned if load successful.
        /// 
        /// Note:  Erroneous 'UNABLE TO PARSE HOST RESPONSE'
        /// message returned when availableDateTime functionality
        /// used.  Refer to responseCode for true response.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// (Overrides the tracking number submitted.)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 12)]
        public long? TrackingNumber { get; set; }
    }
}
