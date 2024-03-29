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
    [MessageContract(WrapperName = "CardInquiryResponseV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardV02Response : IResponse
    {
        /// <summary>
        /// Full 16-digit Comdata MasterCard number unless masked
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardNumber;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "cardDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardRecordV02? CardDetails;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "amountLimits", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public AmountLimits? AmountLimits;

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "mailingDetails", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public MailingDetailsV02? MailingDetails;



        public InquireCardV02Response()
        {
        }

        public InquireCardV02Response(string cardNumber, CardRecordV02 cardDetails, AmountLimits amountLimits, MailingDetailsV02 mailingDetails)
        {
            this.CardNumber = cardNumber;
            this.CardDetails = cardDetails;
            this.AmountLimits = amountLimits;
            this.MailingDetails = mailingDetails;
        }
    }
}
