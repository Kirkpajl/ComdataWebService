using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

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
        public string? UnitNumber { get; set; }
    }
}
