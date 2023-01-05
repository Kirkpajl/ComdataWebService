using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualComchekUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekUpdateRequestBody : ISoapRequestBody<VirtualComchekUpdateRequest>
    {
        public VirtualComchekUpdateRequestBody() : this(new VirtualComchekUpdateRequest()) { }
        public VirtualComchekUpdateRequestBody(VirtualComchekUpdateRequest request) { Request = request; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "updateRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekUpdateRequest Request { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualComchekUpdate", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekUpdateRequestBody
    {
        public VirtualComchekUpdateRequestBody() : this(new VirtualComchekUpdateRequest()) { }

        public VirtualComchekUpdateRequestBody(VirtualComchekUpdateRequest request)
        {
            this.Request = request;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "updateRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekUpdateRequest Request { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualComchekUpdateRequest : ISoapRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? DiscretionaryData { get; set; }

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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MCCCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? MCCCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? Password { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "PONumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? PONumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "promptedIDDriver", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? PromptedIDDriver { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "repairOrderNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? RepairOrderNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "securityInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? SecurityInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "signOnName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string? SignOnName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vehicleNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? VehicleNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendorInvoiceNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public string? VendorInvoiceNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendorNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? VendorNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "warrantyPeriod", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? WarrantyPeriod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? CardStatus { get; set; }

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
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "numTransactionsAllowedForAuth", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 43)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mustBeExactAmountForAuth", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 44)]
        public bool MustBeExactAmountForAuth { get; set; }
    }
}
