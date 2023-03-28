using Auto_Shop.Domain.Models.DTOs;
using AutoMapper;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using Auto_Shop.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Auto_Shop.Service.Queries.AuthenticationQueries
{
    public class AuthenticateUserQuery : IRequest<AuthenticatedUserDTO>
    {
        [Required(ErrorMessage = "The field {0} cannot be empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The field {0} cannot be empty")]
        public string Password { get; set; }
    }

    public class AuthenticateUserQueryHandler : IRequestHandler<AuthenticateUserQuery, AuthenticatedUserDTO>
    {
        private readonly IAuthenticationService _authService;
        public AuthenticateUserQueryHandler(IMapper mapper, IAuthenticationService authService)
        {
            _authService = authService;
        }

        public async Task<AuthenticatedUserDTO> Handle(AuthenticateUserQuery request, CancellationToken cancellationToken)
        {
            return await _authService.Authenticate(request.Username, request.Password);
        }
    }
}
