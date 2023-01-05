using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.Models.Internals
{
    public interface ISoapRequestBody<TRequest>
        where TRequest : class, ISoapRequest, new()
    {
        TRequest Request { get; set; }
    }
}
