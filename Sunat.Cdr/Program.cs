using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Sunat.Cdr.Service;

namespace Sunat.Cdr
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length < 1)
            {
                return;
            }

            Console.WriteLine(args[0]);

            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var clave = new ClaveSol();
            config.GetSection("ClaveSol").Bind(clave);

            var service = new CdrService(clave)
            {
                ServiceUrl = config["ServiceUrl"]
            };

            var parts = args[0].Split('-');
            var result = await service.GetCdr(parts[0], parts[1], parts[2], int.Parse(parts[3]));

            Console.WriteLine($"Code: {result.statusCode} - Message: {result.statusMessage}");
        }
    }
}
