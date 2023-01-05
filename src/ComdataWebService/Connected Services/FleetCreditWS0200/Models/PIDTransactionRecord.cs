using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class PIDTransactionRecord
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "recordIdentifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? RecordIdentifier { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cdnCompanyAccountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CdnCompanyAccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fuelBillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? FuelBillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expressCashBillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ExpressCashBillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "transactionDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? TransactionDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "transactionNumberIndicator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? TransactionNumberIndicator { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "transactionDay", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? TransactionDay { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "transactionNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? TransactionNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "unitNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? UnitNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "truckStopCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? TruckStopCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "truckStopName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? TruckStopName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "truckStopCity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? TruckStopCity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "truckStopState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? TruckStopState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "truckStopInvoiceNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? TruckStopInvoiceNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "transactionTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? TransactionTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalAmountDue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public System.Nullable<double> TotalAmountDue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fuelOilFees", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public System.Nullable<double> FuelOilFees { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cheapFuelAvaliabilityFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? CheapFuelAvailabilityFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? ServiceUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "numTractorGallons", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public System.Nullable<double> NumTractorGallons { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tractorFuelPricePerGallon", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public System.Nullable<double> TractorFuelPricePerGallon { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "costOfTractorFuel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public System.Nullable<double> CostOfTractorFuel { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "numReeferGallons", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public System.Nullable<double> NumReeferGallons { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferPricePerGallon", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public System.Nullable<double> ReeferPricePerGallon { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "costOfReeferFuel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public System.Nullable<double> CostOfReeferFuel { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "numQuartsOil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? NumQuartsOil { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "costOfOil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public System.Nullable<double> CostOfOil { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tractorFuelBillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? TractorFuelBillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferFuelBillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public string? ReeferFuelBillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "oilBillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? OilBillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productGroupCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? ProductGroupCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashAdvanceAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public System.Nullable<double> CashAdvanceAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "chargesForCashAdvance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public System.Nullable<double> ChargesForCashAdvance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? DriverName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tripNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public string? TripNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "conversationRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? ConversationRate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "hubometerReading", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public string? HubometerReading { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "yearToDateMPG", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public System.Nullable<double> YearToDateMPG { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mpgForThisFillUp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public System.Nullable<double> MpgForThisFillUp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reeferFuleProductGroupCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public string? ReeferFuleProductGroupCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dieselNum2FuelProductGroupCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public string? DieselNum2FuelProductGroupCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productGroupCode2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public string? ProductGroupCode2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productGroupCode3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public string? ProductGroupCode3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "billableCurrency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public string? BillableCurrency { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public string? EmployeeNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "nonFundedItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public string? NonFundedItem { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "notLimitedNtwkLocationFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public string? NotLimitedNtwkLocationFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productAmount1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public System.Nullable<double> ProductAmount1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productAmount2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
        public System.Nullable<double> ProductAmount2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productAmount3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 52)]
        public System.Nullable<double> ProductAmount3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "allianceSelectOrFocus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 53)]
        public System.Nullable<double> AllianceSelectOrFocus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "allianceLocationFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 54)]
        public string? AllianceLocationFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cashBillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 55)]
        public string? CashBillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productGroup1BillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 56)]
        public string? ProductGroup1BillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productGroup2BillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 57)]
        public string? ProductGroup2BillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productGroup3BillingFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 58)]
        public string? ProductGroup3BillingFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 59)]
        public string? DriverLicenseState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "driverLicenseNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 60)]
        public string? DriverLicenseNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "purchaseOrderNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 61)]
        public string? PurchaseOrderNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trailerNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 62)]
        public string? TrailerNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "previousHubReading", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 63)]
        public string? PreviousHubReading { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cancelFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 64)]
        public string? CancelFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dateOfOriginalTransaction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 65)]
        public string? DateOfOriginalTransaction { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceCenterChainCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 66)]
        public string? ServiceCenterChainCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dieselNum1FuelProductGroupCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 67)]
        public string? DieselNum1FuelProductGroupCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherFuelProductGroupCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 68)]
        public string? OtherFuelProductGroupCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "rebateIndicator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 69)]
        public string? RebateIndicator { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trailerHubReading", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 70)]
        public System.Nullable<double> TrailerHubReading { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "automatedTransaction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 71)]
        public string? AutomatedTransaction { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bulkFuelFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 72)]
        public string? BulkFuelFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceCenterBridgeTransaction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 73)]
        public string? ServiceCenterBridgeTransaction { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "number1FuelGallons", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 74)]
        public System.Nullable<double> Number1FuelGallons { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "number1FuelPPG", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 75)]
        public System.Nullable<double> Number1FuelPPG { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "number1FuelCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 76)]
        public System.Nullable<double> Number1FuelCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherFuelGallons", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 77)]
        public System.Nullable<double> OtherFuelGallons { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherFuelPPG", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 78)]
        public System.Nullable<double> OtherFuelPPG { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "otherFuelCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 79)]
        public System.Nullable<double> OtherFuelCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "focusOrSelectDiscount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 80)]
        public string? FocusOrSelectDiscount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "canadianTaxAmountCan", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 81)]
        public System.Nullable<double> CanadianTaxAmountCan { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "canadianTaxAmountUS", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 82)]
        public System.Nullable<double> CanadianTaxAmountUS { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "canadianTaxPaidFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 83)]
        public string? CanadianTaxPaidFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "declineFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 84)]
        public string? DeclineFlag { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "declineCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 85)]
        public string? DeclineCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "declineMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 86)]
        public string? DeclineMessage { get; set; }
    }
}
