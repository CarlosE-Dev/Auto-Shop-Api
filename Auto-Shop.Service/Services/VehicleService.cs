using Auto_Shop.Domain.Enums;
using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Infra.CrossCutting.Helpers;
using Auto_Shop.Service.Validators;
using FluentValidation;
using System;
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

        public async Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync(string orderBy, VehicleFilters filters)
        {
            return await _vehicleRepository.GetAllVehiclesAsync(orderBy, filters);
        }

        public async Task<VehicleDTO> GetVehicleByIdAsync(string id)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(id);

            if (vehicle == null)
                throw new Exception($"Vehicle not found.");

            return vehicle;
        }

        public async Task<VehicleDTO> CreateVehicleAsync(Vehicle vehicle)
        {
            var validator = new VehicleValidator();
            await validator.ValidateAndThrowAsync(vehicle);
            return await _vehicleRepository.CreateVehicleAsync(vehicle);
        }

        public async Task UpdateVehicleAsync(Vehicle updatedModel)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(updatedModel.Id);

            if (vehicle == null)
                throw new Exception($"Vehicle not found.");

            var validator = new VehicleValidator();

            await validator.ValidateAndThrowAsync(updatedModel);

            await _vehicleRepository.UpdateAsync(updatedModel);
        }
    }
}
