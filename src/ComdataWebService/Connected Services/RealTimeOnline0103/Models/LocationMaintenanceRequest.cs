using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "locationMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LocationMaintenanceRequestBody : ISoapRequestBody<LocationMaintenanceRequest>
    {
        public LocationMaintenanceRequestBody() : this(new LocationMaintenanceRequest()) { }
        public LocationMaintenanceRequestBody(LocationMaintenanceRequest request) { Request = request; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationMaintenanceRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LocationMaintenanceRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "locationMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LocationMaintenanceRequestBody
    {
        public LocationMaintenanceRequestBody() : this(new LocationMaintenanceRequest()) { }

        public LocationMaintenanceRequestBody(LocationMaintenanceRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationMaintenanceRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public LocationMaintenanceRequest Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class LocationMaintenanceRequest : ISoapRequest
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? LocationCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LocationType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "networkFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string? NetworkFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fuelAllowedFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string? FuelAllowedFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilAllowedFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string? OilAllowedFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashAllowedFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string? CashAllowedFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxOneTwoQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public int MaxOneTwoQuantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "products", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        [System.Xml.Serialization.XmlArrayItemAttribute("productElement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public ProductElement[]? Products { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxReeferQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public System.Nullable<int> MaxReeferQuantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxOtherQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public System.Nullable<int> MaxOtherQuantity { get; set; }
    }
}
