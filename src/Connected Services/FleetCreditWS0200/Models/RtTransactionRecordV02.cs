using Comdata.FleetCreditWS0200.Enumerations;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Transactions;
using TransactionStatus = Comdata.FleetCreditWS0200.Enumerations.TransactionStatus;
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
    public partial class RtTransactionRecordV02 : RtTransactionRecordV01
    {
        /// <summary>
        /// Latitude of the merchant
        /// </summary>
        /// <remarks>*Note: Future field not fully available yet.</remarks>
        [XmlElement(ElementName = "latitude", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 30)]
        public string? Latitude { get; set; }

        /// <summary>
        /// Longitude of the merchant
        /// </summary>
        /// <remarks>*Note: Future field not fully available yet.</remarks>
        [XmlElement(ElementName = "longitude", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 31)]
        public string? Longitude { get; set; }

        /// <summary>
        /// The employee number associated with the cardNumber
        /// </summary>
        [XmlElement(ElementName = "employeeNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 32)]
        public string? EmployeeNumber { get; set; }
    }
}
