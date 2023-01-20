using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
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

        public override async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            return await _vehicleRepository.GetAllAsync();
        }
    }
}
