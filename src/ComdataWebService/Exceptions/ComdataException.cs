using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Comdata
{
    public class ComdataException : Exception
    {
        public ComdataException() { }

        public ComdataException(string message) : base(message) { }

        public ComdataException(int responseCode, string message) : base(message)
        {
            ResponseCode = responseCode;
        }

        public ComdataException(string message, Exception innerException) : base(message, innerException) { }

        public ComdataException(int responseCode, string message, Exception innerException) : base(message, innerException)
        {
            ResponseCode = responseCode;
        }

        protected ComdataException(SerializationInfo info, StreamingContext context) : base(info, context) { }



        public int ResponseCode { get; }
    }
}
