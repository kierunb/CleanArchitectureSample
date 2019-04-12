using Ordering.Domain.Aggregates.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public async Task Add(Order orderAggregate)
        {
            await Task.Run( () => "dummy task" );
            Console.WriteLine("ADDING ORDER AGGREGATE");
        }
    }
}
