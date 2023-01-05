using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class AccountCodeRecord
    {
        /// <summary>
        /// Alphanumeric value assigned by Comdata; up to 20 account codes can be submitted in a single request
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit Customer ID assigned by Comdata (4-digit Customer IDs should include a leading zero). For account codes with 500 or more customer IDs, you must enter between 1 and 20 customer IDs
        /// </summary>
        [XmlArray(ElementName = "custIdList", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        [XmlArrayItem("customerId", Form = XmlSchemaForm.Unqualified)]
        public string[] CustomerIds { get; set; } = Array.Empty<string>();



        public AccountCodeRecord() { }

        public AccountCodeRecord(string accountCode)
        {
            AccountCode = accountCode;
        }

        public AccountCodeRecord(string accountCode, string[] customerIds)
        {
            AccountCode = accountCode;
            CustomerIds = customerIds;
        }
    }
}
