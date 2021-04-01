using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Core.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            CreateHostBuilder(args).Build().Run();

        }
       
       /* static async Task Main(string[] args)
        {

            string urlApi = "http://localhost:44338/TxJuros";
            var client = new System.Net.Http.HttpClient();

            decimal resultado =
             await client.GetFromJsonAsync<decimal>(urlApi);
            Util.TxGlobal = resultado;
            CreateHostBuilder(args).Build().Run();


        }*/

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
