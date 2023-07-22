using System;

namespace Comdata.FleetCreditWS0200.Models
{
    public class PaginatedDataSet<TRecord>
    {
        public PaginatedDataSet(TRecord[]? records, int? recordCount, int? pageNumber, int? pageCount)
        {
            Records = records ?? Array.Empty<TRecord>();
            RecordCount = recordCount ?? 0;

            PageNumber = pageNumber ?? 0;
            PageCount = pageCount ?? 0;
        }



        public TRecord[] Records { get; }

        /// <summary>
        /// Number of records on the page; up to 10,000 records per page
        /// </summary>
        public int RecordCount { get; }

        /// <summary>
        /// Current page number displayed
        /// </summary>
        public int PageNumber { get; }

        /// <summary>
        /// Total number of pages returned for this search
        /// </summary>
        public int PageCount { get; }
    }
}
