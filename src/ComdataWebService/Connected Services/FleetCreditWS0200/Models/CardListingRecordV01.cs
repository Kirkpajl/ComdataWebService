using Comdata.FleetCreditWS0200.Enumerations;
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
    [XmlInclude(typeof(CardListingRecordV02))]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class CardListingRecordV01
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID under which the card was assigned
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// 16-digit card number (number masked if maskCardFlag flagged "Y" in the request; for example, "999999XXXXXX9999")
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Alphanumeric
        /// </summary>
        [XmlElement(ElementName = "cardToken", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public string? CardToken { get; set; }

        /// <summary>
        /// Reserved for future use
        /// </summary>
        [XmlElement(ElementName = "expirationYYMM", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ExpirationYYMM { get; set; }

        /// <summary>
        /// A = active; B = blocked; C = clear; F = fraud; L = lost; S = stolen
        /// </summary>
        [XmlElement(ElementName = "cardStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public Nullable<CardListingStatus> CardStatus { get; set; }  //string?

        /// <summary>
        /// First name or other identifier assigned to this field
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name or other identifier assigned to this field
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? LastName { get; set; }

        /// <summary>
        /// Employee number assigned to this card
        /// </summary>
        [XmlElement(ElementName = "employeeId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? EmployeeId { get; set; }

        /// <summary>
        /// Date card was created; YYYY-MM-DD
        /// </summary>
        [XmlElement(ElementName = "addDate", Form = XmlSchemaForm.Unqualified, DataType = "date", IsNullable = true, Order = 9)]
        public Nullable<System.DateTime> AddDate { get; set; }

        /// <summary>
        /// Miscellaneous storage field
        /// </summary>
        [XmlElement(ElementName = "misc1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? Misc1 { get; set; }

        /// <summary>
        /// Miscellaneous storage field
        /// </summary>
        [XmlElement(ElementName = "misc2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? Misc2 { get; set; }

        /// <summary>
        /// Vehicle Number, also known as Unit Number; although 17 characters are permitted, Vehicle Numbers are 6
        /// </summary>
        [XmlElement(ElementName = "vehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// Brief, free-form description of a vehicle
        /// </summary>
        [XmlElement(ElementName = "vehicleDesc", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? VehicleDesc { get; set; }

        /// <summary>
        /// Vehicle's VIN (Vehicle Identification Number)
        /// </summary>
        [XmlElement(ElementName = "vin", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? Vin { get; set; }

        /// <summary>
        /// Vehicle license plate number
        /// </summary>
        [XmlElement(ElementName = "vehicleLicense", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? VehicleLicense { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [XmlElement(ElementName = "mailName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? MailName { get; set; }

        /// <summary>
        /// Attention to person
        /// </summary>
        [XmlElement(ElementName = "mailAttention", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? MailAttention { get; set; }

        /// <summary>
        /// Mailing address line 1
        /// </summary>
        [XmlElement(ElementName = "mailAddress1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? MailAddress1 { get; set; }

        /// <summary>
        /// Mailing address line 2
        /// </summary>
        [XmlElement(ElementName = "mailAddress2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? MailAddress2 { get; set; }

        /// <summary>
        /// Mailing city
        /// </summary>
        [XmlElement(ElementName = "mailCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? MailCity { get; set; }

        /// <summary>
        /// 2-letter abbreviation for the state (US) or province (Canada)
        /// </summary>
        [XmlElement(ElementName = "mailState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? MailState { get; set; }

        /// <summary>
        /// Mailing zip code
        /// </summary>
        [XmlElement(ElementName = "mailZipCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? MailZipCode { get; set; }
    }
}
