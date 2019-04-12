using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.API.Commands
{
    public class CreateOrderCommand : IRequest<bool>
    {
        public int BuyerId { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
