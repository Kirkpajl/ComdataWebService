using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class AccountCodeRecord
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "custIdList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
