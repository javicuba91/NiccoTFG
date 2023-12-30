using MediatR;

namespace TFGPlastic.UseCases.Contributor.Command.CrearTarea
{
    public class CambiarEstadoTareaCommand : IRequest<TareaDto>
    {
        public Guid IdTarea { get; set; }
        public Core.Enum.EstadosTarea EstadoTarea { get; set; }

        public CambiarEstadoTareaCommand(Guid IdTarea, Core.Enum.EstadosTarea EstadoTarea)
        {
            this.IdTarea = IdTarea;
            this.EstadoTarea = EstadoTarea;
        }
    }
}


