using Demo.API.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Migrate on startup
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    // TODO: Remove these lines and implement a more robust migration in Jenkins
                    var context = scope.ServiceProvider.GetService<DemoContext>();
                    context.Database.Migrate();
                }
                catch
                {
                    // Catch all
                }
            }

            // Start Service
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
