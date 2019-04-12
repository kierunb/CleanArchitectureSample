using MediatR;
using Ordering.API.Queries;
using Ordering.API.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.API.QueryHandlers
{
    public class GetAllOrdersQueryHandler :
        IRequestHandler<GetAllOrdersQuery, OrderResponseModel>
    {
        public async Task<OrderResponseModel> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await Task.Run( () => new OrderResponseModel
            {
                BuyerId = 1,
                Description = "desc",
                OrderDate = DateTime.Now
            });
        }
    }
}
