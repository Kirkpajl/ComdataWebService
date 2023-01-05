using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "trackCardShipmentResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TrackCardShipmentResponseBody : ISoapResponseBody<TrackCardShipmentResponse>
    {
        public TrackCardShipmentResponseBody() : this(new TrackCardShipmentResponse()) { }
        public TrackCardShipmentResponseBody(TrackCardShipmentResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackCardShipmentReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public TrackCardShipmentResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "trackCardShipmentResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class TrackCardShipmentResponseBody
    {
        public TrackCardShipmentResponseBody() : this(new TrackCardShipmentResponse()) { }

        public TrackCardShipmentResponseBody(TrackCardShipmentResponse response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackCardShipmentReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public TrackCardShipmentResponse Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class TrackCardShipmentResponse : ISoapResponse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int? ResponseCode { get; set; }  //public string? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "arrayOfTrackCardShipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("trackCardShipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TrackCardShipment[]? ArrayOfTrackCardShipment { get; set; }
    }
}
