using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace bevnet_challenge.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
