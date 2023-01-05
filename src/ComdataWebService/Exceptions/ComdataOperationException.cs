using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Comdata
{
    public class ComdataOperationException : ComdataException
    {
        public ComdataOperationException() { }

        public ComdataOperationException(string message) : base(message) { }

        public ComdataOperationException(int responseCode, string message) : base(responseCode, message) { }

        public ComdataOperationException(string message, Exception innerException) : base(message, innerException) { }

        public ComdataOperationException(int responseCode, string message, Exception innerException) : base(responseCode, message, innerException) { }

        protected ComdataOperationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
