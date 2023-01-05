using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CardSecurityCodeInquiryRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class InquireCardSecurityCodeRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? AccountCode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? CustomerId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? DiscretionaryData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? TrackingNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<EmpNumCardNumFlag> EmpNumCardNumFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "empNumCardNumValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? EmpNumCardNumValue;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cardExpirationDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> CardExpirationDate;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 7)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maskCardFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaskCardFlag;



        public InquireCardSecurityCodeRequest()
        {
        }

        public InquireCardSecurityCodeRequest(string accountCode, string customerId, string discretionaryData, string trackingNumber, System.Nullable<EmpNumCardNumFlag> empNumCardNumFlag, string empNumCardNumValue, System.Nullable<System.DateTime> cardExpirationDate, string maskCardFlag)
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
