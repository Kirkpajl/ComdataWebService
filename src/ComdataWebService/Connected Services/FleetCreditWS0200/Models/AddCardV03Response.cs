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
    [MessageContract(WrapperName = "AddCardResponseV03", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class AddCardV03Response : IResponse
    {
        /// <summary>
        /// Full 16-digit Comdata MasterCard number
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardNumber;

        /// <summary>
        /// Card security code
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "cardSecurityCode", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardSecurityCode;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "cardDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV03? CardDetails;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "amountLimits", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public AmountLimits? AmountLimits;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "mailingDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV02? MailingDetails;



        public AddCardV03Response()
        {
        }

        public AddCardV03Response(string cardNumber, string cardSecurityCode, CardRecordV03 cardDetails, AmountLimits amountLimits, MailingDetailsV02 mailingDetails)
        {
            this.CardNumber = cardNumber;
            this.CardSecurityCode = cardSecurityCode;
            this.CardDetails = cardDetails;
            this.AmountLimits = amountLimits;
            this.MailingDetails = mailingDetails;
        }
    }
}
