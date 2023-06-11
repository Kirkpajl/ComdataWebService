using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;
using TransactionStatus = Comdata.FleetCreditWS0200.Enumerations.TransactionStatus;
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
    public partial class RtTransactionCriteriaV02
    {
        /// <summary>
        /// Alphanumeric value assigned by comdata
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID assigned by Comdata (4-digit customer IDs should include a leading zero). Up to 500 customer IDs can be added to a request.
        /// </summary>
        [XmlArray(ElementName = "customerIds", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        [XmlArrayItem("customerId", Form = XmlSchemaForm.Unqualified)]
        public string[]? CustomerIds { get; set; }

        /// <summary>
        /// Entering a card number will return all transactions within the designated time frame if the user has access to that Customer ID.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Alphanumeric. Entering a card token returns the same history as entering the associated card number
        /// </summary>
        [XmlElement(ElementName = "cardToken", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CardToken { get; set; }

        /// <summary>
        /// Search by a vehicle number assocated with the card. Alphanumeric
        /// </summary>
        [XmlElement(ElementName = "employeeVehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? EmployeeVehicleNumber { get; set; }

        /// <summary>
        /// Search by value assigned to the Last Name field of the card or cards
        /// </summary>
        [XmlElement(ElementName = "employeeLastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? EmployeeLastName { get; set; }

        /// <summary>
        /// Search by the value assigned to the First Name field of the card or cards
        /// </summary>
        [XmlElement(ElementName = "employeeFirstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? EmployeeFirstName { get; set; }

        /// <summary>
        /// Enter one or more of the following transaction statuses to limit search results:
        /// * All
        /// * Authorized
        /// * Posted
        /// * Declined
        /// * Credit
        /// </summary>
        /// <remarks>Note: The value entered must match one of the options shown above.This field is case sensitive.</remarks>
        [XmlArray(ElementName = "transactionStatuses", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public Nullable<TransactionStatus>[]? TransactionStatuses { get; set; }

        /// <summary>
        /// Select Transaction or Posted as the date type to sort your results.The default setting is transaction.        
        /// </summary>
        /// <remarks>Note: This field is case sensitive.</remarks>
        [XmlElement(ElementName = "sortByDateType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public Nullable<DateType> SortByDateType { get; set; }

        /// <summary>
        /// Select the date type, Transaction or Posted, used in your search.The default setting is transaction.        
        /// </summary>
        /// <remarks>Note: This field is case sensitive.</remarks>
        [XmlElement(ElementName = "selectionDateType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public Nullable<DateType> SelectionDateType { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// Enter an end date also unless your start date is within 45 days of the current date.
        /// </summary>
        [XmlElement(ElementName = "startDate", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public string? StartDate { get; set; }

        /// <summary>
        /// HH:MM:SS where "H = hour, "M" = minutes, and "S" = seconds        
        /// </summary>
        /// <example>Example: Enter 13:30:00 for 1:30 pm(and 0 seconds)</example>
        [XmlElement(ElementName = "startTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? StartTime { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// This entry cannot be older than 14 months before the
        /// current day. If your Start Date is more than 45 days
        /// before the current date, you must include an End Date.
        /// </summary>
        [XmlElement(ElementName = "endDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? EndDate { get; set; }

        /// <summary>
        /// HH:MM:SS where "H = hour, "M" = minutes, and "S" = seconds        
        /// </summary>
        /// <example>Example: Enter 13:30:00 for 1:30 pm(and 0 seconds)</example>
        [XmlElement(ElementName = "endTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? EndTime { get; set; }
    }
}
