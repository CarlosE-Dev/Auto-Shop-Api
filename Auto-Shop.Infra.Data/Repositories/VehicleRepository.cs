using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;

namespace Auto_Shop.Infra.Data.Repositories
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
    }
}
