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
    [MessageContract(WrapperName = "VehicleIdInquireResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireVehicleIdResponse : IResponse
    {
        /// <summary>
        /// Number of pages in the search result
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "pageCount", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<int> PageCount { get; set; }

        /// <summary>
        /// Current page in the search result; value of <= 6 digits
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<int> PageNbr { get; set; }

        /// <summary>
        /// Number of records (<= 50) in the current page
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "recordCount", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<int> RecordCount { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlArray(ElementName = "records", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        [XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
        public VehicleIdSearchRecord[]? Records { get; set; }

        /// <summary>
        /// 0=Success Anything Else=Error
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified)]
        public string? ResponseCode { get; set; }

        /// <summary>
        /// If the request succeeded, the message should be: OK
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "responseDescription", Form = XmlSchemaForm.Unqualified)]
        public string? ResponseDescription { get; set; }



        public InquireVehicleIdResponse()
        {
        }

        public InquireVehicleIdResponse(System.Nullable<int> pageCount, System.Nullable<int> pageNbr, System.Nullable<int> recordCount, VehicleIdSearchRecord[] records, string responseCode, string responseDescription)
        {
            this.PageCount = pageCount;
            this.PageNbr = pageNbr;
            this.RecordCount = recordCount;
            this.Records = records;
            this.ResponseCode = responseCode;
            this.ResponseDescription = responseDescription;
        }
    }
}
