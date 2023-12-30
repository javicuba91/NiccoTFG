using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.UseCases.Contributor.Command.Order
{
    public class OrderDto
    {

        public Guid OrderId { get; private set; }
        public string CustormerName { get; set; }



        public OrderDto(string custormerName)
        {
            this.OrderId = Guid.NewGuid();
            this.CustormerName = custormerName;
        }
    }
}
