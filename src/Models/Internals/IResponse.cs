using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.Models.Internals
{
    public interface IResponse
    {
        //int? NumberChanges { get; set; }
        //string? ResponseCode { get; set; }
        //string? ResponseDescription { get; set; }
    }

    public interface IResponse<TContent> : IResponse
    {
        TContent Content { get; set; }
    }
}
