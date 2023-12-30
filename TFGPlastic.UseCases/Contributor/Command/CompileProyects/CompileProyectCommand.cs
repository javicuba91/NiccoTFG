using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;

namespace TFGPlastic.UseCases.Contributor.Command.CompileProyects
{
    public class CompileProyectCommand : IRequest<string>
    {
        public string PathToCompile { get; set; }
    }
}
