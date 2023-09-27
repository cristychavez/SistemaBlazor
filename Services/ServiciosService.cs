using SistemaDeREserva.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public class ServiciosService : IServiciosService
    {

        //inyeccion de depensecias de HttClient
        private readonly HttpClient _httpClient;
        public ServiciosService(HttpClient httpClient)
        {
            _httpClient = httpClient;

    }
           public async Task<IEnumerable<Servicio>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Servicio");
            return JsonSerializer.Deserialize<IEnumerable<Servicio>>(resp, options);
        }
       
    }
}
