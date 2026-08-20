using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicktingSystem.Application.CQRS.Command;

namespace TicktingSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TicketsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult>Create(CreateTicketCommand command)
        {
            var tiketId = await _mediator.Send(command);
            return Ok(tiketId);
        }
    }
}
