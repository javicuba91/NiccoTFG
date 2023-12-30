using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;


namespace TFGPlastic.UseCases.Contributor.Command.EstadoTareas
{
    public class ComprobarEstadoCommand : IRequest<TareaDto>
    {
        public int TareaId { get; set; }
        public string Estado { get; set; }
        public ComprobarEstadoCommand(int tareaId)
        {
            TareaId = tareaId;
        }
        public ComprobarEstadoCommand(string estado)
        {
            Estado = estado;
        }
    }
}
