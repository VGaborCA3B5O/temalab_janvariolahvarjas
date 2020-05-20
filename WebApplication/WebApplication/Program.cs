using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebApplication.Data;
using WebApplication.Hosting;

namespace WebApplication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            (await CreateWebHostBuilder(args)
            .Build()
            .MigrateDatabase<ApplicationDbContext>())
            .Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
