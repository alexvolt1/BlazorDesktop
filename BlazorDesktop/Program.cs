using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebWindows;

namespace BlazorDesktop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            //ComponentsDesktop.Run<Startup>("My Blazor App", "http://localhost:60039/api/authors");



            var window = new WebWindow("My super app");
            //window.NavigateToString("<h1>Hello, world!</h1> This window is from a .NET Core app.");
             window.NavigateToUrl("https://google.com");
            window.WaitForExit();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
