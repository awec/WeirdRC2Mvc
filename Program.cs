using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace SampleRC2WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
                
            host.Run();
        }
    }
}
