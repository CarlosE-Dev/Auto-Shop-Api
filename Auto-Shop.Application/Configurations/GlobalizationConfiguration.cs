using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System.Globalization;

namespace Auto_Shop.Application.Configurations
{
    public static class GlobalizationConfiguration
    {
        public static IApplicationBuilder ConfigureGlobalization(this IApplicationBuilder app)
        {
            var defaultCulture = new CultureInfo("en-US");
            var localizationOpt = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<CultureInfo> { defaultCulture },
                SupportedUICultures = new List<CultureInfo> { defaultCulture }
            };
            app.UseRequestLocalization(localizationOpt);

            return app;
        }
    }
}
