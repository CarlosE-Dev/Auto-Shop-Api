using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;

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
    }
}
