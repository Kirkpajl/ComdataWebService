using Comdata.Models.Internals;
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
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "AvailableCreditInquiryRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AvailableCreditInquiryRequest : IRequest
    {
        /// <summary>
        /// 1 or more 5-digit alphanumeric account codes
        /// * Need at least one account code but no more than 10.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlArray(ElementName = "accountCodes", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("accountCode", Form = XmlSchemaForm.Unqualified)]
        public string[]? AccountCodes { get; set; }

        /// <summary>
        /// True or false, default is false.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "activeAccountsOnly", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<bool> ActiveAccountsOnly { get; set; }



        public AvailableCreditInquiryRequest()
        {
        }

        public AvailableCreditInquiryRequest(string[] accountCodes, System.Nullable<bool> activeAccountsOnly)
        {
            this.AccountCodes = accountCodes;
            this.ActiveAccountsOnly = activeAccountsOnly;
        }
    }
}
