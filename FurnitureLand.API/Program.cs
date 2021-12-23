using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurnitureLand.API.Common;
using FurnitureLand.DatabaseMigration;
using FurnitureLand.Domain.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FurnitureLand.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args);
            var host = hostBuilder.Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var hostingEnvironment = services.GetRequiredService<IWebHostEnvironment>();
                var configuration = services.GetRequiredService<IConfiguration>();

                var context = services.GetRequiredService<AppDatabaseContext>();
                var userManager = services.GetRequiredService<UserManager<Customers>>();

                //seed initial data
                Seeder.SeedDefaultData(userManager, context).Wait();

                host.Run();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
