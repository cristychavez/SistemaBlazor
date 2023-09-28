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
    public class MesasService : IMesaService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public MesasService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Mesa>> GetAll()
        {
            string resp = await client.GetStringAsync($"Reserva");
            return JsonSerializer.Deserialize<IEnumerable<Mesa>>(resp, options);
        }

        public async Task<IEnumerable<Mesa>> GetByServicios(int idReservas)
        {
            var resp = await client.PostAsJsonAsync($"Reserva/Buscar", new { idServicios = idReservas });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Mesa>>(respString, options);
        }

        public async Task<Mesa> GetById(int id)
        {
            string resp = await client.GetStringAsync($"Reserva/{id}");
            return JsonSerializer.Deserialize<Mesa>(resp, options);
        }        
    }
}
