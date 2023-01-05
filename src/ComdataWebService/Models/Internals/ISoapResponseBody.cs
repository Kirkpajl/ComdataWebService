using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Comdata.Models.Internals
{
    public interface ISoapResponseBody<TResponse>
        where TResponse : class, ISoapResponse, new()
    { 
        TResponse Content { get; set; } 
    }
}
