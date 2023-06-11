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
    [MessageContract(WrapperName = "ProprietaryIntradayRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class ProprietaryIntradayRequest : IRequest
    {
        /// <summary>
        /// Number of rows to display per page; values between 1 and 10,000; the default is 10,000.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaxRows { get; set; }

        /// <summary>
        /// Optional field which allows the reselection of transactions older than the most recent retrieval.
        /// </summary>
        /// <remarks>Note: Use of this field does not adjust the most recently retrieved transaction timestamp.</remarks>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "startDate", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartDate { get; set; }

        /// <summary>
        /// Y (yes) or N (no); the default is N.  Masked card numbers appear as follows: 123456XXXXXX1234
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag { get; set; }

        /// <summary>
        /// Searches can return up to 10,000 records per page (or maxRows).  Searches greater than maxRows are divided into pages.  Enter a page number greater than 1 to see these additional pages.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? PageNumber { get; set; }

        /// <summary>
        /// HH:MM:SS
        /// Optional field which allows the reselection of transactions older than
        /// the most recent retrieval.Note: Use of this field does not adjust the
        /// most recently retrieved transaction timestamp.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "startTime", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? StartTime { get; set; }



        public ProprietaryIntradayRequest()
        {
        }

        public ProprietaryIntradayRequest(string maxRows, string startDate, string maskCardFlag, string pageNbr, string startTime)
        {
            this.MaxRows = maxRows;
            this.StartDate = startDate;
            this.MaskCardFlag = maskCardFlag;
            this.PageNumber = pageNbr;
            this.StartTime = startTime;
        }
    }
}
