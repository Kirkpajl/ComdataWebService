using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "CustIdListingRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CustIdListingRequest : IRequest
    {
        /// <summary>
        /// 1 or more 5-digit alphanumeric account codes.  *Omit if you are pulling the list by customer IDs
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlArray(Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        [XmlArrayItem("accountCodes", Form = XmlSchemaForm.Unqualified)]
        public string[]? AccountCodes { get; set; }

        /// <summary>
        /// 1 or more 4- or 5-digit Customer IDs.  *Omit if you are pulling the list by account code
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlArray(ElementName = "customerIds", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        [XmlArrayItem("customerId", Form = XmlSchemaForm.Unqualified)]
        public string[]? CustomerIds { get; set; }

        /// <summary>
        /// Number of rows to display per page; values between 1 and 10,000; the default is 10,000
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified)]
        public int MaxRows { get; set; }

        /// <summary>
        /// Searches can return up to 10,000 records per page (or maxRows).
        /// Searches greater than maxRows are divided into pages. Enter a
        /// page number greater than 1 to see the additional pages.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified)]
        public int PageNumber { get; set; } = 1;



        public CustIdListingRequest()
        {
        }

        public CustIdListingRequest(string[] accountCodes, string[] customerIds, int maxRows, int pageNumber)
        {
            this.AccountCodes = accountCodes;
            this.CustomerIds = customerIds;
            this.MaxRows = maxRows;
            this.PageNumber = pageNumber;
        }
    }
}
