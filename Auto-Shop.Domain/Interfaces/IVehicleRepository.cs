using Auto_Shop.Domain.Enums;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Domain.Interfaces
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Task<VehicleDTO> CreateVehicleAsync(Vehicle vehicle);
        Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync(string orderBy, EOrderType? orderType = null);
        Task<VehicleDTO> GetVehicleByIdAsync(string id);
        Task<IEnumerable<VehicleDTO>> GetVehiclesByBrand(string brand);
        Task<IEnumerable<VehicleDTO>> FilterVehiclesByName(string query);
    }
}
