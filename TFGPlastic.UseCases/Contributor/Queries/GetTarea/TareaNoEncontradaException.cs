using System.Runtime.Serialization;

namespace TFGPlastic.UseCases.Contributor.Queries.GetTarea
{
    [Serializable]
    internal class TareaNoEncontradaException : Exception
    {
        public TareaNoEncontradaException()
        {
        }

        public TareaNoEncontradaException(string? message) : base(message)
        {
        }

        public TareaNoEncontradaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TareaNoEncontradaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}