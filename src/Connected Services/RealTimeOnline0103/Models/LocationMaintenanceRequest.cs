using Comdata.Models.Internals;
using Comdata.RealTimeOnline0103.Enumerations;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "locationMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class LocationMaintenanceRequestBody : IRequest<LocationMaintenanceRequest>
    {
        public LocationMaintenanceRequestBody() : this(new LocationMaintenanceRequest()) { }
        public LocationMaintenanceRequestBody(LocationMaintenanceRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "locationMaintenanceRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public LocationMaintenanceRequest Content { get; set; }
    }



    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class LocationMaintenanceRequest : IRequest
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID under which the card was assigned
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data (optional). Will be truncated to 10 characters.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Any number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 560017 + Card Number
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing.  Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? Password { get; set; }

        /// <summary>
        /// The account code of the cards
        /// </summary>
        [XmlElement(ElementName = "locationCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? LocationCode { get; set; }

        /// <summary>
        /// 0= Service Center; 1=Chain; 2=Corp
        /// </summary>
        [XmlElement(ElementName = "locationType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public LocationType? LocationType { get; set; }  // string?

        /// <summary>
        /// 0=One Time; O=Open; C=Close or blank
        /// </summary>
        [XmlElement(ElementName = "networkFlag", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public NetworkFlag? NetworkFlag { get; set; }  // string?

        /// <remarks/>
        [XmlElement(ElementName = "fuelAllowedFlag", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public YesNo10Flag? FuelAllowedFlag { get; set; }  // string?

        /// <remarks/>
        [XmlElement(ElementName = "oilAllowedFlag", Form = XmlSchemaForm.Unqualified, Order = 11)]
        public YesNo10Flag? OilAllowedFlag { get; set; }  // string?

        /// <remarks/>
        [XmlElement(ElementName = "cashAllowedFlag", Form = XmlSchemaForm.Unqualified, Order = 12)]
        public YesNo10Flag? CashAllowedFlag { get; set; }  // string?

        /// <summary>
        /// Setting the quantity value
        /// </summary>
        [XmlElement(ElementName = "maxOneTwoQuantity", Form = XmlSchemaForm.Unqualified, Order = 13)]
        public int MaxOneTwoQuantity { get; set; }

        /// <summary>
        /// Can contain up to 36 product elements, each of which is comprised
        /// of a product code and product flag (not available or available).
        /// </summary>
        [XmlArray(ElementName = "products", Form = XmlSchemaForm.Unqualified, Order = 14)]
        [XmlArrayItem("productElement", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public ProductElement[]? Products { get; set; }

        /// <summary>
        /// 999
        /// </summary>
        [XmlElement(ElementName = "maxReeferQuantity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public Nullable<int> MaxReeferQuantity { get; set; }

        /// <summary>
        /// 999
        /// </summary>
        [XmlElement(ElementName = "maxOtherQuantity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public Nullable<int> MaxOtherQuantity { get; set; }
    }
}
