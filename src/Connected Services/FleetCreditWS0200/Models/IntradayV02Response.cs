﻿using Comdata.Models.Internals;
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
    [MessageContract(WrapperName = "IntradayResponseV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class IntradayV02Response : IResponse
    {
        /// <summary>
        /// Total number of pages returned for this search
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "pageCount", Form = XmlSchemaForm.Unqualified)]
        public int PageCount { get; set; }  //Nullable<int>

        /// <summary>
        /// Current page number displayed
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified)]
        public int PageNumber { get; set; }  //Nullable<int>

        /// <summary>
        /// Number of records on the page; up to 10,000 records per page
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "recordCount", Form = XmlSchemaForm.Unqualified)]
        public int RecordCount { get; set; }  //Nullable<int>

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlArray(ElementName = "records", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public IDTransactionRecordV02[] Records { get; set; } = Array.Empty<IDTransactionRecordV02>();

        /// <summary>
        /// Response code 0 indicates a successful request; all other response codes indicate errors
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified)]
        public int ResponseCode { get; set; }

        /// <summary>
        /// Description of the response code
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified)]
        public string ResponseDescription { get; set; } = string.Empty;



        public IntradayV02Response()
        {
        }

        public IntradayV02Response(int pageCount, int pageNbr, int recordCount, IDTransactionRecordV02[] records, int responseCode, string responseDescription)
        {
            this.PageCount = pageCount;
            this.PageNumber = pageNbr;
            this.RecordCount = recordCount;
            this.Records = records;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
