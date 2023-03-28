using Auto_Shop.Domain.Models;

namespace Auto_Shop.Domain.Interfaces
{
    public interface ISecurityTokenHandler
    {
        string GenerateToken(User user, string roleName);
    }
}
