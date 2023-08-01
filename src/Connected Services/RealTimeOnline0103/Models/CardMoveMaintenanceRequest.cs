using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Card Move Maintenance request is used to transfer a card from one customer ID to another.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "cardMoveMaintenance", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class CardMoveMaintenanceRequestBody : IRequest<CardMoveMaintenanceRequest>
    {
        public CardMoveMaintenanceRequestBody() : this(new CardMoveMaintenanceRequest()) { }
        public CardMoveMaintenanceRequestBody(CardMoveMaintenanceRequest request) { Content = request; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "cardMoveMaintenanceRequest", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public CardMoveMaintenanceRequest Content { get; set; }
    }



    /// <summary>
    /// The Card Move Maintenance request is used to transfer a card from one customer ID to another.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class CardMoveMaintenanceRequest : IRequest
    {
        /// <summary>
        /// 5-digit Alphanumeric account code
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, Order = 1)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Any discretionary data (optional). Will be truncated to 10 characters
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// Any number (data type: long)
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 3)]
        public long? TrackingNumber { get; set; }

        /// <summary>
        /// 560017 + Card Number
        /// </summary>
        [XmlElement(ElementName = "securityCode", Form = XmlSchemaForm.Unqualified, Order = 4)]
        public string? SecurityInfo { get; set; }  //public string? SecurityCode { get; set; }

        /// <summary>
        /// 5-digit alphanumeric account code card is currently under
        /// </summary>
        [XmlElement(ElementName = "moveFromAccountCode", Form = XmlSchemaForm.Unqualified, Order = 5)]
        public string? MoveFromAccountCode { get; set; }

        /// <summary>
        /// 4- or 5-digit customer ID card is currently under
        /// </summary>
        [XmlElement(ElementName = "moveFromCustomerId", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public string? MoveFromCustomerId { get; set; }

        /// <summary>
        /// The account code under which the card should be moved
        /// </summary>
        [XmlElement(ElementName = "moveToAccountCode", Form = XmlSchemaForm.Unqualified, Order = 7)]
        public string? MoveToAccountCode { get; set; }

        /// <summary>
        /// The customer ID to which the card should be moved.
        /// </summary>
        /// <remarks>A 5-digit customer ID must be left justified.</remarks>
        [XmlElement(ElementName = "moveToCustomerId", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public string? MoveToCustomerId { get; set; }

        /// <remarks/>
        [XmlElement(ElementName = "moveSecurityCode", Form = XmlSchemaForm.Unqualified, Order = 9)]
        public string? MoveSecurityCode { get; set; }

        /// <summary>
        /// The number of the card being transferred
        /// </summary>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, Order = 10)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "signOnName", Form = XmlSchemaForm.Unqualified, Order = 11)]
        public string? SignOnName { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing.Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "password", Form = XmlSchemaForm.Unqualified, Order = 12)]
        public string? Password { get; set; }
    }
}
