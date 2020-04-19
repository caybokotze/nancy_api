
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace NancyAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            // var host = new WebHostBuilder()
            //     //.UseContentRoot(Directory.GetCurrentDirectory())
            //     .UseKestrel()
            //     .UseStartup<Startup>()
            //     .Build();
            // //
            // Console.WriteLine("hello.");
            //
            // host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseContentRoot(Directory.GetCurrentDirectory())
                    .UseKestrel(o => o.AllowSynchronousIO = true)
                    .UseStartup<Startup>();
            });
    }
}