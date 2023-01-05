using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
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
    public partial class PIDTransactionRecord
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
        /// Constant "01"; "C1" if Cancelled
        /// </summary>
        [XmlElement(ElementName = "recordIdentifier", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? RecordIdentifier { get; set; }

        /// <summary>
        /// CDN Company Accounting Code
        /// </summary>
        [XmlElement(ElementName = "cdnCompanyAccountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CdnCompanyAccountCode { get; set; }

        /// <summary>
        /// Fuel Billing Flag, B = Balanced Based, L=limit based
        /// </summary>
        [XmlElement(ElementName = "fuelBillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? FuelBillingFlag { get; set; }

        /// <summary>
        /// Express Cash Billing Flag, L=load, P=pick-up
        /// </summary>
        [XmlElement(ElementName = "expressCashBillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ExpressCashBillingFlag { get; set; }

        /// <summary>
        /// Transaction Date, YYYY-MM-DD
        /// </summary>
        [XmlElement(ElementName = "transactionDate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? TransactionDate { get; set; }

        /// <summary>
        /// Transaction Number Indicator: 0 = less than 100,000; 1 = 100,000; 2 = 200,000
        /// </summary>
        [XmlElement(ElementName = "transactionNumberIndicator", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? TransactionNumberIndicator { get; set; }

        /// <summary>
        /// Transaction Day, DD
        /// </summary>
        [XmlElement(ElementName = "transactionDay", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? TransactionDay { get; set; }

        /// <summary>
        /// Right most 5 digits of transaction #
        /// </summary>
        [XmlElement(ElementName = "transactionNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? TransactionNumber { get; set; }

        /// <summary>
        /// Unit Number, right justified
        /// </summary>
        [XmlElement(ElementName = "unitNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? UnitNumber { get; set; }

        /// <summary>
        /// Truck Stop Code, ST###, ST is the state abbreviation of the truck stop.
        /// </summary>
        [XmlElement(ElementName = "truckStopCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? TruckStopCode { get; set; }

        /// <summary>
        /// Truck Stop Name
        /// </summary>
        [XmlElement(ElementName = "truckStopName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? TruckStopName { get; set; }

        /// <summary>
        /// Truck Stop City
        /// </summary>
        [XmlElement(ElementName = "truckStopCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? TruckStopCity { get; set; }

        /// <summary>
        /// Truck Stop State
        /// </summary>
        [XmlElement(ElementName = "truckStopState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? TruckStopState { get; set; }

        /// <summary>
        /// Truck Stop Invoice Number
        /// </summary>
        [XmlElement(ElementName = "truckStopInvoiceNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? TruckStopInvoiceNumber { get; set; }

        /// <summary>
        /// HHMM
        /// </summary>
        [XmlElement(ElementName = "transactionTime", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? TransactionTime { get; set; }

        /// <summary>
        /// Total Amount Due
        /// </summary>
        [XmlElement(ElementName = "totalAmountDue", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public Nullable<double> TotalAmountDue { get; set; }

        /// <summary>
        /// Fees for fuel and oil and products
        /// </summary>
        [XmlElement(ElementName = "fuelOilFees", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public Nullable<double> FuelOilFees { get; set; }

        /// <summary>
        /// Cheaper Fuel Availability Flag; "*" means cheaper fuel was available, blank means it wasn't
        /// </summary>
        [XmlElement(ElementName = "cheapFuelAvaliabilityFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? CheapFuelAvailabilityFlag { get; set; }

        /// <summary>
        /// Service Used when fueling: F= Full Service, M = mini service, S = self service, B = blended fuel, T= Terminal Fuel, N = Not Applicable, W = Wet Hose
        /// </summary>
        [XmlElement(ElementName = "serviceUsed", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? ServiceUsed { get; set; }

        /// <summary>
        /// Number of Tractor Gallons
        /// </summary>
        [XmlElement(ElementName = "numTractorGallons", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public Nullable<double> NumTractorGallons { get; set; }

        /// <summary>
        /// Tractor Fuel Price Per Gallon
        /// </summary>
        [XmlElement(ElementName = "tractorFuelPricePerGallon", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public Nullable<double> TractorFuelPricePerGallon { get; set; }

        /// <summary>
        /// Cost of Tractor Fuel
        /// </summary>
        [XmlElement(ElementName = "costOfTractorFuel", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public Nullable<double> CostOfTractorFuel { get; set; }

        /// <summary>
        /// Number of Reefer Gallons
        /// </summary>
        [XmlElement(ElementName = "numReeferGallons", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public Nullable<double> NumReeferGallons { get; set; }

        /// <summary>
        /// Reefer Price Per Gallon
        /// </summary>
        [XmlElement(ElementName = "reeferPricePerGallon", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public Nullable<double> ReeferPricePerGallon { get; set; }

        /// <summary>
        /// Cost of Reefer Fuel
        /// </summary>
        [XmlElement(ElementName = "costOfReeferFuel", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public Nullable<double> CostOfReeferFuel { get; set; }

        /// <summary>
        /// Number of Quarts of Oil
        /// </summary>
        [XmlElement(ElementName = "numQuartsOil", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? NumQuartsOil { get; set; }

        /// <summary>
        /// Total Cost of Oil
        /// </summary>
        [XmlElement(ElementName = "costOfOil", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public Nullable<double> CostOfOil { get; set; }

        /// <summary>
        /// Tractor Fuel Billing Flag, F=Funded, D=direct bill, T=terminal
        /// </summary>
        [XmlElement(ElementName = "tractorFuelBillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? TractorFuelBillingFlag { get; set; }

        /// <summary>
        /// Reefer Fuel Billing Flag, F = Funded, D= direct bill
        /// </summary>
        [XmlElement(ElementName = "reeferFuelBillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public string? ReeferFuelBillingFlag { get; set; }

        /// <summary>
        /// Oil Billing Flag, F=Funded, D=direct bill, T=terminal
        /// </summary>
        [XmlElement(ElementName = "oilBillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? OilBillingFlag { get; set; }

        /// <summary>
        /// Product Group Code
        /// </summary>
        [XmlElement(ElementName = "productGroupCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? ProductGroupCode { get; set; }

        /// <summary>
        /// Cash Advance Amount
        /// </summary>
        [XmlElement(ElementName = "cashAdvanceAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public Nullable<double> CashAdvanceAmount { get; set; }

        /// <summary>
        /// Charges for Cash Advance
        /// </summary>
        [XmlElement(ElementName = "chargesForCashAdvance", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public Nullable<double> ChargesForCashAdvance { get; set; }

        /// <summary>
        /// Driver's Name
        /// </summary>
        [XmlElement(ElementName = "driverName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? DriverName { get; set; }

        /// <summary>
        /// Trip Number
        /// </summary>
        [XmlElement(ElementName = "tripNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public string? TripNumber { get; set; }

        /// <summary>
        /// Conversation Rate
        /// </summary>
        [XmlElement(ElementName = "conversationRate", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? ConversationRate { get; set; }

        /// <summary>
        /// Hubometer Reading
        /// </summary>
        [XmlElement(ElementName = "hubometerReading", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public string? HubometerReading { get; set; }

        /// <summary>
        /// Year to date MPG
        /// </summary>
        [XmlElement(ElementName = "yearToDateMPG", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public Nullable<double> YearToDateMPG { get; set; }

        /// <summary>
        /// MPG for this fill up
        /// </summary>
        [XmlElement(ElementName = "mpgForThisFillUp", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public Nullable<double> MpgForThisFillUp { get; set; }

        /// <summary>
        /// Reefer fuel product group code
        /// </summary>
        [XmlElement(ElementName = "reeferFuleProductGroupCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public string? ReeferFuleProductGroupCode { get; set; }

        /// <summary>
        /// Diesel #2 Fuel Product Group Code
        /// </summary>
        [XmlElement(ElementName = "dieselNum2FuelProductGroupCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public string? DieselNum2FuelProductGroupCode { get; set; }

        /// <summary>
        /// Product Group Code 2
        /// </summary>
        [XmlElement(ElementName = "productGroupCode2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public string? ProductGroupCode2 { get; set; }

        /// <summary>
        /// Product Group Code 3
        /// </summary>
        [XmlElement(ElementName = "productGroupCode3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public string? ProductGroupCode3 { get; set; }

        /// <summary>
        /// Billable Currency, U=US, C=Canadian
        /// </summary>
        [XmlElement(ElementName = "billableCurrency", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public string? BillableCurrency { get; set; }

        /// <summary>
        /// Comchek Card Number
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Employee Number
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Non-Funded Item, *=Direct Bill Transaction, T=Terminal Fuel Transaction, or blank
        /// </summary>
        [XmlElement(ElementName = "nonFundedItem", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public string? NonFundedItem { get; set; }

        /// <summary>
        /// *=Not in Limited Network
        /// </summary>
        [XmlElement(ElementName = "notLimitedNtwkLocationFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public string? NotLimitedNtwkLocationFlag { get; set; }

        /// <summary>
        /// Product Amount 1
        /// </summary>
        [XmlElement(ElementName = "productAmount1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public Nullable<double> ProductAmount1 { get; set; }

        /// <summary>
        /// Product Amount 2
        /// </summary>
        [XmlElement(ElementName = "productAmount2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public Nullable<double> ProductAmount2 { get; set; }

        /// <summary>
        /// Product Amount 3
        /// </summary>
        [XmlElement(ElementName = "productAmount3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public Nullable<double> ProductAmount3 { get; set; }

        /// <summary>
        /// Alliance Select or Focus - "Rebate Amount"
        /// </summary>
        [XmlElement(ElementName = "allianceSelectOrFocus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public Nullable<double> AllianceSelectOrFocus { get; set; }

        /// <summary>
        /// Y = Alliance Network Location
        /// </summary>
        [XmlElement(ElementName = "allianceLocationFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public string? AllianceLocationFlag { get; set; }

        /// <summary>
        /// F=Funded, D=direct bill, T= Terminal, or blank
        /// </summary>
        [XmlElement(ElementName = "cashBillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public string? CashBillingFlag { get; set; }

        /// <summary>
        /// F=Funded, D=direct bill, T= Terminal, or blank
        /// </summary>
        [XmlElement(ElementName = "productGroup1BillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public string? ProductGroup1BillingFlag { get; set; }

        /// <summary>
        /// F=Funded, D=direct bill, T= Terminal, or blank
        /// </summary>
        [XmlElement(ElementName = "productGroup2BillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public string? ProductGroup2BillingFlag { get; set; }

        /// <summary>
        /// F=Funded, D=direct bill, T= Terminal, or blank
        /// </summary>
        [XmlElement(ElementName = "productGroup3BillingFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? ProductGroup3BillingFlag { get; set; }

        /// <summary>
        /// Driver's License State
        /// </summary>
        [XmlElement(ElementName = "driverLicenseState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? DriverLicenseState { get; set; }

        /// <summary>
        /// Driver's License Number
        /// </summary>
        [XmlElement(ElementName = "driverLicenseNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? DriverLicenseNumber { get; set; }

        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [XmlElement(ElementName = "purchaseOrderNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Trailer Number
        /// </summary>
        [XmlElement(ElementName = "trailerNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public string? TrailerNumber { get; set; }

        /// <summary>
        /// Previous Hub Reading
        /// </summary>
        [XmlElement(ElementName = "previousHubReading", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public string? PreviousHubReading { get; set; }

        /// <summary>
        /// Y=yes, N=no
        /// </summary>
        [XmlElement(ElementName = "cancelFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public string? CancelFlag { get; set; }

        /// <summary>
        /// Date of original transaction
        /// </summary>
        [XmlElement(ElementName = "dateOfOriginalTransaction", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? DateOfOriginalTransaction { get; set; }

        /// <summary>
        /// Service Center Chain Code
        /// </summary>
        [XmlElement(ElementName = "serviceCenterChainCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? ServiceCenterChainCode { get; set; }

        /// <summary>
        /// Diesel #1 Fuel Product Group Code
        /// </summary>
        [XmlElement(ElementName = "dieselNum1FuelProductGroupCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 67)]
        public string? DieselNum1FuelProductGroupCode { get; set; }

        /// <summary>
        /// Other Fuel Product Group Code
        /// </summary>
        [XmlElement(ElementName = "otherFuelProductGroupCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 68)]
        public string? OtherFuelProductGroupCode { get; set; }

        /// <summary>
        /// R=rebate, N=net
        /// </summary>
        [XmlElement(ElementName = "rebateIndicator", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 69)]
        public string? RebateIndicator { get; set; }

        /// <summary>
        /// Trailer Hub Reading
        /// </summary>
        [XmlElement(ElementName = "trailerHubReading", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 70)]
        public Nullable<double> TrailerHubReading { get; set; }

        /// <summary>
        /// Y=yes, N=no
        /// </summary>
        [XmlElement(ElementName = "automatedTransaction", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 71)]
        public string? AutomatedTransaction { get; set; }

        /// <summary>
        /// Y=yes, N=no
        /// </summary>
        [XmlElement(ElementName = "bulkFuelFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 72)]
        public string? BulkFuelFlag { get; set; }

        /// <summary>
        /// Y=yes, N=no
        /// </summary>
        [XmlElement(ElementName = "serviceCenterBridgeTransaction", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 73)]
        public string? ServiceCenterBridgeTransaction { get; set; }

        /// <summary>
        /// Number 1 Fuel-Gallons
        /// </summary>
        [XmlElement(ElementName = "number1FuelGallons", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 74)]
        public Nullable<double> Number1FuelGallons { get; set; }

        /// <summary>
        /// Number 1 Fuel-PPG
        /// </summary>
        [XmlElement(ElementName = "number1FuelPPG", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 75)]
        public Nullable<double> Number1FuelPPG { get; set; }

        /// <summary>
        /// Number 1 Fuel-Cost
        /// </summary>
        [XmlElement(ElementName = "number1FuelCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 76)]
        public Nullable<double> Number1FuelCost { get; set; }

        /// <summary>
        /// Other Fuel-Gallons
        /// </summary>
        [XmlElement(ElementName = "otherFuelGallons", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 77)]
        public Nullable<double> OtherFuelGallons { get; set; }

        /// <summary>
        /// Other Fuel-PPG
        /// </summary>
        [XmlElement(ElementName = "otherFuelPPG", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 78)]
        public Nullable<double> OtherFuelPPG { get; set; }

        /// <summary>
        /// Other Fuel-Cost
        /// </summary>
        [XmlElement(ElementName = "otherFuelCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 79)]
        public Nullable<double> OtherFuelCost { get; set; }

        /// <summary>
        /// F=Focus, S=Select, or blanks
        /// </summary>
        [XmlElement(ElementName = "focusOrSelectDiscount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 80)]
        public string? FocusOrSelectDiscount { get; set; }

        /// <summary>
        /// Canadian Tax Amount (Can Dollars)
        /// </summary>
        [XmlElement(ElementName = "canadianTaxAmountCan", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 81)]
        public Nullable<double> CanadianTaxAmountCan { get; set; }

        /// <summary>
        /// Canadian Tax Amount (US Dollars)
        /// </summary>
        [XmlElement(ElementName = "canadianTaxAmountUS", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 82)]
        public Nullable<double> CanadianTaxAmountUS { get; set; }

        /// <summary>
        /// Y=yes, N=no
        /// </summary>
        [XmlElement(ElementName = "canadianTaxPaidFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 83)]
        public string? CanadianTaxPaidFlag { get; set; }

        /// <summary>
        /// Y for Declined transactions and nullable for processed transactions
        /// </summary>
        [XmlElement(ElementName = "declineFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 84)]
        public string? DeclineFlag { get; set; }

        /// <summary>
        /// decline code of declined transactions and nullable for processed transactions
        /// </summary>
        [XmlElement(ElementName = "declineCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 85)]
        public string? DeclineCode { get; set; }

        /// <summary>
        /// decline description of declined transactions and nullable for processed transactions
        /// </summary>
        [XmlElement(ElementName = "declineMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 86)]
        public string? DeclineMessage { get; set; }
    }
}
