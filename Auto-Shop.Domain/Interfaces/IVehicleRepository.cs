using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Domain.Interfaces
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Task<VehicleDTO> CreateVehicleAsync(Vehicle vehicle);
        Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync(string orderBy, VehicleFilters filters);
        Task<VehicleDTO> GetVehicleByIdAsync(string id);
    }
}
