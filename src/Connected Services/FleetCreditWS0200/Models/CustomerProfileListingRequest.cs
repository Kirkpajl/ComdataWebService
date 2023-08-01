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
    [MessageContract(WrapperName = "CustomerProfileListingRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CustomerProfileListingRequest : IRequest
    {
        /// <summary>
        /// Value assigned by Comdata (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified)]
        public string CustomerId { get; set; } = default!;

        /// <summary>
        /// The number of profiles the user wants returned per request.Default is 50, max is 999.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified)]
        public int MaxRows { get; set; } //= 50;  //string?

        /// <summary>
        /// The pageNbr indicates which set of profiles the user
        /// wants returned.For example, if maxRows equals 50 and
        /// the user wants profiles 51 through 100 returned, then
        /// the pageNbr value should be 2.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified)]
        public int PageNumber { get; set; } = 1;  //string?



        public CustomerProfileListingRequest()
        {
        }

        public CustomerProfileListingRequest(string customerId, int maxRows = 50, int pageNumber = 1)
        {
            this.CustomerId = customerId;
            this.MaxRows = maxRows;
            this.PageNumber = pageNumber;
        }
    }
}
