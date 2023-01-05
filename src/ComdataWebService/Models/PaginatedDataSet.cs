﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.FleetCreditWS0200.Models
{
    public class PaginatedDataSet<TRecord>
    {
        public PaginatedDataSet(TRecord[] records, int recordCount, int pageNumber, int pageCount)
        {
            Records = records;
            RecordCount = recordCount;

            PageNumber = pageNumber;
            PageCount = pageCount;
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
