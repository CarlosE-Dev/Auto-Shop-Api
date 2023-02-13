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
            #region DbContext Config

            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AutoShopContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            #endregion

            #region DI Configuration

            services.ResolveDependencies();

            #endregion

            #region AutoMapper Config

            services.AddAutoMapper(typeof(AutoMapperProfile));

            #endregion

            #region MediatR Config

            services.AddMediatR(typeof(BaseService<>).GetTypeInfo().Assembly);

            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Auto_Shop.Application", Version = "v1" });
            });
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

            #region CORS Config

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials());

            #endregion

            #region Globalization Config

            app.ConfigureGlobalization();

            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
