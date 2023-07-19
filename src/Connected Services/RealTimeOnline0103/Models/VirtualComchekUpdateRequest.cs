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
    /// <summary>
    /// The Virtual Comchek Add 1.0 function is used to used to make updates to an existing Comdata Virtual Comchek card.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualComchekUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekUpdateRequestBody : IRequest  //ISoapRequestBody<VirtualComchekUpdateRequest>
    {
        public VirtualComchekUpdateRequestBody() : this(new VirtualComchekUpdateRequest()) { }
        public VirtualComchekUpdateRequestBody(VirtualComchekUpdateRequest request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "updateRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekUpdateRequest Request { get; set; }
    }



    /// <summary>
    /// The Virtual Comchek Add 1.0 function is used to used to make updates to an existing Comdata Virtual Comchek card.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualComchekUpdateRequest// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Full 16 digit card number.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by Comdata. (4-digit Customer IDs MUST include leading zero.)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requester would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Establish initial/change current GL value.  No value leaves existing value unchanged.
        /// </summary>
        /// <remarks>Note: Not able to simply clear existing value.</remarks>
        [XmlElement(ElementName = "GLCode1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? GLCode1 { get; set; }

        /// <summary>
        /// Establish initial/change current GL value.  No value leaves existing value unchanged.
        /// </summary>
        /// <remarks>Note: Not able to simply clear existing value.</remarks>
        [XmlElement(ElementName = "GLCode2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? GLCode2 { get; set; }

        /// <summary>
        /// Establish initial/change current GL value.  No value leaves existing value unchanged.
        /// </summary>
        /// <remarks>Note: Not able to simply clear existing value.</remarks>
        [XmlElement(ElementName = "GLCode3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? GLCode3 { get; set; }

        /// <summary>
        /// Establish initial/change current GL value.  No value leaves existing value unchanged.
        /// </summary>
        /// <remarks>Note: Not able to simply clear existing value.</remarks>
        [XmlElement(ElementName = "GLCode4", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? GLCode4 { get; set; }

        /// <summary>
        /// MCC Code assignment (optional). No value REMOVES existing value.
        /// </summary>
        [XmlElement(ElementName = "MCCCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? MCCCode { get; set; }

        /// <summary>
        /// Password for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? Password { get; set; }

        /// <summary>
        /// Purchase Order Number for reporting
        /// </summary>
        [XmlElement(ElementName = "PONumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? PONumber { get; set; }

        /// <summary>
        /// Prompted Driver ID
        /// </summary>
        [XmlElement(ElementName = "promptedIDDriver", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? PromptedIDDriver { get; set; }

        /// <summary>
        /// Repair Order Number
        /// </summary>
        [XmlElement(ElementName = "repairOrderNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? RepairOrderNumber { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Vehicle/Unit number
        /// </summary>
        [XmlElement(ElementName = "vehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// Vendor invoice number
        /// </summary>
        [XmlElement(ElementName = "vendorInvoiceNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? VendorInvoiceNumber { get; set; }

        /// <summary>
        /// Vendor number
        /// </summary>
        [XmlElement(ElementName = "vendorNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? VendorNumber { get; set; }

        /// <summary>
        /// Warranty period
        /// </summary>
        [XmlElement(ElementName = "warrantyPeriod", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? WarrantyPeriod { get; set; }

        /// <summary>
        /// A = Active; B = Blocked; F = Fraud; S = Stolen
        /// </summary>
        [XmlElement(ElementName = "cardStatus", Form = XmlSchemaForm.Unqualified, Order = 19)]
        public VirtualCardStatusType CardStatus { get; set; } = VirtualCardStatusType.Active;  // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForAirlineMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public YesNoFlag? OpenForAirlineMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForBusinessServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public YesNoFlag? OpenForBusinessServicesMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForCarRentalsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public YesNoFlag? OpenForCarRentalsMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForFinancialServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public YesNoFlag? OpenForFinancialServicesMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForFuelMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public YesNoFlag? OpenForFuelMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForHotelsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public YesNoFlag? OpenForHotelsMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForLegalAndInsuranceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public YesNoFlag? OpenForLegalAndInsuranceMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForMaintenanceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public YesNoFlag? OpenForMaintenanceMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForMedicalMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public YesNoFlag? OpenForMedicalMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForMiscMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public YesNoFlag? OpenForMiscMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForMiscTransportationMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public YesNoFlag? OpenForMiscTransportationMerchantGroup { get; set; } // string?

        /// <summary>
        /// YES = Open; NO = Closed; If no value specified, default is NO.
        /// </summary>
        [XmlElement(ElementName = "openForRestaurantsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public YesNoFlag? OpenForRestaurantsMerchantGroup { get; set; } // string?

        /// <remarks/>
        [XmlElement(ElementName = "useGLCode1AsDefault", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? UseGLCode1AsDefault { get; set; }

        /// <summary>
        /// Y or YES = Yes; N or NO = No; No value will clear existing value.
        /// </summary>
        [XmlElement(ElementName = "warrantyReport", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public YesNoFlag? WarrantyReport { get; set; }  // string?

        /// <summary>
        /// Value must be greater than 0.00
        /// </summary>
        [XmlElement(ElementName = "dollarAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public Nullable<decimal> DollarAmount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        /// <remarks>A "0" value WILL clear existing value.No value leaves existing value unchanged.</remarks>
        [XmlElement(ElementName = "GLCode1Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public Nullable<decimal> GLCode1Amount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        /// <remarks>A "0" value WILL clear existing value.No value leaves existing value unchanged.</remarks>
        [XmlElement(ElementName = "GLCode2Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public Nullable<decimal> GLCode2Amount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        /// <remarks>A "0" value WILL clear existing value.No value leaves existing value unchanged.</remarks>
        [XmlElement(ElementName = "GLCode3Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public Nullable<decimal> GLCode3Amount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        /// <remarks>A "0" value WILL clear existing value.No value leaves existing value unchanged.</remarks>
        [XmlElement(ElementName = "GLCode4Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public Nullable<decimal> GLCode4Amount { get; set; }

        /// <summary>
        /// 9999999.99 -- A "0" value WILL clear existing value.  No value leaves existing value unchanged.
        /// </summary>
        [XmlElement(ElementName = "miscCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public Nullable<decimal> MiscCost { get; set; }

        /// <summary>
        /// 9999999.99 -- A "0" value WILL clear existing value.  No value leaves existing value unchanged.
        /// </summary>
        [XmlElement(ElementName = "totalLaborCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public Nullable<decimal> TotalLaborCost { get; set; }

        /// <summary>
        /// 9999999.99 -- A "0" value WILL clear existing value. No value leaves existing value unchanged.
        /// </summary>
        [XmlElement(ElementName = "totalPartsCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public Nullable<decimal> TotalPartsCost { get; set; }

        /// <summary>
        /// 9999.99 -- A "0" value WILL clear existing value.  No value leaves existing value unchanged.
        /// </summary>
        [XmlElement(ElementName = "totalTaxCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public Nullable<decimal> TotalTaxCost { get; set; }

        /// <summary>
        /// Valid Values 1 to 999.
        /// </summary>
        [XmlElement(ElementName = "numTransactionsAllowedForAuth", Form = XmlSchemaForm.Unqualified, Order = 43)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <summary>
        /// 0 and FALSE = False; 1 and TRUE = True
        /// </summary>
        [XmlElement(ElementName = "mustBeExactAmountForAuth", Form = XmlSchemaForm.Unqualified, Order = 44)]
        public bool MustBeExactAmountForAuth { get; set; }
    }
}
