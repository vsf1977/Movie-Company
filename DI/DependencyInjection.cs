using Microsoft.Extensions.DependencyInjection;
using PruebaPNG.Application;
using PruebaPNG.Domain;

namespace PruebaPNG.DI
{
    public class DependencyInjection
    {
        public static void RegisterProfile(IServiceCollection services)
        {

            services.AddTransient<CityApplicationService>();
            services.AddTransient<CityDomainService>();
        }
    }
}
