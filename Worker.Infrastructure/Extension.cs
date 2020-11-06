using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Worker.Application.Services;
using Worker.Infrastructure.Options;
using Worker.Infrastructure.Queries.Handlers;
using Worker.Infrastructure.Services;
using Worker.Infrastructure.Services.Abstract;

namespace Worker.Infrastructure
{
    public static class Extensions
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IWorkerRepository, WorkerRepository>();
            serviceCollection.AddTransient<IGetWorkersHandler, GetWorkersHandler>();
            serviceCollection.AddTransient<IAboutMeHandler, AboutMeHandler>();
            serviceCollection.AddTransient<IMongoClientProvider, MongoClientProvider>();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();

            MongoOptions mongoOptions = configuration.GetSection("Mongo").Get<MongoOptions>();

            serviceCollection.AddSingleton(mongoOptions);
            
            return serviceCollection;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder;
        }
    }
}