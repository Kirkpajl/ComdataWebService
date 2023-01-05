using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "trackCardShipmentStatus", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TrackCardShipmentRequestBody : IRequest  //ISoapRequestBody<TrackCardShipmentRequest>
    {
        public TrackCardShipmentRequestBody() : this(new TrackCardShipmentRequest()) { }
        public TrackCardShipmentRequestBody(TrackCardShipmentRequest request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "trackCardShipmentRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public TrackCardShipmentRequest Request { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "trackCardShipmentStatus", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TrackCardShipmentRequestBody
    {
        public TrackCardShipmentRequestBody() : this(new TrackCardShipmentRequest()) { }

        public TrackCardShipmentRequestBody(TrackCardShipmentRequest request)
        {
            this.Request = request;
        }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "trackCardShipmentRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public TrackCardShipmentRequest Request { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class TrackCardShipmentRequest// : ISoapRequest
    {
        /// <remarks/>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? Password { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "dateType", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public string? DateType { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "startDate", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public string? StartDate { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "endDate", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public string? EndDate { get; set; }
    }
}
