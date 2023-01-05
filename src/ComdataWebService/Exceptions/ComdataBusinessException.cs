using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Comdata
{
    public class ComdataBusinessException : ComdataException
    {
        public ComdataBusinessException() { }

        public ComdataBusinessException(string message) : base(message) { }

        public ComdataBusinessException(int responseCode, string message) : base(responseCode, message) { }

        public ComdataBusinessException(string message, Exception innerException) : base(message, innerException) { }

        public ComdataBusinessException(int responseCode, string message, Exception innerException) : base(responseCode, message, innerException) { }

        protected ComdataBusinessException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
