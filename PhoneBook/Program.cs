using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PhoneBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
      Program p = new Program();
            p.CreateHostBuilder(args).Build().Run();
        }

        public IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
