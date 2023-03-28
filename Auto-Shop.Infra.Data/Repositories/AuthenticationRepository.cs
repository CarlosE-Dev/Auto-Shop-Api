using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Shop.Infra.Data.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        protected readonly AutoShopContext _context;
        public AuthenticationRepository(AutoShopContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRoleByIdAsync(string roleId)
        {
            return await _context.Set<Role>().Where(x => x.Id == roleId).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _context.Set<User>().Where(x => x.Username == username).FirstOrDefaultAsync();
        }
    }
}
