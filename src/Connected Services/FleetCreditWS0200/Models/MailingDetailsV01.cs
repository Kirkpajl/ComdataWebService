﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class MailingDetailsV01
    {
        /// <summary>
        /// 1 UPS Next Day Air
        /// 2 [NOT USED]
        /// 3 UPS 2nd Day
        /// 4 FEDEX Priority
        /// 5 UPS Ground 
        /// 6 FEDEX Two Day
        /// 7 FEDEX Ground
        /// 8 USPS 
        /// 9 FEDEX International
        /// 0 UPS Worldwide Expedited
        /// </summary>
        [XmlElement(ElementName = "mailMethod", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? MailMethod { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        [XmlElement(ElementName = "mailName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? MailName { get; set; }

        /// <summary>
        /// Attention to Person
        /// </summary>
        [XmlElement(ElementName = "mailAttentionTo", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? MailAttentionTo { get; set; }

        /// <summary>
        /// Mailing Address Line 1
        /// </summary>
        [XmlElement(ElementName = "mailAddress1", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? MailAddress1 { get; set; }

        /// <summary>
        /// Mailing Address Line 2
        /// </summary>
        [XmlElement(ElementName = "mailAddress2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? MailAddress2 { get; set; }

        /// <summary>
        /// Mailing City
        /// </summary>
        [XmlElement(ElementName = "mailCity", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? MailCity { get; set; }

        /// <summary>
        /// 2-letter abbreviation for the state (US) or province (Canada)
        /// </summary>
        [XmlElement(ElementName = "mailState", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? MailState { get; set; }

        /// <summary>
        /// Mailing Zip Code
        /// </summary>
        [XmlElement(ElementName = "mailZip", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? MailZip { get; set; }
    }
}
