﻿using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Domain.Interfaces
{
    public interface IVehicleService : IBaseService<Vehicle>
    {
        Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync(string orderBy, VehicleFilters filters);
        Task<VehicleDTO> CreateVehicleAsync(Vehicle vehicle);
        Task<VehicleDTO> GetVehicleByIdAsync(string id);
        Task UpdateVehicleAsync(Vehicle updatedModel);
    }
}
