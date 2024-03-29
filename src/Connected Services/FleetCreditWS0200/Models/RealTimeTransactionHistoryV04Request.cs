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
    [MessageContract(WrapperName = "RtTransactionRequestV04", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class RealTimeTransactionHistoryV04Request : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "criteria", Form = XmlSchemaForm.Unqualified)]
        public RtTransactionCriteriaV04 Criteria { get; set; } = default!;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? PageNumber { get; set; }



        public RealTimeTransactionHistoryV04Request()
        {
        }

        public RealTimeTransactionHistoryV04Request(RtTransactionCriteriaV04 criteria, int pageNumber)
        {
            this.Criteria = criteria;
            this.PageNumber = pageNumber;
        }
    }
}
