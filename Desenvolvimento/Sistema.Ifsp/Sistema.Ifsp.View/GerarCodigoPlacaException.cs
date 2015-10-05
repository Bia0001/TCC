using System;
using System.Runtime.Serialization;

namespace Sistema.Ifsp.View
{
    [Serializable]
    internal class GerarCodigoPlacaException : Exception
    {
        public GerarCodigoPlacaException()
        {
        }

        public GerarCodigoPlacaException(string message) : base(message)
        {
        }

        public GerarCodigoPlacaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GerarCodigoPlacaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}