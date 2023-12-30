using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure.DataBase;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;
using Mapster;

namespace TFGPlastic.UseCases.Contributor.Command.EstadoTareas
{
    public class ComprobarEstadoHandler : IRequestHandler<ComprobarEstadoCommand, TareaDto>
    {
        private TFGPlasticDbContext _context;

        public ComprobarEstadoHandler(TFGPlasticDbContext context)
        {
            _context = context;
        }

        public async Task<TareaDto> Handle(ComprobarEstadoCommand command, CancellationToken cancellationToken)
        {
            // Aquí implementa la lógica para comprobar el estado de la tarea
            TareaEntity tarea = await _context.Tarea.FindAsync(command.TareaId);

            if (tarea != null)
            {
               
                tarea.CompilarTarea();
                tarea.IntegrarTarea();
                tarea.PublicarTarea();
                return tarea.Adapt<TareaDto>();
            }

            // En caso de que la tarea no se encuentre, puedes manejarlo adecuadamente, por ejemplo, lanzar una excepción.
            throw new Exception("Tarea no encontrada");
        }
    }
}
