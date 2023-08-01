using Comdata.FleetCreditWS0200.Enumerations;
using Comdata.Models.Internals;
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
    [MessageContract(WrapperName = "CardSecurityCodeInquiryRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardSecurityCodeRequest : IRequest
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
        /// C, E, c, or e (Card Number or Employee Number); indicates the number type used for empNumCardNumValue
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "empNumCardNumFlag", Form = XmlSchemaForm.Unqualified)]
        public EmpNumCardNumFlag EmpNumCardNumFlag { get; set; }

        /// <summary>
        /// Employee number or card number to search
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "empNumCardNumValue", Form = XmlSchemaForm.Unqualified)]
        public string EmpNumCardNumValue { get; set; } = default!;

        /// <summary>
        /// YYYY MM DD (Year Month Date)
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 6)]
        [XmlElement(ElementName = "cardExpirationDate", Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public DateTime CardExpirationDate { get; set; } = default!;

        /// <summary>
        /// Y (yes) or N (no); yes masks the full card number
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 7)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public YesNoCharFlag? MaskCardFlag { get; set; }



        public InquireCardSecurityCodeRequest()
        {
        }

        public InquireCardSecurityCodeRequest(string accountCode, string customerId, string discretionaryData, string trackingNumber,
            EmpNumCardNumFlag empNumCardNumFlag, string empNumCardNumValue,
            DateTime cardExpirationDate, YesNoCharFlag maskCardFlag)
        {
            this.AccountCode = accountCode;
            this.CustomerId = customerId;
            this.DiscretionaryData = discretionaryData;
            this.TrackingNumber = trackingNumber;
            this.EmpNumCardNumFlag = empNumCardNumFlag;
            this.EmpNumCardNumValue = empNumCardNumValue;
            this.CardExpirationDate = cardExpirationDate;
            this.MaskCardFlag = maskCardFlag;
        }
    }
}
