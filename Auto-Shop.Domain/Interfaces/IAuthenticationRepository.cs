using Auto_Shop.Domain.Models;
using System.Threading.Tasks;

namespace Auto_Shop.Domain.Interfaces
{
    public interface IAuthenticationRepository
    {
        Task<Role> GetRoleByIdAsync(string roleId);
        Task<User> GetUserByUsername(string username);
    }
}
