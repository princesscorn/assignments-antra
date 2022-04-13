using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /* create a host */
        public static IHostBuilder CreateHostBuilder (string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(
                webBuilder => { webBuilder.UseStartup<Startup>(); }
                );
        }
    }
}
