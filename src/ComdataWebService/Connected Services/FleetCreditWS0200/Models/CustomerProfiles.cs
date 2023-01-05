using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom.Compiler;
=======
>>>>>>> releases/v1.0.0

namespace Comdata.FleetCreditWS0200.Models
{
    /// <remarks/>
<<<<<<< HEAD
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
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://fleetCredit02.comdata.com/maintenance/")]
    public partial class CustomerProfiles
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? ProfileID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "profileIDDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
>>>>>>> releases/v1.0.0
        public string? ProfileIDDescription { get; set; }
    }
}
