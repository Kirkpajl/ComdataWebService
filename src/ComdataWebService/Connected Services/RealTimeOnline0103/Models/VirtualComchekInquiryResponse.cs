﻿using Comdata.Models.Internals;
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
using System.Collections;
using System.Reflection.Emit;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Virtual Comchek Inquiry 1.0 function is used to inquire the current attributes of an existing Comdata Virtual
    /// Comchek.  No card updates are performed.It is an information only request.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualComchekInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekInquiryResponseBody : IResponse //ISoapResponseBody<VirtualComchekInquiryResponse>
    {
        public VirtualComchekInquiryResponseBody() : this(new VirtualComchekInquiryResponse()) { }
        public VirtualComchekInquiryResponseBody(VirtualComchekInquiryResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "virtualComchekInquiryReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekInquiryResponse Content { get; set; }
    }



    /// <summary>
    /// The Virtual Comchek Inquiry 1.0 function is used to inquire the current attributes of an existing Comdata Virtual
    /// Comchek.  No card updates are performed.It is an information only request.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualComchekInquiryResponse  // : ISoapResponse
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

        /// <summary>
        /// A = Active; B = Blocked; F = Fraud; S = Stolen
        /// </summary>
        [XmlElement(ElementName = "cardStatus", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public VirtualCardStatusType? CardStatus { get; set; }  //string?

        /// <summary>
        /// Value assigned by Comdata. (4-digit Customer IDs MUST include leading zero.)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Security code value for card authenticity. Zero will be returned if card does not exist.
        /// </summary>
        [XmlElement(ElementName = "CVC2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CVC2 { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the corresponding request record.
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
        /// <remarks>"0" returned if invalid card number.</remarks>
        [XmlElement(ElementName = "expirationMMYY", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ExpirationMMYY { get; set; }

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
        /// Value assigned to card from 1 to 999. 0 will be returned if card does not exist
        /// </summary>
        [XmlElement(ElementName = "numTransactionsAllowedForAuth", Form = XmlSchemaForm.Unqualified, Order = 20)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForAirlineMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public YesNoCharFlag OpenForAirlineMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForBusinessServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public YesNoCharFlag OpenForBusinessServicesMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForCarRentalsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public YesNoCharFlag OpenForCarRentalsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForFinancialServicesMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public YesNoCharFlag OpenForFinancialServicesMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForFuelMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public YesNoCharFlag OpenForFuelMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForHotelsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public YesNoCharFlag OpenForHotelsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForLegalAndInsuranceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public YesNoCharFlag OpenForLegalAndInsuranceMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMaintenanceMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public YesNoCharFlag OpenForMaintenanceMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMedicalMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public YesNoCharFlag OpenForMedicalMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMiscMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public YesNoCharFlag OpenForMiscMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForMiscTransportationMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public YesNoCharFlag OpenForMiscTransportationMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Y = Yes; N = No
        /// </summary>
        [XmlElement(ElementName = "openForRestaurantsMerchantGroup", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public YesNoCharFlag OpenForRestaurantsMerchantGroup { get; set; }  // string?

        /// <summary>
        /// Purchase Order number for reporting
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
        /// <remarks>
        /// Error Codes:  The below error codes are added newly for 'Virtual Comchek Inquiry 1.0' webservice. The existing error
        /// codes related to 'Virtual Card Inquiry 1.0' is also applicable for this new 'webservice' and not listed here.
        /// 
        /// 10007 - Please enter valid Virtual Comchek AcctCode and CustId - When the supplied acc code/cust Id doesn't support flagged for virtual comchek card creation
        /// 10008 - Please enter valid Account Code - When the account code is not supplied in the request
        /// 10009 - Please enter valid Cust Id - When the cust id is not supplied in the request
        /// 99999 - Error occurred while Inquiring Virtual Comchek card - Exception occurred during the card inquiring process
        /// </remarks>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 36)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description. "INQUIRY SUCCESSFUL" returned if card inquiry successful.
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
        public YesNoCharFlag UseGLCode1AsDefault { get; set; }  // string?

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
        public YesNoCharFlag WarrantyReport { get; set; }  //string?

        /// <summary>
        /// 0 = False; 1 = True
        /// </summary>
        /// <remarks>"0" will be returned if card does not exist.</remarks>
        [XmlElement(ElementName = "mustBeExactAmountForAuth", Form = XmlSchemaForm.Unqualified, Order = 48)]
        public bool MustBeExactAmountForAuth { get; set; }

        /// <summary>
        /// E = Email (or) M = SMS (Mobile)
        /// </summary>
        [XmlElement(ElementName = "remitType", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public RemitType RemitType { get; set; }  // string?

        /// <summary>
        /// 50 character value for Email (eg. XXX@YY.COM) OR 10 Digit Mobile Number(999999999)
        /// </summary>
        [XmlElement(ElementName = "remitValue", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public string? RemitValue { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [XmlElement(ElementName = "remitNotes", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
=======

namespace Comdata.RealTimeOnline0103.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualComchekInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekInquiryResponseBody : ISoapResponseBody<VirtualComchekInquiryResponse>
    {
        public VirtualComchekInquiryResponseBody() : this(new VirtualComchekInquiryResponse()) { }
        public VirtualComchekInquiryResponseBody(VirtualComchekInquiryResponse response) { Response = response; }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "virtualComchekInquiryReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekInquiryResponse Response { get; set; }
    }

    /*[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "virtualComchekInquiryResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekInquiryResponseBody
    {
        public VirtualComchekInquiryResponseBody() : this(new VirtualComchekInquiryResponse()) { }

        public VirtualComchekInquiryResponseBody(VirtualComchekInquiryResponse response)
        {
            this.Response = response;
        }



        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "virtualComchekInquiryReturn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekInquiryResponse Response { get; set; }
    }*/



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualComchekInquiryResponse : ISoapResponse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CardStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "CVC2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? CVC2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dollarAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public System.Nullable<decimal> DollarAmount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expirationMMYY", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ExpirationMMYY { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? FirstName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? GLCode1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode1Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public System.Nullable<decimal> GLCode1Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string? GLCode2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode2Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public System.Nullable<decimal> GLCode2Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public string? GLCode3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode3Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public System.Nullable<decimal> GLCode3Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode4", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? GLCode4 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "GLCode4Amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public System.Nullable<decimal> GLCode4Amount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public string? LastName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MCCCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? MCCCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "miscCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public System.Nullable<decimal> MiscCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "numTransactionsAllowedForAuth", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public short NumTransactionsAllowedForAuth { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForAirlineMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? OpenForAirlineMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForBusinessServicesMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public string? OpenForBusinessServicesMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForCarRentalsMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? OpenForCarRentalsMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForFinancialServicesMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public string? OpenForFinancialServicesMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForFuelMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 25)]
        public string? OpenForFuelMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForHotelsMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 26)]
        public string? OpenForHotelsMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForLegalAndInsuranceMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 27)]
        public string? OpenForLegalAndInsuranceMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMaintenanceMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 28)]
        public string? OpenForMaintenanceMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMedicalMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 29)]
        public string? OpenForMedicalMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMiscMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public string? OpenForMiscMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForMiscTransportationMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? OpenForMiscTransportationMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "openForRestaurantsMerchantGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? OpenForRestaurantsMerchantGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "PONumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 33)]
        public string? PONumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "promptedIDDriver", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 34)]
        public string? PromptedIDDriver { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "repairOrderNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 35)]
        public string? RepairOrderNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 36)]
        public int? ResponseCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 37)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalLaborCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 38)]
        public System.Nullable<decimal> TotalLaborCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalPartsCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 39)]
        public System.Nullable<decimal> TotalPartsCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalTaxCost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 40)]
        public System.Nullable<decimal> TotalTaxCost { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 41)]
        public long? TrackingNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "useGLCode1AsDefault", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 42)]
        public string? UseGLCode1AsDefault { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vehicleNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 43)]
        public string? VehicleNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendorInvoiceNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 44)]
        public string? VendorInvoiceNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendorNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 45)]
        public string? VendorNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "warrantyPeriod", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 46)]
        public string? WarrantyPeriod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "warrantyReport", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 47)]
        public string? WarrantyReport { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mustBeExactAmountForAuth", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 48)]
        public bool MustBeExactAmountForAuth { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "remitType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 49)]
        public string? RemitType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "remitValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 50)]
        public string? RemitValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "remitNotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 51)]
>>>>>>> releases/v1.0.0
        public string? RemitNotes { get; set; }
    }
}
