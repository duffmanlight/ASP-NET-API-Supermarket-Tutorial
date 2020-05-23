using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Supermarket.API
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                // build the web host
                .Build()
                // and run the web host
                .Run();
        }

        // IHostBuilder: The host builder constructs the host and configures various services.
        // This is the generalization of the previous IWebHostBuilder but also basically does the same 
        // just for generic IHost. It configures the host before the application starts.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            // create a default web host builder, with the default settings and configuration
            Host.CreateDefaultBuilder(args)
                // configure it to use your 'Startup' class
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }
                );
    }
}
