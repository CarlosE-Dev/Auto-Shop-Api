using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Service.Validators;
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

        public VehiclesController(IVehicleService service)
        {
            _service = service;
        }

        [HttpPost("create", Name = "CreateNewVehicle")]
        [Produces(typeof(Vehicle))]
        public async Task<IActionResult> CreateNewVehicle([FromBody] Vehicle vehicle)
        {
            return Created("", await _service.CreateAsync<VehicleValidator>(vehicle));
        }

        [HttpGet("catalog", Name = "GetAllVehicles")]
        [Produces(typeof(IEnumerable<Vehicle>))]
        public async Task<IActionResult> GetAllVehicles()
        {
            return Ok(await _service.GetAllAsync());
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
