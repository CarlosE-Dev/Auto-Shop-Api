using Auto_Shop.Domain.Models.DTOs;
using System.Threading.Tasks;

namespace Auto_Shop.Domain.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticatedUserDTO> Authenticate(string email, string password);
    }
}
