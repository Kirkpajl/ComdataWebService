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
=======

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
>>>>>>> releases/v1.0.0
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
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackCardShipmentReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public TrackCardShipmentResponse Response { get; set; }
    }*/



    /// <remarks/>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class TrackCardShipmentResponse  // : ISoapResponse
    {
        /// <remarks/>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public int? ResponseCode { get; set; }  //public string? ResponseCode { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [XmlArray(ElementName = "arrayOfTrackCardShipment", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        [XmlArrayItem("trackCardShipment", Form = XmlSchemaForm.Unqualified)]
=======
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
>>>>>>> releases/v1.0.0
        public TrackCardShipment[]? ArrayOfTrackCardShipment { get; set; }
    }
}
