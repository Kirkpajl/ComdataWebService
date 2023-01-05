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
    /// Adds, updates (replace), or deletes records tied to a card number for customers using the limited network feature.You can enable a one-time purchase at any
    /// location code by not specifying a location code.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "limitedNetworkByCardUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LimitedNetworkByCardUpdateRequestBody : IRequest  //ISoapRequestBody<LimitedNetworkByCardUpdateRequest>
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "limitedNetworkByCardUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LimitedNetworkByCardUpdateRequestBody : ISoapRequestBody<LimitedNetworkByCardUpdateRequest>
>>>>>>> releases/v1.0.0
    {
        public LimitedNetworkByCardUpdateRequestBody() : this(new LimitedNetworkByCardUpdateRequest()) { }
        public LimitedNetworkByCardUpdateRequestBody(LimitedNetworkByCardUpdateRequest request) { Request = request; }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "limitedRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LimitedNetworkByCardUpdateRequest Request { get; set; }
    }



    /// <summary>
    /// Adds, updates (replace), or deletes records tied to a card number for customers using the limited network feature.You can enable a one-time purchase at any
    /// location code by not specifying a location code.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LimitedNetworkByCardUpdateRequest// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Use the 10-digit truncated card number. (BIN omitted).
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit CustomerId's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? Password { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Any Number
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Merchant code for the station.
        /// </summary>
        [XmlElement(ElementName = "locationCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LocationCode { get; set; }

        /// <summary>
        /// Valid values between 0 and 99999.99. A value exceeding this amount will be converted to 99999.99.
        /// Negative values are treated as the equivalent positive value. A zero is treated as no limit (converted to 99999.99).
        /// </summary>
        [XmlElement(ElementName = "maxNum1Num2Quantity", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public double MaxNum1Num2Quantity { get; set; }

        /// <summary>
        /// Maximum reefer gallons. Valid values between 0 and 999.99. Negative values are treated as the equivalent
        /// positive value.A zero is treated as no limit (converted to 999.99).
        /// </summary>
        [XmlElement(ElementName = "maxReeferQuantity", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public double MaxReeferQuantity { get; set; }

        /// <summary>
        /// Valid values between 0 and 99999.99. A value exceeding this amount will be converted to 99999.99.
        /// Negative values are treated as the equivalent positive value. A zero is treated as no limit (converted to
        /// 99999.99).
        /// </summary>
        [XmlElement(ElementName = "maxProdPurchases", Form = XmlSchemaForm.Unqualified, Order = 11)]
        public double MaxProdPurchases { get; set; }

        /// <summary>
        /// Maximum other fuel type gallons. alid values between 0 and 999.99. Negative values are treated as the
        /// equivalent positive value.A zero is treated as no limit (converted to 999.99).
        /// </summary>
        [XmlElement(ElementName = "maxOtherQuantity", Form = XmlSchemaForm.Unqualified, Order = 12)]
        public double MaxOtherQuantity { get; set; }

        /// <summary>
        /// Valid values between 0 and 99999.99. The maximum value permitted by Comdata is 9999.99; a higher
        /// value will be converted to 9999.99 on the mainframe. A negative value is converted to a positive value. A
        /// zero is treated as no limit and is converted to 9999.99 on the mainframe.
        /// </summary>
        [XmlElement(ElementName = "maxCashAdvance", Form = XmlSchemaForm.Unqualified, Order = 13)]
        public double MaxCashAdvance { get; set; }

        /// <summary>
        /// MMDDYY
        /// </summary>
        /// <remarks>
        /// An invalid date returns an error.
        /// An expired date returns an error.
        /// </remarks>
        [XmlElement(ElementName = "expirationDateMMDDYY", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? ExpirationDateMMDDYY { get; set; }

        /// <summary>
        /// HHMM
        /// </summary>
        /// <remarks>Must be a valid hour (24 or less) and minute.</remarks>
        [XmlElement(ElementName = "expirationTimeHHMM", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? ExpirationTimeHHMM { get; set; }

        /// <summary>
        /// D = Delete; R = Replace; No value or any value other than D or R is treated as an add request.
        /// </summary>
        [XmlElement(ElementName = "deleteReplaceFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public DeleteReplaceFlag? DeleteReplaceFlag { get; set; }  //string?
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LimitedNetworkByCardUpdateRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "limitedNetworkByCardUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LimitedNetworkByCardUpdateRequestBody
    {
        public LimitedNetworkByCardUpdateRequestBody() : this(new LimitedNetworkByCardUpdateRequest()) { }

        public LimitedNetworkByCardUpdateRequestBody(LimitedNetworkByCardUpdateRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "limitedRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LimitedNetworkByCardUpdateRequest Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class LimitedNetworkByCardUpdateRequest : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LocationCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxNum1Num2Quantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public double MaxNum1Num2Quantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxReeferQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public double MaxReeferQuantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxProdPurchases", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public double MaxProdPurchases { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxOtherQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public double MaxOtherQuantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxCashAdvance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public double MaxCashAdvance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expirationDateMMDDYY", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? ExpirationDateMMDDYY { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expirationTimeHHMM", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? ExpirationTimeHHMM { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "deleteReplaceFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? DeleteReplaceFlag { get; set; }
>>>>>>> releases/v1.0.0
    }
}
