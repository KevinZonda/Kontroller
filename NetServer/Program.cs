using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Kontroller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                if (arg == "debug=true")
                    Config.IsDebug = true;
                if (arg.StartsWith("key="))
                {
                    if (string.IsNullOrEmpty(Config.OtpKey))
                    {
                        if (arg.Length != 4)
                        {
                            Config.OtpKey = arg.Substring(4).Trim();
                        }
                    }
                    else
                    {
                        throw new ArgumentException("You cannot set OtpKey twice.");
                    }
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}