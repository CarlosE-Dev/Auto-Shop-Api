using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Shop.Infra.Data.Repositories
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(AutoShopContext context) : base(context){}

        public override async Task<IEnumerable<Vehicle>> GetAllAsync() 
        {
            return await _context.Set<Vehicle>().AsNoTracking().OrderBy(p => p.Price)
                .Join(
                    _context.Brands,
                    v => v.BrandId,
                    b => b.Id, 
                    (v, b) =>
                        new Vehicle()
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
                            CreatedOn = v.CreatedOn,
                            State = v.State,
                            BrandId = b.Id
                        }
                )
                .ToListAsync();
        }
    }
}
