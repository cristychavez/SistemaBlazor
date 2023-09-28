using SistemaDeREserva.ClienteBlazor.Models;
using SistemaDeREserva.ClienteBlazor.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public class ServiciosService : IServiciosService
    {

        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public ServiciosService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Servicio>> GetAll()
        {
            string resp = await client.GetStringAsync($"Servicio");
            return JsonSerializer.Deserialize<IEnumerable<Servicio>>(resp, options);
        }

        public async Task<IEnumerable<Servicio>> GetByServicios(int idReservas)
        {
            var resp = await client.PostAsJsonAsync($"Servicio/Buscar", new { idServicios = idReservas });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Servicio>>(respString, options);
        }

        public async Task<Servicio> GetById(int id)
        {
            string resp = await client.GetStringAsync($"Servicio/{id}");
            return JsonSerializer.Deserialize<Servicio>(resp, options);
        }
    }
}

