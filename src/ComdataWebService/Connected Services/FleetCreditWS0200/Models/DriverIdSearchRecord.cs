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
    public partial class DriverIdSearchRecord
    {
        /// <summary>
        /// Numeric driver ID of 6 digits; the field permits <= 16 digits
        /// </summary>
        [XmlElement(ElementName = "driverId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? DriverId { get; set; }

        /// <summary>
        /// Value assigned to the First Name field
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Value assigned to the Last Name field
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? LastName { get; set; }

        /// <summary>
        /// US or Canadian driver's license number
        /// </summary>
        [XmlElement(ElementName = "driverLicNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DriverLicNbr { get; set; }

        /// <summary>
        /// 2-letter state abbreviation (IS) or province abbreviation (Canada)
        /// </summary>
        [XmlElement(ElementName = "driverLicState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DriverLicState { get; set; }

        /// <summary>
        /// Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [XmlElement(ElementName = "custId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? CustId { get; set; }

        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [XmlElement(ElementName = "acctNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? AcctNbr { get; set; }

        /// <summary>
        /// Name set up for the Account Code
        /// </summary>
        [XmlElement(ElementName = "acctName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? AcctName { get; set; }

        /// <summary>
        /// Name set up for the Customer ID
        /// </summary>
        [XmlElement(ElementName = "custName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustName { get; set; }

        /// <summary>
        /// Value assigned to the Misc1 field
        /// </summary>
        [XmlElement(ElementName = "misc1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? Misc1 { get; set; }

        /// <summary>
        /// Value assigned to the Misc2 field
        /// </summary>
        [XmlElement(ElementName = "misc2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? Misc2 { get; set; }

        /// <summary>
        /// Value assigned to the Driver Email address field
        /// </summary>
        [XmlElement(ElementName = "driverEmail", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? DriverEmail { get; set; }

        /// <summary>
        /// Value assigned to hold flag field.
        /// </summary>
        [XmlElement(ElementName = "onHoldFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? OnHoldFlag { get; set; }

        /// <summary>
        /// Date the cardIdentifier hold will be released (YYYY-MM-DD)
        /// </summary>
        [XmlElement(ElementName = "holdReleaseDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? HoldReleaseDate { get; set; }

        /// <summary>
        /// Time the cardIdentifier hold will be released (HHMM) 24-hour format
        /// </summary>
        [XmlElement(ElementName = "holdReleaseTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class DriverIdSearchRecord
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? DriverId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? FirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? LastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DriverLicNbr { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DriverLicState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "custId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? CustId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "acctNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? AcctNbr { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "acctName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? AcctName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "custName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "misc1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? Misc1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "misc2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? Misc2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverEmail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? DriverEmail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "onHoldFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? OnHoldFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "holdReleaseDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? HoldReleaseDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "holdReleaseTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
>>>>>>> releases/v1.0.0
        public string? HoldReleaseTime { get; set; }
    }
}
