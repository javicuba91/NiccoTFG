using MediatR;

namespace TFGPlastic.UseCases.Contributor.Command.Order
{
    public class CreateOrderCommand : IRequest<OrderDto>
    {
        public readonly string CustomerName;

        public CreateOrderCommand(string custormerName)
        {
            this.CustomerName = custormerName;
        }

    }
}



