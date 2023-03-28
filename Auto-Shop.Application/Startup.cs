using Auto_Shop.Application.Configurations;
using Auto_Shop.Infra.Data.Context;
using Auto_Shop.Service.AutoMapper;
using Auto_Shop.Service.Services;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Auto_Shop.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureSwaggerGen();
            services.ConfigureAuthentication();
            services.ConfigureDbContext(Configuration);
            services.ResolveDependencies();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddMediatR(typeof(BaseService<>).GetTypeInfo().Assembly);

            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Auto_Shop.Application v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.ConfigureGlobalization();

            app.UseCors(x => x
                .AllowAnyMethod()
                    .AllowAnyHeader()
                        .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
