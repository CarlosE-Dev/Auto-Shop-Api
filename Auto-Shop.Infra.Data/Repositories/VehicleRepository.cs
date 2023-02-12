using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Domain.Models.DTOs;
using Auto_Shop.Infra.Data.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync()
        {
            return await _context.Set<Vehicle>().AsNoTracking().OrderBy(p => p.Price)
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
                )
                .ToListAsync();
        }

        public async Task<VehicleDTO> GetVehicleByIdAsync(string id)
        {
            var vehicles = await GetAllVehiclesAsync();
            return vehicles.FirstOrDefault(v => v.Id == id);
        }

        public async Task<VehicleDTO> CreateVehicleAsync(Vehicle vehicle)
        {
            _context.Set<Vehicle>().Add(vehicle);
            await SaveChangesAsync();
            return await GetVehicleByIdAsync(vehicle.Id);
        }
    }
}
