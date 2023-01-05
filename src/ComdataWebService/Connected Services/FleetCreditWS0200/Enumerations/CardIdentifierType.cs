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
    public enum CardIdentifierType
    {
        [XmlEnum(Name = "T")]
        Token,

        [XmlEnum(Name = "C")]
        CardNumber,

        [XmlEnum(Name = "E")]
        Employee,


        ///// <remarks/>
        //c,

        ///// <remarks/>
        //e,

        ///// <remarks/>
        //C,

        ///// <remarks/>
        //E,

        ///// <remarks/>
        //t,

        ///// <remarks/>
        //T,
    }
}
