using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CommonLibraries.Core.Extensions;
using CommonLibraries.Web;
using ConfigService.DAL;

namespace ConfigService.WebApi
{
    public class Startup : CommonLibraryStartup
    {
        protected override bool _loadFromConfigService => false;

        protected override bool _reloadAppSettingsOnChange => false;

        protected override bool _requiredConfigService => false;

        protected override void ConfigureApplication(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ConfigureWebApi(app, env);
        }

        protected override void ConfigurePipelineAfterExceptionsHandling(IApplicationBuilder app)
        {
        }

        protected override void ConfigurePipelineAfterMvc(IApplicationBuilder app)
        {
        }

        protected override void ConfigureRoutes(IApplicationBuilder app)
        {
        }

        protected override void ConfigureServiceCollections(IServiceCollection services)
        {
            services.RegisterDbContexts(Configuration);

            services.RegisterAssemblyServiceAndRepositoryByMember<DAL.PlaceboRegistration>();
            services.RegisterAssemblyServiceAndRepositoryByMember<Startup>();
        }
    }
}
