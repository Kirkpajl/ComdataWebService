using Comdata.Models.Internals;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.RealTimeOnline0103.Models
{
    /// <summary>
    /// The Virtual Comchek Add 1.0 function is used to request a Comdata Virtual Comchek Card.
    /// </summary>
    [DebuggerStepThrough()]
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [MessageContract(WrapperName = "virtualComchekAddResponse", WrapperNamespace = "http://cows0103.comdata.com", IsWrapped = true)]
    public partial class VirtualComchekAddResponseBody : IResponse<VirtualComchekAddResponse>
    {
        public VirtualComchekAddResponseBody() : this(new VirtualComchekAddResponse()) { }
        public VirtualComchekAddResponseBody(VirtualComchekAddResponse response) { Content = response; }



        [MessageBodyMember(Namespace = "http://cows0103.comdata.com", Order = 0)]
        [XmlElement(ElementName = "virtualComchekAddReturn", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public VirtualComchekAddResponse Content { get; set; }
    }



    /// <summary>
    /// The Virtual Comchek Add 1.0 function is used to request a Comdata Virtual Comchek Card.
    /// </summary>
    [GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [DebuggerStepThrough()]
    [XmlType(Namespace = "http://cows0103.comdata.com")]
    public partial class VirtualComchekAddResponse : IResponse
    {
        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        [XmlElement(ElementName = "accountCode", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <summary>
        /// Full 16 digit Comdata MasterCard.        
        /// </summary>
        /// <remarks>Null value returned if card was NOT added.</remarks>
        [XmlElement(ElementName = "cardNumber", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit Customner Id's is optional.
        /// </summary>
        [XmlElement(ElementName = "customerId", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Security code value for card authenticity.
        /// </summary>
        [XmlElement(ElementName = "CVC2", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string? CVC2 { get; set; }

        /// <summary>
        /// Any discretionary data that the requestor included in the corresponding request record.
        /// </summary>
        [XmlElement(ElementName = "discretionaryData", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? DiscretionaryData { get; set; }

        /// <summary>
        /// If MM < 10 then Expiration Date in MYY format.
        /// If MM >= 10 then Expiration Date in MMYY format.
        /// </summary>
        /// <remarks>"0" returned if card was NOT added.</remarks>
        [XmlElement(ElementName = "expirationMMYY", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string? ExpirationMMYY { get; set; }

        /// <summary>
        /// 0 = OK; Anything else = error
        /// </summary>
        /// <remarks>
        /// Error Codes:  The below error codes are added newly for 'Virtual Comchek Add 1.0' webservice.  The existing error codes
        /// related to 'Virtual Card Add 1.0' are also applicable for this new 'webservice' and not listed here.
        /// 
        /// 10001 - Please enter valid remitType.  It must be E or M When 'remitType' is not supplied in the request
        /// 10002 - Please enter valid remitValue.  When 'remitValue' is not supplied in the request
        /// 10003 - Please enter valid email address in remitValue field.  When 'remitType' passed as 'E' but 'remitValue' field not having valid email address
        /// 10004 - Please enter valid phone number in remitValue field e.g. +00 0000000000.  When 'remitType' passed as 'M' and remitValue field not having valid phone number like +00 0000000000
        /// 10005 - RemitNotes field should not exceed 60 characters length.  When 'remitNotes' field exceed with 60 chars.
        /// 10006 - Please update remitType to M for Multi-Use type cards.  'RemitType' should not be EMAIL if 'numTransactionsAllowedForAuth' is greater than one.  (Restrict sending multi-use virtual Comcheck by Email)
        /// 10007 - Please enter valid Virtual Comchek AcctCode and CustId.   When the supplied acct code/cust Id does support flagged for virtual comchek card creation
        /// 10008 - Please enter valid Account Code.  When the account code is not supplied in the request
        /// 10009 - Please enter valid Cust Id.  When the cust id is not supplied in the request
        /// 99999 - Error occurred while creating Virtual Comchek card.  Exception occurred during the card creation process
        /// </remarks>
        [XmlElement(ElementName = "responseCode", Form = XmlSchemaForm.Unqualified, Order = 6)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description.
        /// </summary>
        /// <remarks>'CARD ADDED' returned if card add successful.</remarks>
        [XmlElement(ElementName = "responseMessage", Form = XmlSchemaForm.Unqualified, IsNullable = true, Order = 7)]
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Comdata assigned value attached to this response record.
        /// </summary>
        [XmlElement(ElementName = "trackingNumber", Form = XmlSchemaForm.Unqualified, Order = 8)]
        public long? TrackingNumber { get; set; }
    }
}
