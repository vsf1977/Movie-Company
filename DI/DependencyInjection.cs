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
            services.AddTransient<GenreApplicationService>();
            services.AddTransient<GenreDomainService>();
            services.AddTransient<MultiplexApplicationService>();
            services.AddTransient<MultiplexDomainService>();
            services.AddTransient<MovieApplicationService>();
            services.AddTransient<MovieDomainService>();
            services.AddTransient<MovieByMultiplexApplicationService>();
            services.AddTransient<MovieByMultiplexDomainService>();
        }
    }
}
