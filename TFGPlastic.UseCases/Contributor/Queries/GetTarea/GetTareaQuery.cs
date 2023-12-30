using MediatR;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;

namespace TFGPlastic.UseCases.Contributor.Queries.GetTarea
{

    public class GetTareaQuery : IRequest<TareaDto>
    {
        public Guid Id { get; set; }
        public Guid TareaDto { get; internal set; }
    }
}

