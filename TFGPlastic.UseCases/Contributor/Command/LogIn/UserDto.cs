using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.Core.Enum;

namespace TFGPlastic.UseCases.Contributor.Command.LogIn
{
    public class UserDto
    {
        public UserDto(Guid id, string nombre, ValidarUsuario usuario)
        {
            Id = id;
            Nombre = nombre;
            Usuario = usuario;
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public TFGPlastic.Core.Enum.ValidarUsuario Usuario { get; set; }
    }
}
