using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System.Globalization;

namespace Auto_Shop.Application.Configurations
{
    public static class CorsConfiguration
    {
        public static IApplicationBuilder ConfigureCors(this IApplicationBuilder app)
        {
            app.UseCors(x => x
                .AllowAnyMethod()
                    .AllowAnyHeader()
                        .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());

            return app;
        }
    }
}
