using Auto_Shop.Domain.Authentication;
using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Infra.Data.Repositories;
using Auto_Shop.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Auto_Shop.Application.Configurations
{
    public static class DIConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ISecurityTokenHandler, SecurityTokenHandler>();

            return services;
        }
    }
}
