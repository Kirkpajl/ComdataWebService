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
        public string? AccountCode { get; set; }

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
