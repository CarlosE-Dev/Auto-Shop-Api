using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using System.Threading.Tasks;
using System;
using Auto_Shop.Domain.Models.DTOs;

namespace Auto_Shop.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authRepository;
        private readonly ISecurityTokenHandler _tokenService;

        public AuthenticationService(IAuthenticationRepository authRepository, ISecurityTokenHandler tokenService)
        {
            _authRepository = authRepository;
            _tokenService = tokenService;
        }

        public async Task<AuthenticatedUserDTO> Authenticate(string username, string password)
        {
            var user = await GetUserByUsername(username);

            if (user.Password != password || user.Username != username)
                throw new Exception("Incorrect username or password");

            var role = await GetRoleByIdAsync(user.RoleId);

            var token = GetToken(user, role);

            return new AuthenticatedUserDTO
            {
                Login = user.Username,
                UserId = user.Id,
                Role = role.RoleName,
                Token = token,
            };
        }

        private async Task<User> GetUserByUsername(string username)
        {
            var user = await _authRepository.GetUserByUsername(username);
            if (user == null) throw new Exception("User not found");

            return user;
        }

        private async Task<Role> GetRoleByIdAsync(string roleId)
        {
            var role = await _authRepository.GetRoleByIdAsync(roleId);
            if (role == null) throw new Exception("Role not found");

            return role;
        }

        private string GetToken(User user, Role role)
        {
            return _tokenService.GenerateToken(user, role.RoleName);
        }
    }
}
