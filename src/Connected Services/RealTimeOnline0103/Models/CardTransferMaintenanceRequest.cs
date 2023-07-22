using Comdata.Models.Internals;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "transferMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardTransferMaintenanceRequestBody : IRequest<CardTransferMaintenanceRequest>
    {
        public CardTransferMaintenanceRequestBody() : this(new CardTransferMaintenanceRequest()) { }
        public CardTransferMaintenanceRequestBody(CardTransferMaintenanceRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "transferMaintenanceRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardTransferMaintenanceRequest Content { get; set; }
    }



    /// <summary>
    /// The Card Transfer Maintenance request is used to transfer card values from one card to an unassigned card
    /// under the same account code and customer ID.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardTransferMaintenanceRequest : IRequest
    {
        /// <summary>
        /// 5-digit alphanumeric account code
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID under which the card was assigned
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data (optional). Will be truncated to 10 characters.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Any number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public Nullable<long> TrackingNumber { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing. Value assigned by Comdata. [source: SEC1 O1]
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? Password { get; set; }

        /// <summary>
        /// 560017 + Card Number
        /// </summary>
        [XmlElement(ElementName = "securityCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string? SecurityInfo { get; set; }  //public string? SecurityCode { get; set; }

        /// <summary>
        /// The account code under which the cards are assigned
        /// </summary>
        [XmlElement(ElementName = "cardAccountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? CardAccountCode { get; set; }

        /// <summary>
        /// The customer ID under which the cards are assigned.
        /// </summary>
        /// <remarks>
        /// For a 4-digit customer ID, include a leading zero.
        /// A 5-digit customer ID must be left justified
        /// </remarks>
        [XmlElement(ElementName = "cardCustomerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string? CardCustomerId { get; set; }

        /// <summary>
        /// The number of the card being transferred.
        /// </summary>
        [XmlElement(ElementName = "transferFromCardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string? TransferFromCardNumber { get; set; }

        /// <summary>
        /// The number of the card receiving the data transferred.
        /// </summary>
        [XmlElement(ElementName = "transferToCardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public string? TransferToCardNumber { get; set; }
    }
}
