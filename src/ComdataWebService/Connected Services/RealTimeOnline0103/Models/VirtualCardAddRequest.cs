using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
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
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualCardAdd", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualCardAddRequestBody : ISoapRequestBody<VirtualCardAddRequest>
>>>>>>> releases/v1.0.0
    {
        public VirtualCardAddRequestBody() : this(new VirtualCardAddRequest()) { }
        public VirtualCardAddRequestBody(VirtualCardAddRequest request) { Request = request; }



<<<<<<< HEAD
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
=======
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "addRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualCardAddRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualCardAdd", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualCardAddRequestBody
    {
        public VirtualCardAddRequestBody() : this(new VirtualCardAddRequest()) { }

        public VirtualCardAddRequestBody(VirtualCardAddRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "addRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualCardAddRequest Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualCardAddRequest : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? FirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? GLCode1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? GLCode2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? GLCode3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode4", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? GLCode4 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? LastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MCCCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? MCCCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "PONumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? PONumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "promptedIDDriver", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? PromptedIDDriver { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "repairOrderNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? RepairOrderNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vehicleNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? VehicleNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendorInvoiceNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? VendorInvoiceNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendorNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? VendorNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "warrantyPeriod", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? WarrantyPeriod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForAirlineMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public string? OpenForAirlineMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForBusinessServicesMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? OpenForBusinessServicesMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForCarRentalsMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? OpenForCarRentalsMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForFinancialServicesMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? OpenForFinancialServicesMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForFuelMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public string? OpenForFuelMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForHotelsMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? OpenForHotelsMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForLegalAndInsuranceMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public string? OpenForLegalAndInsuranceMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMaintenanceMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? OpenForMaintenanceMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMedicalMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public string? OpenForMedicalMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMiscMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? OpenForMiscMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMiscTransportationMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public string? OpenForMiscTransportationMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForRestaurantsMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? OpenForRestaurantsMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "useGLCode1AsDefault", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? UseGLCode1AsDefault { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "warrantyReport", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? WarrantyReport { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dollarAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public System.Nullable<decimal> DollarAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode1Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public System.Nullable<decimal> GLCode1Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode2Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 36)]
        public System.Nullable<decimal> GLCode2Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode3Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public System.Nullable<decimal> GLCode3Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode4Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public System.Nullable<decimal> GLCode4Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "miscCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public System.Nullable<decimal> MiscCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalLaborCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public System.Nullable<decimal> TotalLaborCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalPartsCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 41)]
        public System.Nullable<decimal> TotalPartsCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalTaxCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public System.Nullable<decimal> TotalTaxCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 43)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expirationMMYY", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 44)]
        public int ExpirationMMYY { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "numTransactionsAllowedForAuth", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 45)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mustBeExactAmountForAuth", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 46)]
>>>>>>> releases/v1.0.0
        public bool MustBeExactAmountForAuth { get; set; }
    }
}
