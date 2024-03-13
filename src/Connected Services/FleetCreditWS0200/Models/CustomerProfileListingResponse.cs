using Comdata.Models.Internals;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "CustomerProfileListingResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CustomerProfileListingResponse : IResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<int> PageNumber { get; set; }

        /// <summary>
        /// Number of records returned in this request. If the recordCount is less than maxRows, this is the last set of profiles available.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "recordCount", Form = XmlSchemaForm.Unqualified)]
        public int RecordCount { get; set; } = default!;  //int?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement("records", Form = XmlSchemaForm.Unqualified)]
        public CustomerProfiles[] Records { get; set; } = Array.Empty<CustomerProfiles>();  //CustomerProfiles[]?

        /// <summary>
        /// 00000=Success, any other value = error
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified)]
        public int ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message will be: Success, if the request errored, the error description will display
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified)]
        public string ResponseDescription { get; set; } = string.Empty;



        public CustomerProfileListingResponse()
        {
        }

        public CustomerProfileListingResponse(int pageNumber, int recordCount, CustomerProfiles[] records, int responseCode, string responseDescription)
        {
            this.PageNumber = pageNumber;
            this.RecordCount = recordCount;
            this.Records = records;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
