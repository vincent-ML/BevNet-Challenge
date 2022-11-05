using bevnet_challenge.Application.Common.Interfaces;
using bevnet_challenge.Infrastructure.Services;
using bevnet_challenge.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace bevnet_challenge.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var apiSettings = configuration.GetSection(nameof(ApiSettings)).Get<ApiSettings>();
            services.AddTransient(d => configuration.GetSection(nameof(ApiSettings)).Get<ApiSettings>());

            services.AddTransient<IMovieService, MovieService>();

            return services;
        }
    }
}
