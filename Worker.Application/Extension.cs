using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Worker.Application.Commands.Handlers;

namespace Worker.Application
{
    public static class Extensions
    {

        public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAddWorkerHandler, AddWorkerHandler>();
            return serviceCollection;
        }

        public static IApplicationBuilder UseApplication(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder;
        }
    }
}