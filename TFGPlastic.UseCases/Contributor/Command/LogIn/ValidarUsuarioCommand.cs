using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;

namespace TFGPlastic.UseCases.Contributor.Command.LogIn
{
    public class ValidarUsuarioCommand : IRequest<bool>
    {
        
        public string nombre { get; set; }
        public string password { get; set; }

        public ValidarUsuarioCommand( string nombre, string password)
        {
            
            this.nombre = nombre;
            this.password = password;
        }
    }   
}
