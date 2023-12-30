using Mapster;
using MediatR;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure.DataBase;

namespace TFGPlastic.UseCases.Contributor.Command.CrearTarea
{
    public class CambiarEstadoTarea : IRequestHandler<CambiarEstadoTareaCommand, TareaDto>
    {
        private TFGPlasticDbContext _context;
        public CambiarEstadoTarea(TFGPlasticDbContext context)
        {
            this._context = context;
        }
        public async Task<TareaDto> Handle(CambiarEstadoTareaCommand command, CancellationToken cancellationToken)
        {
            TareaEntity tareaEntity = _context.Tarea.First(t=>t.Id == command.IdTarea);
            switch (command.EstadoTarea)
            {
                case Core.Enum.EstadosTarea.Compilado:
                    tareaEntity.CompilarTarea();
                    break;
                case Core.Enum.EstadosTarea.Integrado:
                    tareaEntity.IntegrarTarea();
                    break;
                case Core.Enum.EstadosTarea.Publicado:
                    tareaEntity.PublicarTarea();
                    break;
                default:
                    break;
            }
            await _context.SaveChangesAsync();

            return tareaEntity.Adapt<TareaDto>();
        }
    }
}
