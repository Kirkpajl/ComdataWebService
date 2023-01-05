using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CardListingRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CardListingV01Request
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "acctCustidList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("acctCustidElement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountCodeRecord[]? AccountCodes;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maskCardFlag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingMaskCardFlag> MaskCardFlag;  //string?

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingStatus> Status;  //string?

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "sortOption", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingSortOption> SortOption;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxRows", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? MaxRows;  //string?

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? PageNumber;  //string?



        public CardListingV01Request()
        {
        }

        public CardListingV01Request(AccountCodeRecord[] accountCodes, Nullable<CardListingMaskCardFlag> maskCardFlag, Nullable<CardListingStatus> status, Nullable<CardListingSortOption> sortOption, int maxRows, int pageNumber)
        {
            this.AccountCodes = accountCodes;
            this.MaskCardFlag = maskCardFlag;
            this.Status = status;
            this.SortOption = sortOption;
            this.MaxRows = maxRows;
            this.PageNumber = pageNumber;
        }
    }
}
