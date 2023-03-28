using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Service.Commands.VehicleCommands;
using Auto_Shop.Service.Queries.VehicleQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Application.Controllers
{
    [Route("vehicles")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehiclesController (IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize]
        [HttpPost("new", Name = "CreateNewVehicle")]
        [Produces(typeof(VehicleDTO))]
        public async Task<IActionResult> CreateNewVehicle([FromBody] CreateVehicleCommand command)
        {
            return Created("", await _mediator.Send(command));
        }

        [HttpPost("catalog", Name = "GetAllVehicles")]
        [Produces(typeof(IEnumerable<VehicleDTO>))]
        public async Task<IActionResult> GetAllVehicles([FromBody] GetAllVehiclesQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpPost("catalog/{id}", Name = "GetVehicleById")]
        [Produces(typeof(VehicleDTO))]
        public async Task<IActionResult> GetVehicleById([FromRoute] string id)
        {
            return Ok(await _mediator.Send(new GetVehicleByIdQuery { Id = id } ));
        }

        [Authorize]
        [HttpPut("update/{id}", Name = "UpdateVehicle")]
        [Produces(typeof(IEnumerable<Vehicle>))]
        public async Task<IActionResult> UpdateVehicle([FromBody] UpdateVehicleCommand command, [FromRoute] string id)
        {
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [Authorize]
        [HttpDelete("delete/{id}", Name = "DeleteVehicle")]
        [Produces(typeof(IEnumerable<Vehicle>))]
        public async Task<IActionResult> DeleteVehicle([FromBody] DeleteVehicleCommand command, [FromRoute] string id)
        {
            await _mediator.Send(new DeleteVehicleCommand { Id = id });
            return NoContent();
        }
    }
}
