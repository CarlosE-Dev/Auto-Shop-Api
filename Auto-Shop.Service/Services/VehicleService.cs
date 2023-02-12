using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Service.Services
{
    public class VehicleService : BaseService<Vehicle>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IBaseRepository<Vehicle> _repository;
        public VehicleService(IVehicleRepository vehicleRepository, IBaseRepository<Vehicle> repository) : base(repository)
        {
            _vehicleRepository = vehicleRepository;
            _repository = repository;
        }

        public async Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync()
        {
            return await _vehicleRepository.GetAllVehiclesAsync();
        }

        public async Task<VehicleDTO> GetVehicleByIdAsync(string id)
        {
            return await _vehicleRepository.GetVehicleByIdAsync(id);
        }

        public async Task<VehicleDTO> CreateVehicleAsync(Vehicle vehicle)
        {

        }
    }
}
