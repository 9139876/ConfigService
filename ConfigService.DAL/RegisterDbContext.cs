using CommonLibraries.EF;
using ConfigService.DAL.Internal;
using ConfigService.DAL.Internal.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConfigService.DAL
{
    public static class RegisterDbContext
    {
        public static void RegisterDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDbContext<IConfigDbContext, ConfigDbContext>(() => configuration.GetConnectionString("ConfigDb"));
        }
    }
}
