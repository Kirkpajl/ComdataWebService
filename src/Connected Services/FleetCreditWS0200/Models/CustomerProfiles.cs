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
    public partial class CustomerProfiles
    {
        /// <summary>
        /// The ID of the profile
        /// </summary>
        [XmlElement(ElementName = "profileID", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? ProfileID { get; set; }

        /// <summary>
        /// Description of the profile
        /// </summary>
        [XmlElement(ElementName = "profileIDDescription", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? ProfileIDDescription { get; set; }
    }
}
