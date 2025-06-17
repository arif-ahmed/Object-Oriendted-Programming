using HotelManagementSystem.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagementSystem
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Setup DI
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Run application
            var app = serviceProvider.GetRequiredService<App>();
            await app.RunAsync();
        }

        static void ConfigureServices(IServiceCollection services)
        {
            // Register services
            // services.AddTransient<IGreetingService, GreetingService>();
            services.AddTransient<BookingService>();

            // Register entry point
            services.AddTransient<App>();
        }
    }
}
