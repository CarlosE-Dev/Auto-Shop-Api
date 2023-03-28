using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Infra.CrossCutting.Helpers;
using Auto_Shop.Infra.Data.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Shop.Infra.Data.Repositories
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(AutoShopContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync(string orderBy, VehicleFilters filters)
        {
            if (String.IsNullOrWhiteSpace(orderBy))
                orderBy = "Price";
            else
                StringHelpers.TransformToCamelCase(orderBy);


            var result = await _context.Set<Vehicle>().AsNoTracking().OrderBy(p => EF.Property<string>(p, orderBy))
                .Join(
                    _context.Brands,
                    v => v.BrandId,
                    b => b.Id,
                    (v, b) =>
                        new VehicleDTO()
                        {
                            Id = v.Id,
                            Name = v.Name,
                            BrandName = b.Name,
                            City = v.Name,
                            Km = v.Km,
                            Model = v.Model,
                            Price = v.Price,
                            ImageUrl = v.ImageUrl,
                            Year = v.Year,
                            ModifiedOn = v.ModifiedOn,
                            State = v.State,
                            BrandId = b.Id
                        }
                ).ToListAsync();

            if (filters != null)
            {
                if (!string.IsNullOrEmpty(filters.FilterByBrandName))
                {
                    StringHelpers.TransformToCamelCase(filters.FilterByBrandName);
                    result = result.Where(x => x.BrandName == filters.FilterByBrandName).ToList();
                }

                if (!string.IsNullOrEmpty(filters.FilterByVehicleName))
                {
                    StringHelpers.TransformToCamelCase(filters.FilterByVehicleName);
                    result = result.Where(x => x.Name.Contains(filters.FilterByVehicleName)).ToList();
                }

                if (filters.Pagination != null) 
                {
                    if (filters.Pagination.Page == 0)
                        filters.Pagination.Page = 1;

                    if (filters.Pagination.PageLimit == 0)
                        filters.Pagination.PageLimit = int.MaxValue;

                    var skip = (filters.Pagination.Page - 1) * filters.Pagination.PageLimit;

                    result = result
                        .Skip(skip)
                        .Take(filters.Pagination.PageLimit)
                        .ToList();
                }
            }

            return result;
        }

        public async Task<VehicleDTO> GetVehicleByIdAsync(string id)
        {
            var vehicles = await GetAllVehiclesAsync("", null);

            return vehicles.Where(v => v.Id == id).FirstOrDefault();
        }

        public async Task<VehicleDTO> CreateVehicleAsync(Vehicle vehicle)
        {
            _context.Set<Vehicle>().Add(vehicle);
            await SaveChangesAsync();
            return await GetVehicleByIdAsync(vehicle.Id);
        }
    }
}
