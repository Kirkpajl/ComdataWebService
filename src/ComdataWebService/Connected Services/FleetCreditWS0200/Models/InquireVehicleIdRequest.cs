<<<<<<< HEAD
﻿using Comdata.Models.Internals;
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
    [MessageContract(WrapperName = "VehicleIdInquireRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireVehicleIdRequest : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "criteria", Form = XmlSchemaForm.Unqualified)]
        public VehicleIdRecord? Criteria { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? PageNbr { get; set; }
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "VehicleIdInquireRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireVehicleIdRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "criteria", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VehicleIdRecord? Criteria;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? PageNbr;
>>>>>>> releases/v1.0.0



        public InquireVehicleIdRequest()
        {
        }

        public InquireVehicleIdRequest(VehicleIdRecord criteria, string pageNbr)
        {
            this.Criteria = criteria;
            this.PageNbr = pageNbr;
        }
    }
}
