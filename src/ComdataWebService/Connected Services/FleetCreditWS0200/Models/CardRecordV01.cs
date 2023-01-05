using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class CardRecordV01
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
        /// A = active; B = blocked; C = clear; F = fraud; L = lost; S = stolen
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

        /// <remarks/>
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
        /// Driver's License Number (US or Canadian)
        /// </summary>
        [XmlElement(ElementName = "driverLicenseNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? DriverLicenseNumber { get; set; }

        /// <summary>
        /// Use 2-letter state abbreviation (US) or province abbreviation(Canada)
        /// </summary>
        [XmlElement(ElementName = "driverLicenseState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? DriverLicenseState { get; set; }

        /// <summary>
        /// For Comdata proprietary (fleet) cards only; this number uniquely identifies a trip
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Vehicle Number, also known as Unit Number; although 17 characters are permitted, Vehicle Numbers are 6
        /// </summary>
        [XmlElement(ElementName = "vehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// Employee number assigned to this card
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
        /// Miscellaneous storage field one
        /// </summary>
        [XmlElement(ElementName = "miscellaneous1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? Miscellaneous1 { get; set; }

        /// <summary>
        /// Miscellaneous storage field two
        /// </summary>
        [XmlElement(ElementName = "miscellaneous2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? Miscellaneous2 { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// </summary>
        [XmlElement(ElementName = "cardExpiration", Form = XmlSchemaForm.Unqualified, DataType = "date", IsNullable = true, Order = 21)]
        public Nullable<System.DateTime> CardExpiration { get; set; }
    }
}
