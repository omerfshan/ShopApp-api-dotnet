using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using shopapp.webui.Extensions;

namespace shopapp.webui
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Geliştirme ortamında Sqlite'a geçiş sonrası eski migration'lar ile model uyuşmazlığı olduğu için
            // otomatik migrate çağrısını devre dışı bırakalım; sadece host'u başlat.
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
