using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using Comdata.RealTimeOnline0103.Enumerations;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Virtual Card Add 1.0 function is used to request a Comdata Virtual MasterCard.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualCardAdd", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualCardAddRequestBody : IRequest  //ISoapRequestBody<VirtualCardAddRequest>
    {
        public VirtualCardAddRequestBody() : this(new VirtualCardAddRequest()) { }
        public VirtualCardAddRequestBody(VirtualCardAddRequest request) { Request = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "addRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualCardAddRequest Request { get; set; }
    }



    /// <summary>
    /// The Virtual Card Add 1.0 function is used to request a Comdata Virtual MasterCard.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualCardAddRequest// : ISoapRequest
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customer Id's is optional.
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
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForAirlineMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public YesNoCharFlag OpenForAirlineMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForBusinessServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public YesNoCharFlag OpenForBusinessServicesMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForCarRentalsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public YesNoCharFlag OpenForCarRentalsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForFinancialServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public YesNoCharFlag OpenForFinancialServicesMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForFuelMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public YesNoCharFlag OpenForFuelMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForHotelsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public YesNoCharFlag OpenForHotelsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForLegalAndInsuranceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public YesNoCharFlag OpenForLegalAndInsuranceMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMaintenanceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public YesNoCharFlag OpenForMaintenanceMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMedicalMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public YesNoCharFlag OpenForMedicalMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMiscMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public YesNoCharFlag OpenForMiscMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForMiscTransportationMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public YesNoCharFlag OpenForMiscTransportationMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Open N = Closed
        /// </summary>
        [XmlElement(ElementName = "openForRestaurantsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public YesNoCharFlag OpenForRestaurantsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y or YES = Yes; N or NO = No        
        /// </summary>
        /// <remarks>If no value specified, default is NO.</remarks>
        [XmlElement(ElementName = "useGLCode1AsDefault", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public YesNoCharFlag? UseGLCode1AsDefault { get; set; }  // string?

        /// <summary>
        /// Y or YES = Yes; N or NO = No        
        /// </summary>
        /// <remarks>If no value specified, default is NO.</remarks>
        [XmlElement(ElementName = "warrantyReport", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public YesNoCharFlag? WarrantyReport { get; set; }  // string?

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
        /// Any Number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 43)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// If MM < 10 then Expiration Date in MYY or MMYY format.
        /// If MM >= 10 then Expiration Date in MMYY format.
        /// </summary>
                [XmlElement(ElementName = "expirationMMYY", Form = XmlSchemaForm.Unqualified, Order = 44)]
        public int ExpirationMMYY { get; set; }

        /// <summary>
        /// Valid Values 1 to 999.
        /// </summary>
        [XmlElement(ElementName = "numTransactionsAllowedForAuth", Form = XmlSchemaForm.Unqualified, Order = 45)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <summary>
        /// 0 and FALSE = False; 1 and TRUE = True
        /// </summary>
        [XmlElement(ElementName = "mustBeExactAmountForAuth", Form = XmlSchemaForm.Unqualified, Order = 46)]
        public bool MustBeExactAmountForAuth { get; set; }
    }
}
