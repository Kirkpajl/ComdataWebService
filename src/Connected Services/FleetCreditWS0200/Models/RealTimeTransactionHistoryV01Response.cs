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
    [MessageContract(WrapperName = "RtTransactionResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class RealTimeTransactionHistoryV01Response : IResponse
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "pageCount", Form = XmlSchemaForm.Unqualified)]
        public int PageCount { get; set; }  //Nullable<int>

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified)]
        public int PageNumber { get; set; }  //Nullable<int>

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "recordCount", Form = XmlSchemaForm.Unqualified)]
        public int RecordCount { get; set; }  //Nullable<int>

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlArray(ElementName = "records", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public RtTransactionRecordV01[] Records { get; set; } = Array.Empty<RtTransactionRecordV01>();

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified)]
        public int ResponseCode { get; set; }  //string?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified)]
        public string ResponseDescription { get; set; } = default!;



        public RealTimeTransactionHistoryV01Response()
        {
        }

        public RealTimeTransactionHistoryV01Response(int pageCount, int pageNumber, int recordCount, RtTransactionRecordV01[] records, int responseCode, string responseDescription)
        {
            this.PageCount = pageCount;
            this.PageNumber = pageNumber;
            this.RecordCount = recordCount;
            this.Records = records;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
