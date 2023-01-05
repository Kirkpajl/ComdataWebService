using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml.Schema;
using Comdata.Models.Internals;
using System.Diagnostics;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "CardSecurityCodeInquiryResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardSecurityCodeResponse : IResponse
    {
        /// <summary>
        /// Value assigned by Comdata
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Value assigned by Comdata. (4-digit Customer IDs will include a leading zero.)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Customer-assigned value returned in the response record
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Customer-assigned value returned in the response record
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// Full 16-digit card number unless masked
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Employee Number assigned to card.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// The 3-digit CVC2 security code; add a leading zero if this returns a 2-digit CVC2 code
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 6)]
        [XmlElement(ElementName = "cardSecurityCode", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CardSecurityCode { get; set; }



        public InquireCardSecurityCodeResponse()
        {
        }

        public InquireCardSecurityCodeResponse(string accountCode, string customerId, string discretionaryData, string trackingNumber, string cardNumber, string employeeNumber, string cardSecurityCode)
        {
            this.AccountCode = accountCode;
            this.CustomerId = customerId;
            this.DiscretionaryData = discretionaryData;
            this.TrackingNumber = trackingNumber;
            this.CardNumber = cardNumber;
            this.EmployeeNumber = employeeNumber;
            this.CardSecurityCode = cardSecurityCode;
        }
    }
}
