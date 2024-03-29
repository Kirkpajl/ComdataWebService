﻿using Comdata.FleetCreditWS0200.Enumerations;
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
    [MessageContract(WrapperName = "CardListingRequest", WrapperNamespace = "http://fleetCredit02.comdata.com/maintenance/", IsWrapped = true)]
    public partial class CardListingV01Request: IRequest
    {
        /// <summary>
        /// Alphanumeric value assigned by Comdata; up to 20 account codes can be submitted in a single request
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 0)]
        [XmlArray(ElementName = "acctCustidList", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        [XmlArrayItem("acctCustidElement", Form = XmlSchemaForm.Unqualified)]
        public AccountCodeRecord[]? AccountCodes { get; set; }

        /// <summary>
        /// Y (yes) or N (no); the default is N.  Note: The mask card setting at the user level overrides this selection
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 1)]
        [XmlElement(ElementName = "maskCardFlag", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingMaskCardFlag> MaskCardFlag { get; set; }  //string?

        /// <summary>
        /// A = active; B = blocked; C = clear; F = fraud; L = lost; S = stolen; X = permanent block; the default is all statuses
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 2)]
        [XmlElement(ElementName = "status", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingStatus> Status { get; set; }  //string?

        /// <summary>
        /// C = sort by card number; T = sort by token; default is C
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 3)]
        [XmlElement(ElementName = "sortOption", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Nullable<CardListingSortOption> SortOption { get; set; }

        /// <summary>
        /// Number of rows to display per page; values between 1 and 10,000; the default is 10,000
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 4)]
        [XmlElement(ElementName = "maxRows", Form = XmlSchemaForm.Unqualified)]
        public int MaxRows { get; set; } = 10000;

        /// <summary>
        /// Number of the page to display
        /// </summary>
        [MessageBodyMember(Namespace = "http://fleetCredit02.comdata.com/maintenance/", Order = 5)]
        [XmlElement(ElementName = "pageNumber", Form = XmlSchemaForm.Unqualified)]
        public int PageNumber { get; set; } = 1;



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
