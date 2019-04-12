using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.API.Commands;
using Ordering.Domain.Aggregates.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.API.CommandHandlers
{
    public class CreateOrderCommandHandler : 
        IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly ILogger<CreateOrderCommandHandler> logger;
        private readonly IOrderRepository repository;
        private readonly IMapper mapper;

        public CreateOrderCommandHandler(
            ILogger<CreateOrderCommandHandler> logger,
            IOrderRepository repository,
            IMapper mapper)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger)); ;
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Handling CreateOrderCommand");

            var orderAggregate = mapper.Map<Order>(request);
            await repository.Add(orderAggregate);

            return true;
        }
    }
}
