using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Service.Commands.VehicleCommands;
using Auto_Shop.Service.Queries.VehicleQueries;
using Auto_Shop.Service.Validators;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Application.Controllers
{
    [Route("vehicles")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _service;
        private readonly IMediator _mediator;

        public VehiclesController(IVehicleService service, IMediator mediator)
        {
            _service = service;
            _mediator = mediator;
        }

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
        public async Task<IActionResult> GetVehicleById([FromBody] GetVehicleByIdQuery query, [FromRoute] string id)
        {
            query.Id = id;
            return Ok(await _mediator.Send(query));
        }

        [HttpPut("update/{id}", Name = "UpdateVehicle")]
        [Produces(typeof(IEnumerable<Vehicle>))]
        public async Task<IActionResult> UpdateVehicle([FromBody] UpdateVehicleCommand command, [FromRoute] string id)
        {
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut("delete/{id}", Name = "DeleteVehicle")]
        [Produces(typeof(IEnumerable<Vehicle>))]
        public async Task<IActionResult> DeleteVehicle([FromBody] DeleteVehicleCommand command, [FromRoute] string id)
        {
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
