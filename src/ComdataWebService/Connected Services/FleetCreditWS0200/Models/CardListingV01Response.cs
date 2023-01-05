using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CardListingResponse", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CardListingV01Response
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageCount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<int> PageCount;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<int> PageNbr;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "recordCount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<int> RecordCount;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "records", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("card", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CardListingRecordV01[]? Records;



        public CardListingV01Response()
        {
        }

        public CardListingV01Response(System.Nullable<int> pageCount, System.Nullable<int> pageNbr, System.Nullable<int> recordCount, CardListingRecordV01[] records)
        {
            this.PageCount = pageCount;
            this.PageNbr = pageNbr;
            this.RecordCount = recordCount;
            this.Records = records;
        }
    }
}
