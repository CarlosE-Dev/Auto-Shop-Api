using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Auto_Shop.Application.Configurations
{
    public static class EnvConfiguration
    {
        public static IApplicationBuilder ConfigureEnv(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Auto_Shop.Application v1"));
            }

            return app;
        }
    }
}
