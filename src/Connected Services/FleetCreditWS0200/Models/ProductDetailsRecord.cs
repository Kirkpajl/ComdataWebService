using System;
using System.Collections.Generic;
using System.Text;
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
    public partial class ProductDetailsRecord
    {
        /// <summary>
        /// Transaction Identifier
        /// </summary>
        [XmlElement(ElementName = "transactionIdentifier", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? TransactionIdentifier { get; set; }

        /// <summary>
        /// Product Code
        /// </summary>
        [XmlElement(ElementName = "productCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Product Type Code
        /// </summary>
        [XmlElement(ElementName = "productTypeCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? ProductTypeCode { get; set; }

        /// <summary>
        /// Product Description
        /// </summary>
        [XmlElement(ElementName = "productDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? ProductDescription { get; set; }

        /// <summary>
        /// Issue Quantity, AC file lists it as productQuantity
        /// </summary>
        [XmlElement(ElementName = "productQuantity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public Nullable<double> ProductQuantity { get; set; }

        /// <summary>
        /// Credit or Debit C or D
        /// </summary>
        [XmlElement(ElementName = "creditOrDebit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? CreditOrDebit { get; set; }

        /// <summary>
        /// Gross Cost Price
        /// </summary>
        [XmlElement(ElementName = "grossCostPrice", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public Nullable<double> GrossCostPrice { get; set; }

        /// <summary>
        /// Base Price Per Unit
        /// </summary>
        [XmlElement(ElementName = "basePricePerUnit", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public Nullable<double> BasePricePerUnit { get; set; }

        /// <summary>
        /// Product Price - Net Due
        /// </summary>
        [XmlElement(ElementName = "productPrice", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public Nullable<double> ProductPrice { get; set; }

        /// <summary>
        /// Product Total Cost - Net Due
        /// </summary>
        [XmlElement(ElementName = "productTotalCost", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public double ProductTotalCost { get; set; }

        /// <summary>
        /// Tax Amount 1
        /// </summary>
        [XmlElement(ElementName = "taxAmount1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public Nullable<double> TaxAmount1 { get; set; }

        /// <summary>
        /// Tax Rate 1
        /// </summary>
        [XmlElement(ElementName = "taxRate1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public Nullable<double> TaxRate1 { get; set; }

        /// <summary>
        /// Tax ID 1
        /// </summary>
        [XmlElement(ElementName = "taxId1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public string? TaxId1 { get; set; }

        /// <summary>
        /// Tax Amount 2
        /// </summary>
        [XmlElement(ElementName = "taxAmount2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public Nullable<double> TaxAmount2 { get; set; }

        /// <summary>
        /// Tax Rate 2
        /// </summary>
        [XmlElement(ElementName = "taxRate2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public Nullable<double> TaxRate2 { get; set; }

        /// <summary>
        /// Tax ID 2
        /// </summary>
        [XmlElement(ElementName = "taxId2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public string? TaxId2 { get; set; }

        /// <summary>
        /// Tax Amount 3
        /// </summary>
        [XmlElement(ElementName = "taxAmount3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 16)]
        public Nullable<double> TaxAmount3 { get; set; }

        /// <summary>
        /// Tax Rate 3
        /// </summary>
        [XmlElement(ElementName = "taxRate3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 17)]
        public Nullable<double> TaxRate3 { get; set; }

        /// <summary>
        /// Tax ID 3
        /// </summary>
        [XmlElement(ElementName = "taxId3", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public string? TaxId3 { get; set; }

        /// <summary>
        /// Merchant Discount Indicator
        /// </summary>
        [XmlElement(ElementName = "merchantDiscountIndicator", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 19)]
        public string? MerchantDiscountIndicator { get; set; }

        /// <summary>
        /// Merchant Discount amount Net
        /// </summary>
        [XmlElement(ElementName = "merchantDiscountAmountNet", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 20)]
        public Nullable<double> MerchantDiscountAmountNet { get; set; }

        /// <summary>
        /// Rebate Indicator
        /// </summary>
        [XmlElement(ElementName = "rebateIndicator", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public string? RebateIndicator { get; set; }

        /// <summary>
        /// Rebate amount Net
        /// </summary>
        [XmlElement(ElementName = "rebateAmountNet", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 22)]
        public Nullable<double> RebateAmountNet { get; set; }

        /// <summary>
        /// Unit Of Measure
        /// </summary>
        [XmlElement(ElementName = "unitOfMeasure", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 23)]
        public string? UnitOfMeasure { get; set; }

        /// <summary>
        /// Odometer Reading
        /// </summary>
        [XmlElement(ElementName = "odometerReading", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 24)]
        public Nullable<double> OdometerReading { get; set; }
    }
}
