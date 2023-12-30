using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure.DataBase;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;

namespace TFGPlastic.UseCases.Contributor.Queries.GetTarea
{
    public class GetTareaQueryHandler : IRequestHandler<GetTareaQuery, TareaDto>
    {

        private readonly TFGPlasticDbContext _context;

        public GetTareaQueryHandler(TFGPlasticDbContext context)
        {
            _context = context;
        }

        public async Task<TareaDto> Handle(GetTareaQuery request, CancellationToken cancellationToken)
        {
            TareaEntity tarea = await _context.Tarea.FirstOrDefaultAsync(t => t.Id == request.Id);

            if (tarea == null)
            {

                throw new TareaNoEncontradaException("La tarea no se encontró");

            }

            TareaDto tareaDto = tarea.Adapt<TareaDto>();
            return tareaDto;
        }
    }
}
