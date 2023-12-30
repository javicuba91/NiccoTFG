using System.Runtime.Serialization;

namespace TFGPlastic.Core.CustomExceptions
{
    [Serializable]
    internal class TiempoInferiorAlRequeridoException : Exception
    {
        public TiempoInferiorAlRequeridoException()
        {
        }

        public TiempoInferiorAlRequeridoException(string? message) : base(message)
        {
        }

        public TiempoInferiorAlRequeridoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TiempoInferiorAlRequeridoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}