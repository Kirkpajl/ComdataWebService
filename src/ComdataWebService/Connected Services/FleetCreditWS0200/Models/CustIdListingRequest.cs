<<<<<<< HEAD
﻿using Comdata.Models.Internals;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Principal;
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
    [MessageContract(WrapperName = "CustIdListingRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CustIdListingRequest : IRequest
    {
        /// <summary>
        /// Number of rows to display per page; values between 1 and 10,000; the default is 10,000
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? MaxRows { get; set; }

        /// <summary>
        /// 1 or more 5-digit alphanumeric account codes.  *Omit if you are pulling the list by customer IDs
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlArray(Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        [XmlArrayItem("accountCodes", Form = XmlSchemaForm.Unqualified)]
        public string[]? AccountCodes { get; set; }

        /// <summary>
        /// 1 or more 4- or 5-digit Customer IDs.  *Omit if you are pulling the list by account code
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlArray(ElementName = "customerIds", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        [XmlArrayItem("customerId", Form = XmlSchemaForm.Unqualified)]
        public string[]? CustomerIds { get; set; }

        /// <summary>
        /// Searches can return up to 10,000 records per page (or maxRows).
        /// Searches greater than maxRows are divided into pages. Enter a
        /// page number greater than 1 to see the additional pages.
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "pageNbr", Form = XmlSchemaForm.Unqualified)]
        public string? PageNbr { get; set; }
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CustIdListingRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CustIdListingRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxRows", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string? maxRows;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("accountCodes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[]? accountCodes;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "customerIds", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[]? customerIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pageNbr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string? pageNbr;
>>>>>>> releases/v1.0.0



        public CustIdListingRequest()
        {
        }

        public CustIdListingRequest(string maxRows, string[] accountCodes, string[] customerIds, string pageNbr)
        {
<<<<<<< HEAD
            this.MaxRows = maxRows;
            this.AccountCodes = accountCodes;
            this.CustomerIds = customerIds;
            this.PageNbr = pageNbr;
=======
            this.maxRows = maxRows;
            this.accountCodes = accountCodes;
            this.customerIds = customerIds;
            this.pageNbr = pageNbr;
>>>>>>> releases/v1.0.0
        }
    }
}
