using MediatR;
using Mapster;
using TFGPlastic.Core.Entity;
//using TFGPlastic.Infrastructure.FileSystem.DataBase;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;

namespace TFGPlastic.UseCases.Contributor.Command.Order
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderDto>
    {
        
        public Task<OrderDto> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            return Task.FromResult(new OrderDto(request.CustomerName));

        }
    }
}
