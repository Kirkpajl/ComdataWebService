using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.FleetCreditWS0200.Enumerations
{
    /// <remarks/>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [XmlType(Namespace = "http://fleetCredit02.comdata.com/domain/")]
    public enum TransactionStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,

        /// <remarks/>
        All,

        /// <remarks/>
        Authorized,

        /// <remarks/>
        Posted,

        /// <remarks/>
        Declined,

        /// <remarks/>
        Credit,
    }
}
