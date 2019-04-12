using Ordering.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Aggregates.OrderAggregate
{
    public class Order : IAggregateRoot
    {
        private readonly int buyerId;
        private readonly string description;
        private readonly DateTime orderDate;

        public Address Address { get; private set; }

        public string OrderStatus { get; private set; }

        private Order() { }

        public Order(int buyerId, string description, DateTime orderDate, Address address)
        {
            this.buyerId = buyerId;
            this.description = description;
            this.orderDate = orderDate;
            Address = address;
        }
    }
}
