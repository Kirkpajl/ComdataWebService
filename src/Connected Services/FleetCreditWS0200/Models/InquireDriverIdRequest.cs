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
    [MessageContract(WrapperName = "DriverIdInquireRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireDriverIdRequest : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "criteria", Form = XmlSchemaForm.Unqualified)]
        public DriverIdRecord Criteria { get; set; } = default!;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified)]
        public int PageNumber { get; set; }  //string?



        public InquireDriverIdRequest()
        {
        }

        public InquireDriverIdRequest(DriverIdRecord criteria, int pageNumber)
        {
            this.Criteria = criteria;
            this.PageNumber = pageNumber;
        }
    }
}
