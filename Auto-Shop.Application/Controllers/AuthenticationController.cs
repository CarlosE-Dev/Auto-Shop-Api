using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Service.Queries.AuthenticationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Auto_Shop.Application.Controllers
{
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login", Name = "Authenticate")]
        [Produces(typeof(AuthenticatedUserDTO))]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateUserQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
