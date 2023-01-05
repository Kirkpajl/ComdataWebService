using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.Models.Internals
{
    public interface ISoapRequest
    {
        /// <summary>
        /// Login name for real-time processing. Value assigned by Comdata.
        /// </summary>
        string? SignOnName { get; set; }

        /// <summary>
        /// Must be a secure card for real-time processing.  Value assigned by Comdata.
        /// </summary>
        string? Password { get; set; }



        /// <summary>
        /// Value assigned by Comdata. Leading zero on 4-digit CustomerId's is optional.
        /// </summary>
        string? CustomerId { get; set; }

        /// <summary>
        /// Full 16-digit security card number. Value assigned by Comdata.
        /// </summary>
        string? SecurityInfo { get; set; }

        /// <summary>
        /// Value assigned by Comdata.
        /// </summary>
        string? AccountCode { get; set; }

        ///// <summary>
        ///// Any discretionary data that the requestor would like returned in the response record. (
        ///// </summary>
        //string? DiscretionaryData { get; set; }

        ///// <summary>
        ///// Any Number (data type: long)
        ///// </summary>
        //long TrackingNumber { get; set; }
    }
}
