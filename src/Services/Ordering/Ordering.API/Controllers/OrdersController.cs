using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ordering.API.Commands;

namespace Ordering.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : 
        ControllerBase
    {
        private readonly ILogger<OrdersController> logger;
        private readonly IMediator mediator;

        public OrdersController(
            ILogger<OrdersController> logger, 
            IMediator mediator)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        //[Route("[action]")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateOrder([FromBody]CreateOrderCommand command)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);


            var response = await this.mediator.Send(command);

            return Ok();
        }



    }
}