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
    [MessageContract(WrapperName = "trackCardShipmentResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TrackCardShipmentResponseBody : IResponse //ISoapResponseBody<TrackCardShipmentResponse>
    {
        public TrackCardShipmentResponseBody() : this(new TrackCardShipmentResponse()) { }
        public TrackCardShipmentResponseBody(TrackCardShipmentResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "trackCardShipmentReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public TrackCardShipmentResponse Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "trackCardShipmentResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TrackCardShipmentResponseBody
    {
        public TrackCardShipmentResponseBody() : this(new TrackCardShipmentResponse()) { }

        public TrackCardShipmentResponseBody(TrackCardShipmentResponse response)
        {
            this.Response = response;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "trackCardShipmentReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElementAttribute(ElementName = "trackCardShipmentReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public TrackCardShipmentResponse Response { get; set; }
    }*/



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class TrackCardShipmentResponse  // : ISoapResponse
    {
        /// <remarks/>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public int ResponseCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string ResponseMessage { get; set; } = string.Empty;

        /// <remarks/>
        [XmlArray(ElementName = "arrayOfTrackCardShipment", Form = XmlSchemaForm.Unqualified, Order = 2)]
        [XmlArrayItem("trackCardShipment", Form = XmlSchemaForm.Unqualified)]
        public TrackCardShipment[] TrackCardShipments { get; set; } = Array.Empty<TrackCardShipment>();
    }
}
