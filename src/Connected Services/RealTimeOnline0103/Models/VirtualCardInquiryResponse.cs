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
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualCardInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualCardInquiryResponseBody : IResponse //ISoapResponseBody<VirtualCardInquiryResponse>
    {
        public VirtualCardInquiryResponseBody() : this(new VirtualCardInquiryResponse()) { }
        public VirtualCardInquiryResponseBody(VirtualCardInquiryResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "virtualCardInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualCardInquiryResponse Content { get; set; }
    }

    /*[DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualCardInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualCardInquiryResponseBody
    {
        public VirtualCardInquiryResponseBody() : this(new VirtualCardInquiryResponse()) { }

        public VirtualCardInquiryResponseBody(VirtualCardInquiryResponse response)
        {
            this.Response = response;
        }



<<<<<<< HEAD
        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "virtualCardInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
=======
        [MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElementAttribute(ElementName = "virtualCardInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
>>>>>>> releases/v1.0.0
        public VirtualCardInquiryResponse Response { get; set; }
    }*/



    /// <summary>
    /// The Virtual Card Inquiry 1.0 function is used to inquire the current attributes of an existing Comdata Virtual
    /// MasterCard.  No card updates are performed.  It is an information only request.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualCardInquiryResponse  // : ISoapResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Full 16 digit Comdata MasterCard number.
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "cardStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CardStatus { get; set; }

        /// <summary>
        /// Value assigned by Comdata.  (4 digit Customer Id's MUST include leading zero).
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Security code value for card authenticity.
        /// </summary>
        /// <remarks>0 will be returned if card doesn't exist.</remarks>
        [XmlElement(ElementName = "CVC2", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public short CVC2 { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor would like returned in the response record. (optional)
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "dollarAmount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public Nullable<decimal> DollarAmount { get; set; }

        /// <summary>
        /// If MM < 10 then Expiration Date in MYY format.
        /// If MM >= 10 then Expiration Date in MMYY format.
        /// </summary>
        /// <remarks>
        /// "0" returned if invalid card number.
        /// </remarks>
        [XmlElement(ElementName = "expirationMMYY", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public int ExpirationMMYY { get; set; }

        /// <summary>
        /// Value assigned to the First Name field
        /// </summary>
        [XmlElement(ElementName = "firstName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? FirstName { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? GLCode1 { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode1Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public Nullable<decimal> GLCode1Amount { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? GLCode2 { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode2Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public Nullable<decimal> GLCode2Amount { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? GLCode3 { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode3Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public Nullable<decimal> GLCode3Amount { get; set; }

        /// <summary>
        /// GL Code value
        /// </summary>
        [XmlElement(ElementName = "GLCode4", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? GLCode4 { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "GLCode4Amount", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public Nullable<decimal> GLCode4Amount { get; set; }

        /// <summary>
        /// Value assigned to the Last Name field
        /// </summary>
        [XmlElement(ElementName = "lastName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? LastName { get; set; }

        /// <summary>
        /// MCC Code assigned to card (if any)
        /// </summary>
        [XmlElement(ElementName = "MCCCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? MCCCode { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "miscCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public Nullable<decimal> MiscCost { get; set; }

        /// <summary>
        /// Value assigned to card from 1 to 999. 0 will be returned if card doesn't exist.
        /// </summary>
        [XmlElement(ElementName = "numTransactionsAllowedForAuth", Form = XmlSchemaForm.Unqualified, Order = 20)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForAirlineMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public YesNoCharFlag? OpenForAirlineMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForBusinessServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public YesNoCharFlag? OpenForBusinessServicesMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForCarRentalsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public YesNoCharFlag? OpenForCarRentalsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForFinancialServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public YesNoCharFlag? OpenForFinancialServicesMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForFuelMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public YesNoCharFlag? OpenForFuelMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForHotelsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public YesNoCharFlag? OpenForHotelsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForLegalAndInsuranceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public YesNoCharFlag? OpenForLegalAndInsuranceMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMaintenanceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public YesNoCharFlag? OpenForMaintenanceMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMedicalMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public YesNoCharFlag? OpenForMedicalMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMiscMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public YesNoCharFlag? OpenForMiscMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMiscTransportationMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public YesNoCharFlag? OpenForMiscTransportationMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForRestaurantsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public YesNoCharFlag? OpenForRestaurantsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// PO Number for reporting
        /// </summary>
        [XmlElement(ElementName = "PONumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? PONumber { get; set; }

        /// <summary>
        /// Prompted Driver ID
        /// </summary>
        [XmlElement(ElementName = "promptedIDDriver", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public string? PromptedIDDriver { get; set; }

        /// <summary>
        /// Repair Order Number
        /// </summary>
        [XmlElement(ElementName = "repairOrderNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? RepairOrderNumber { get; set; }

        /// <summary>
        /// 0 = OK; Anything else = Error
        /// </summary>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 36)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.  'INQUIRY SUCCESSFUL' returned if card inquiry successful.
        /// </summary>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "totalLaborCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public Nullable<decimal> TotalLaborCost { get; set; }

        /// <summary>
        /// 9999999.99
        /// </summary>
        [XmlElement(ElementName = "totalPartsCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public Nullable<decimal> TotalPartsCost { get; set; }

        /// <summary>
        /// 9999.99
        /// </summary>
        [XmlElement(ElementName = "totalTaxCost", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public Nullable<decimal> TotalTaxCost { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 41)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "useGLCode1AsDefault", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public YesNoCharFlag? UseGLCode1AsDefault { get; set; }  // string?

        /// <summary>
        /// Vehicle/Unit number
        /// </summary>
        [XmlElement(ElementName = "vehicleNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// Vendor invoice number
        /// </summary>
        [XmlElement(ElementName = "vendorInvoiceNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public string? VendorInvoiceNumber { get; set; }

        /// <summary>
        /// Vendor number
        /// </summary>
        [XmlElement(ElementName = "vendorNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public string? VendorNumber { get; set; }

        /// <summary>
        /// Warranty period
        /// </summary>
        [XmlElement(ElementName = "warrantyPeriod", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? WarrantyPeriod { get; set; }

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "warrantyReport", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public YesNoCharFlag? WarrantyReport { get; set; }  // string?

        /// <summary>
        /// 0 = No 1 = True
        /// </summary>
        [XmlElement(ElementName = "mustBeExactAmountForAuth", Form = XmlSchemaForm.Unqualified, Order = 48)]
        public bool MustBeExactAmountForAuth { get; set; }
    }
}
