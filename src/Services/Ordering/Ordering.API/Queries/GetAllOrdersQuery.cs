using MediatR;
using Ordering.API.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.API.Queries
{
    public class GetAllOrdersQuery : IRequest<OrderResponseModel>
    {
        public string QueryParameter { get; set; }
    }
}
