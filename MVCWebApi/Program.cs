using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MVCWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IoC iocmanager = new IoC();
            iocmanager.Setup();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
