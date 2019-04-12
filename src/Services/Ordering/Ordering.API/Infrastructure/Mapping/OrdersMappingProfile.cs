using AutoMapper;
using Ordering.API.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.API.Infrastructure.Mapping
{
    public class OrdersMappingProfile : Profile
    {
        public OrdersMappingProfile()
        {
            CreateMap<CreateOrderCommand, Domain.Aggregates.OrderAggregate.Order>();
        }
    }
}
