﻿using System;
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
    public partial class VehicleIdRecord
    {
        /// <summary>
        /// Also referred to as Vehicle Number, Unit ID, or Unit Number; this value must be 10 digits or less in the web
        /// service request and not file process
        /// </summary>
        [XmlElement(ElementName = "vehicleId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? VehicleId { get; set; }

        /// <summary>
        /// The unique number used in the automotive industry to identify motor vehicles
        /// </summary>
        [XmlElement(ElementName = "vinNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? VinNumber { get; set; }

        /// <summary>
        /// Free-form description of the vehicle (unit)
        /// </summary>
        [XmlElement(ElementName = "vehicleDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? VehicleDescription { get; set; }

        /// <summary>
        /// Vehicle license number of <= 20 alphanumeric characters
        /// </summary>
        [XmlElement(ElementName = "licenseNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? LicenseNumber { get; set; }

        /// <summary>
        /// YYYY-MM (Year-Month)
        /// </summary>
        [XmlElement(ElementName = "expirationDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// Miscellaneous storage field
        /// </summary>
        [XmlElement(ElementName = "miscData1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? MiscData1 { get; set; }

        /// <summary>
        /// Miscellaneous storage field
        /// </summary>
        [XmlElement(ElementName = "miscData2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? MiscData2 { get; set; }

        /// <summary>
        /// Customer ID assigned by Comdata. (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [XmlElement(ElementName = "acctNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? AcctNbr { get; set; }

        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [XmlElement(ElementName = "custId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CustId { get; set; }

        /// <summary>
        /// Hubometer Start Value
        /// </summary>
        [XmlElement(ElementName = "hubometerStart", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? HubometerStart { get; set; }

        /// <summary>
        /// Hubometer End Value
        /// </summary>
        [XmlElement(ElementName = "hubometerEnd", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? HubometerEnd { get; set; }
    }
}
