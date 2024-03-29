﻿using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class CustomerProfileLimitReqRespUtil
    {
        public CustomerProfileLimitReqRespUtil() { }
        public CustomerProfileLimitReqRespUtil(string accountCode, string customerId, string discretionaryData, string trackingNumber, string profileID, int productCode)
        {
            AccountCode = accountCode;
            CustomerId = customerId;
            DiscretionaryData = discretionaryData;
            TrackingNumber = trackingNumber;
            ProfileID = profileID;
            ProductCode = productCode;
        }



        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string AccountCode { get; set; } = default!;

        /// <summary>
        /// Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string CustomerId { get; set; } = default!;

        /// <summary>
        /// Customer-assigned value returned in the response record
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Customer-assigned value returned in the response record
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// 3-digit profile ID specified by customer
        /// </summary>
        [XmlElement(ElementName = "profileID", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public string ProfileID { get; set; } = default!;

        /// <summary>
        /// 5-digit product level (merchant group or MCC)
        /// </summary>
        [XmlElement(ElementName = "productCode", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public int ProductCode { get; set; } = default!;
    }
}
