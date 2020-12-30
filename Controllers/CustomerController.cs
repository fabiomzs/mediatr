using System.Threading.Tasks;
using Academy.Domain.Commands.Responses;
using Academy.Domain.Commands.Resquests;
using Academy.Domain.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromServices]IMediator mediator, [FromBody]CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}