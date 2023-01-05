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
<<<<<<< HEAD
        TResponse Content { get; set; } 
=======
        TResponse Response { get; set; } 
>>>>>>> releases/v1.0.0
    }
}
