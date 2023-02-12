using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Service.Commands.VehicleCommands;
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

        [HttpPost("create", Name = "CreateNewVehicle")]
        [Produces(typeof(VehicleDTO))]
        public async Task<IActionResult> CreateNewVehicle([FromBody] CreateVehicleCommand command)
        {
            return Created("", await _mediator.Send(command));
        }

        [HttpGet("catalog", Name = "GetAllVehicles")]
        [Produces(typeof(IEnumerable<VehicleDTO>))]
        public async Task<IActionResult> GetAllVehicles()
        {
            return Ok(await _service.GetAllVehiclesAsync());
        }

        [HttpPut("update/{id}", Name = "UpdateVehicle")]
        [Produces(typeof(IEnumerable<Vehicle>))]
        public async Task<IActionResult> UpdateVehicle([FromBody] Vehicle vehicle)
        {
            await _service.UpdateAsync<VehicleValidator>(vehicle);
            return NoContent();
        }

        [HttpPut("delete/{id}", Name = "DeleteVehicle")]
        [Produces(typeof(IEnumerable<Vehicle>))]
        public async Task<IActionResult> DeleteVehicle([FromRoute] string id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
