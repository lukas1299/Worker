using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Worker.Application;
using Worker.Infrastructure;

namespace Worker.API
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateWebHostBuilder(args).Build().RunAsync();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                    {
                        services.AddControllers();
                        services
                            .AddApplication()
                            .AddInfrastructure();
                    }
                )
                .Configure(app =>
                    {
                        app.UseRouting();
                        app
                            .UseApplication()
                            .UseInfrastructure();
                        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
                    }
                );

    }
}