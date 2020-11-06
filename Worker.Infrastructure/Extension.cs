using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Worker.Application.Services;
using Worker.Infrastructure.Queries.Handlers;
using Worker.Infrastructure.Services;

namespace Worker.Infrastructure
{
    public static class Extensions
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IWorkerRepository, WorkerRepository>();
            serviceCollection.AddTransient<IGetWorkersHandler, GetWorkersHandler>();
            return serviceCollection;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder;
        }
    }
}