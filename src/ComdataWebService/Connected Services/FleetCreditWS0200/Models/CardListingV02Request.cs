using Comdata.FleetCreditWS0200.Enumerations;
<<<<<<< HEAD
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
    [MessageContract(WrapperName = "CardListingRequestV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CardListingV02Request : IRequest
    {

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlArray(ElementName = "acctCustidList", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        [XmlArrayItem("acctCustidElement", Form = XmlSchemaForm.Unqualified)]
        public AccountCodeRecord[]? AccountCodes { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingMaskCardFlag> MaskCardFlag { get; set; }  //string?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "status", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingStatus> Status { get; set; }  //string?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "sortOption", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingSortOption> SortOption { get; set; }

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? MaxRows { get; set; }  //string?

        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "pageNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public int? PageNumber { get; set; }  //string?
=======
using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CardListingRequestV02", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CardListingV02Request
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
>>>>>>> releases/v1.0.0



        public CardListingV02Request()
        {
        }

        public CardListingV02Request(AccountCodeRecord[] accountCodes, Nullable<CardListingMaskCardFlag> maskCardFlag, Nullable<CardListingStatus> status, Nullable<CardListingSortOption> sortOption, int maxRows, int pageNumber)
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