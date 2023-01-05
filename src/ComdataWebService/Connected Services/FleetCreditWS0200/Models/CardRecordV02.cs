using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
=======
>>>>>>> releases/v1.0.0

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
<<<<<<< HEAD
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class CardRecordV02
    {
        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Customer-assigned value returned in the response record
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Customer-assigned value returned in the response record
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// A = active; B = blocked; C = clear
        /// </summary>
        [XmlElement(ElementName = "cardStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CardStatus { get; set; }

        /// <summary>
        /// Y (yes) or N (no)
        /// </summary>
        [XmlElement(ElementName = "profileFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ProfileFlag { get; set; }

        /// <summary>
        /// 3-digit number identifying the profile group for the cardholder, if applicable
        /// </summary>
        [XmlElement(ElementName = "profileValue", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? ProfileValue { get; set; }

        /// <summary>
        /// Additional information describing the profile group
        /// </summary>
        [XmlElement(ElementName = "profileDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ProfileDescription { get; set; }

        /// <summary>
        /// Value assigned to the First Name field
        /// </summary>
        [XmlElement(ElementName = "cardFirstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CardFirstName { get; set; }

        /// <summary>
        /// Value assigned to the Last Name field
        /// </summary>
        [XmlElement(ElementName = "cardLastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? CardLastName { get; set; }

        /// <summary>
        /// Driver License Number assigned to card
        /// </summary>
        [XmlElement(ElementName = "driverLicenseNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? DriverLicenseNumber { get; set; }

        /// <summary>
        /// Use the two-letter state (US) or province (Canada) abbreviation
        /// </summary>
        [XmlElement(ElementName = "driverLicenseState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? DriverLicenseState { get; set; }

        /// <summary>
        /// Comdata proprietary (fleet) cards only
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Vehicle Number, also known as Unit Number; although 17 characters are permitted, Vehicle Numbers are 10
        /// </summary>
        [XmlElement(ElementName = "vehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// Employee Number assigned to card
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Vehicle's VIN number
        /// </summary>
        [XmlElement(ElementName = "vehicleVINNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? VehicleVINNumber { get; set; }

        /// <summary>
        /// Brief, free-form description of a vehicle
        /// </summary>
        [XmlElement(ElementName = "vehicleDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? VehicleDescription { get; set; }

        /// <summary>
        /// Vehicle license plate number
        /// </summary>
        [XmlElement(ElementName = "vehicleLicensePlateNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? VehicleLicensePlateNumber { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// </summary>
        [XmlElement(ElementName = "registrationExpiration", Form = XmlSchemaForm.Unqualified, DataType = "date", IsNullable = true, Order = 18)]
        public Nullable<System.DateTime> RegistrationExpiration { get; set; }

        /// <summary>
        /// Customer-specific field
        /// </summary>
        [XmlElement(ElementName = "miscellaneous1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? Miscellaneous1 { get; set; }

        /// <summary>
        /// Customer-specific field
        /// </summary>
        [XmlElement(ElementName = "miscellaneous2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? Miscellaneous2 { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// </summary>
        [XmlElement(ElementName = "cardExpiration", Form = XmlSchemaForm.Unqualified, DataType = "date", IsNullable = true, Order = 21)]
        public Nullable<System.DateTime> CardExpiration { get; set; }

        /// <summary>
        /// Card token for the card number
        /// </summary>
        [XmlElement(ElementName = "cardToken", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? CardToken { get; set; }

        /// <summary>
        /// The block reason code if card is blocked. See cardBLockReasonDesc.
        /// </summary>
        [XmlElement(ElementName = "cardBlockReasonCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? CardBlockReasonCode { get; set; }

        /// <summary>
        /// If the card is blocked, a description of why the card is blocked.See Appendix A for more details.
        /// </summary>
        [XmlElement(ElementName = "cardBlockReasonDesc", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class CardRecordV02
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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CardStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ProfileFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? ProfileValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ProfileDescription { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardFirstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CardFirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardLastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? CardLastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? DriverLicenseNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? DriverLicenseState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? TripNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vehicleNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? VehicleNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? EmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vehicleVINNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? VehicleVINNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vehicleDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? VehicleDescription { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vehicleLicensePlateNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? VehicleLicensePlateNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "registrationExpiration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date", IsNullable = true, Order = 18)]
        public System.Nullable<System.DateTime> RegistrationExpiration { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "miscellaneous1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? Miscellaneous1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "miscellaneous2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? Miscellaneous2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardExpiration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date", IsNullable = true, Order = 21)]
        public System.Nullable<System.DateTime> CardExpiration { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardToken", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? CardToken { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardBlockReasonCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? CardBlockReasonCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardBlockReasonDesc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
>>>>>>> releases/v1.0.0
        public string? CardBlockReasonDesc { get; set; }
    }
}
