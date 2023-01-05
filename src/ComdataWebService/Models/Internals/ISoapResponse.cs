using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.Models.Internals
{
    public interface ISoapResponse
    {
        ///// <summary>
        ///// Value assigned by Comdata.
        ///// </summary>
        //string? AccountCode { get;set; }

        ///// <summary>
        ///// Value assigned by Comdata.  (4 digit CustomerId's will include leading zero)
        ///// </summary>
        //string? CustomerId { get; set; }

        ///// <summary>
        ///// Any discretionary data that the requestor included in the corresponding request record.
        ///// </summary>
        //string? DiscretionaryData { get; set; }

        /// <summary>
        /// 0=Update Complete 
        /// Anything Else=Error
        /// </summary>
        int? ResponseCode { get; set; }

        /// <summary>
        /// Response Description
        /// </summary>
        string? ResponseMessage { get; set; }

        ///// <summary>
        ///// Comdata assigned value attached to this response record. (Overrides the tracking number submitted.)
        ///// </summary>
        //long TrackingNumber { get; set; }




        /*
        /// <remarks/>
        [XmlElementAttribute(ElementName = "accountCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public string? AccountCode { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "customerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string? CustomerId { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "discretionaryData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string? DiscretionaryData { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "responseCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public int ResponseCode { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "responseMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string? ResponseMessage { get; set; }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "trackingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public long? TrackingNumber { get; set; }
        */
    }
}
