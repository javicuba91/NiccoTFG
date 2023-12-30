using Mapster;
using MediatR;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure.DataBase;

namespace TFGPlastic.UseCases.Contributor.Command.CrearTarea
{
    public class CreatTarea : IRequestHandler<CreatTareaCommand, TareaDto>
    {
        private TFGPlasticDbContext _context;
        public CreatTarea(TFGPlasticDbContext context)
        {
            this._context = context;
        }
        public async Task<TareaDto> Handle(CreatTareaCommand command, CancellationToken cancellationToken)
        {
            //acceder a dominio Core para crear la tarea y cumplir con las reglas de negocio
            TareaEntity entity = new TareaEntity(command.Titulo, command.Descripcion, command.FechaPublicacion);

            await this._context.Tarea.AddAsync(entity);
            await this._context.SaveChangesAsync();

            return entity.Adapt<TareaDto>();
        }
    }
}
