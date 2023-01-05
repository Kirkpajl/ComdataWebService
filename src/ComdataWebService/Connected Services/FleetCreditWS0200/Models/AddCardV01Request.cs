using Comdata.Models.Internals;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "AddCardRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddCardV01Request : IRequest
    {
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "cardDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV01? CardDetails { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "mailingDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV01? MailingDetails { get; set; }

        /// <summary>
        /// Y (yes) or N (no)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag { get; set; }



        public AddCardV01Request()
        {
        }

        public AddCardV01Request(Models.CardRecordV01 cardDetails, MailingDetailsV01 mailingDetails, string maskCardFlag)
        {
            this.CardDetails = cardDetails;
            this.MailingDetails = mailingDetails;
            this.MaskCardFlag = maskCardFlag;
        }
    }
}
