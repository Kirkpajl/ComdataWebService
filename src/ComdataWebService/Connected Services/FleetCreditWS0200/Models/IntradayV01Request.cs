<<<<<<< HEAD
﻿using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "IntradayRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class IntradayV01Request : IRequest
    {
        /// <summary>
        /// Number of rows to display per page; values between 1 and 10,000; the default is 10,000
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaxRows { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// Optional field which allows the reselection of transactions older than
        /// the most recent retrieval.Note: Use of this field does not adjust the
        /// most recently retrieved transaction timestamp.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "startDate", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartDate { get; set; }

        /// <summary>
        /// Y (yes) or N (no); the default is N
        /// Masked card numbers appear as follows: 123456XXXXXX1234
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag { get; set; }

        /// <summary>
        /// Searches can return up to 10,000 records per page (or maxRows).
        /// Searches greater than maxRows are divided into pages.Enter a page
        /// number greater than 1 to see these additional pages.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? PageNumber { get; set; }

        /// <summary>
        /// PD = Product Details level data will be provided.
        /// If blank, then only regular MasterCard Intraday fields will be returned.
        /// </summary>
        /// <remarks>*Note: Product Details is a future feature that is not fully available yet.</remarks>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "detailType", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? DetailType { get; set; }

        /// <summary>
        /// HH:MM:SS
        /// Optional field which allows the reselection of transactions older than
        /// the most recent retrieval.Note: Use of this field does not adjust the
        /// most recently retrieved transaction timestamp.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "startTime", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartTime { get; set; }
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "IntradayRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class IntradayV01Request
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxRows", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaxRows;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "startDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartDate;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maskCardFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? PageNbr;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "detailType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? DetailType;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "startTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartTime;
>>>>>>> releases/v1.0.0



        public IntradayV01Request()
        {
        }

        public IntradayV01Request(string maxRows, string startDate, string maskCardFlag, string pageNbr, string detailType, string startTime)
        {
            this.MaxRows = maxRows;
            this.StartDate = startDate;
            this.MaskCardFlag = maskCardFlag;
<<<<<<< HEAD
            this.PageNumber = pageNbr;
=======
            this.PageNbr = pageNbr;
>>>>>>> releases/v1.0.0
            this.DetailType = detailType;
            this.StartTime = startTime;
        }
    }
}
