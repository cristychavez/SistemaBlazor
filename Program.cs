using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using SistemaDeREserva.ClienteBlazor;
using SistemaDeREserva.ClienteBlazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7143/api/") });
            builder.Services.AddScoped<IServiciosService, ServiciosService>(); //importacion de los servicios de MudBlazor
            builder.Services.AddScoped<IReservaService, ReservaService>();
            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}

