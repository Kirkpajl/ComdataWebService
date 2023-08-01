using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System.Collections;
using Comdata.FleetCreditWS0200.Enumerations;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "IntradayRequestV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class IntradayV02Request : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? MaxRows { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "startDate", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartDate { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public YesNoCharFlag? MaskCardFlag { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? PageNumber { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "detailType", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public IntradayDetailType? DetailType { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "startTime", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartTime { get; set; }



        public IntradayV02Request()
        {
        }

        public IntradayV02Request(DateTime? start, IntradayDetailType detailType, YesNoCharFlag maskCardFlag, int maxRows, int pageNumber)
        {
            this.StartDate = start?.ToString("yyyy-MM-dd");
            this.StartTime = start?.ToString("HH:mm:ss");
            this.DetailType = detailType;
            this.MaxRows = maxRows;
            this.MaskCardFlag = maskCardFlag;
            this.PageNumber = pageNumber;
        }
    }
}
