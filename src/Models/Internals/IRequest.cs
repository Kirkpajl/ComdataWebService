using System;
using System.Collections.Generic;
using System.Text;

namespace Comdata.Models.Internals
{
    public interface IRequest
    {
    }

    public interface IRequest<TContent> : IRequest
    {
        TContent Content { get; set; }
    }
}
