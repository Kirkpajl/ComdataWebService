using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Enumerations
{
    /// <summary>
    /// A=Add; C=Change; D=Delete; E=Employee Number Change
    /// </summary>
    /// <remarks>
    /// Note: If you delete an ACH entry, it will have to be added and Pre-Noted
    /// </remarks>
    public enum FunctionCodeType
    {
        /// <summary>
        /// Add
        /// </summary>
        [XmlEnum(Name = "A")]
        Add,

        /// <summary>
        /// Change
        /// </summary>
        [XmlEnum(Name = "C")]
        Change,

        /// <summary>
        /// Delete
        /// </summary>
        [XmlEnum(Name = "D")]
        Delete,

        /// <summary>
        /// Employee Number Change
        /// </summary>
        [XmlEnum(Name = "E")]
        EmployeeNumberChange
    }
}
