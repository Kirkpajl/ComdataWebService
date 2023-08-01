using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class AccountCodeRecord
    {
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string AccountCode { get; set; } = default!;

        /// <summary>
        /// 4- or 5-digit Customer ID assigned by Comdata (4-digit Customer
        /// IDs should include a leading zero). For account codes with 500 or
        /// more customer IDs, you must enter between 1 and 20 customer IDs
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
