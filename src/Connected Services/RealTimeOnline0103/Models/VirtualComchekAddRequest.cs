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
    /// The Virtual Comchek Add 1.0 function is used to request a Comdata Virtual Comchek Card.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualComchekAdd", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekAddRequestBody : IRequest<VirtualComchekAddRequest>
    {
        public VirtualComchekAddRequestBody() : this(new VirtualComchekAddRequest()) { }
        public VirtualComchekAddRequestBody(VirtualComchekAddRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "addRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekAddRequest Content { get; set; }
    }



    /// <summary>
    /// The Virtual Comchek Add 1.0 function is used to request a Comdata Virtual Comchek Card.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualComchekAddRequest : IRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customner Id's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Must be at least one alpha character.  No special characters or numbers.
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? FirstName { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? GLCode1 { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? GLCode2 { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? GLCode3 { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode4", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? GLCode4 { get; set; }

        /// <summary>
        /// Must be at least 3 successive alpha characters; no spaces, special characters, or numbers.
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LastName { get; set; }

        /// <summary>
        /// Restrict card to specific MCC (Merchant Category Code)
        /// </summary>
        [XmlElement(ElementName = "MCCCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? MCCCode { get; set; }

        /// <summary>
        /// Password for real-time processing.  Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? Password { get; set; }

        /// <summary>
        /// PO Number for reporting (optional)
        /// </summary>
        [XmlElement(ElementName = "PONumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? PONumber { get; set; }

        /// <summary>
        /// Prompted Driver ID (optional)
        /// </summary>
        [XmlElement(ElementName = "promptedIDDriver", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? PromptedIDDriver { get; set; }

        /// <summary>
        /// Repair Order Number (optional)
        /// </summary>
        [XmlElement(ElementName = "repairOrderNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? RepairOrderNumber { get; set; }

        /// <summary>
        /// Full 16-digit security card number.  Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "securityInfo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? SecurityInfo { get; set; }

        /// <summary>
        /// Login name for real-time processing.  Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Vehicle/Unit number (optional)
        /// </summary>
        [XmlElement(ElementName = "vehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// Vendor invoice number (optional)
        /// </summary>
        [XmlElement(ElementName = "vendorInvoiceNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? VendorInvoiceNumber { get; set; }

        /// <summary>
        /// Vendor number (optional)
        /// </summary>
        [XmlElement(ElementName = "vendorNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? VendorNumber { get; set; }

        /// <summary>
        /// Warranty period (optional)
        /// </summary>
        [XmlElement(ElementName = "warrantyPeriod", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? WarrantyPeriod { get; set; }

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForAirlineMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 20)]
        public YesNoCharFlag OpenForAirlineMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForBusinessServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 21)]
        public YesNoCharFlag OpenForBusinessServicesMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForCarRentalsMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 22)]
        public YesNoCharFlag OpenForCarRentalsMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForFinancialServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 23)]
        public YesNoCharFlag OpenForFinancialServicesMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForFuelMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 24)]
        public YesNoCharFlag OpenForFuelMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForHotelsMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 25)]
        public YesNoCharFlag OpenForHotelsMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForLegalAndInsuranceMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 26)]
        public YesNoCharFlag OpenForLegalAndInsuranceMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMaintenanceMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 27)]
        public YesNoCharFlag OpenForMaintenanceMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMedicalMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 28)]
        public YesNoCharFlag OpenForMedicalMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMiscMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 29)]
        public YesNoCharFlag OpenForMiscMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMiscTransportationMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 30)]
        public YesNoCharFlag OpenForMiscTransportationMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <summary>
        /// Y = Open; N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForRestaurantsMerchantGroup", Form = XmlSchemaForm.Unqualified, Order = 31)]
        public YesNoCharFlag OpenForRestaurantsMerchantGroup { get; set; } = YesNoCharFlag.No;  // string?

        /// <remarks/>
        [XmlElement(ElementName = "useGLCode1AsDefault", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? UseGLCode1AsDefault { get; set; }

        /// <summary>
        /// Y or YES = Yes; N or NO = No        
        /// </summary>
        /// <remarks>If no value specified, default is NO.</remarks>
        [XmlElement(ElementName = "warrantyReport", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public YesNoFlag? WarrantyReport { get; set; } = YesNoFlag.No;  // string?

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "dollarAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public Nullable<decimal> DollarAmount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode1Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public Nullable<decimal> GLCode1Amount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode2Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public Nullable<decimal> GLCode2Amount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode3Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public Nullable<decimal> GLCode3Amount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode4Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public Nullable<decimal> GLCode4Amount { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "miscCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public Nullable<decimal> MiscCost { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "totalLaborCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public Nullable<decimal> TotalLaborCost { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "totalPartsCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public Nullable<decimal> TotalPartsCost { get; set; }

        /// <summary>
        /// 9999.99
        /// </summary>
        [XmlElement(ElementName = "totalTaxCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public Nullable<decimal> TotalTaxCost { get; set; }

        /// <summary>
        /// If MM < 10 then Expiration Date in MYY or MMYY format.
        /// If MM >= 10 then Expiration Date in MMYY format.
        /// </summary>
        [XmlElement(ElementName = "expirationMMYY", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public string? ExpirationMMYY { get; set; }

        /// <summary>
        /// Valid Values 1 to 999. If the value is greater than one, 'remitType' should not be 'E' (EMAIL). This is to restrict
        /// sending multi-use virtual Comchek by Email.
        /// </summary>
        [XmlElement(ElementName = "numTransactionsAllowedForAuth", Form = XmlSchemaForm.Unqualified, Order = 44)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <summary>
        /// 0 and FALSE = False; 1 and TRUE = True
        /// </summary>
        [XmlElement(ElementName = "mustBeExactAmountForAuth", Form = XmlSchemaForm.Unqualified, Order = 45)]
        public bool MustBeExactAmountForAuth { get; set; }

        /// <summary>
        /// E = Email; M = SMS (Mobile)
        /// </summary>
        [XmlElement(ElementName = "remitType", Form = XmlSchemaForm.Unqualified, Order = 46)]
        public RemitType RemitType { get; set; } = RemitType.Email;  //string?

        /// <summary>
        /// 50 character value for Email (eg. XXX @YY.COM) OR 10 Digit Mobile Number(999999999)
        /// </summary>
        [XmlElement(ElementName = "remitValue", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public string? RemitValue { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [XmlElement(ElementName = "remitNotes", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 48)]
        public string? RemitNotes { get; set; }
    }
}
