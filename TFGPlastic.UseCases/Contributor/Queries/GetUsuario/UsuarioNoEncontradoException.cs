using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.UseCases.Contributor.Queries.GetUsuario
{
    [Serializable]

    internal class UsuarioNoEncontradoException : Exception
    {
        public UsuarioNoEncontradoException()
        {
        }

        public UsuarioNoEncontradoException(string? message) : base(message)
        {
        }

        public UsuarioNoEncontradoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UsuarioNoEncontradoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
