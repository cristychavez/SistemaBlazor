using SistemaDeREserva.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public class ReservaService : IReservaService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public ReservaService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Reserva>> GetAll()
        {
            string resp = await client.GetStringAsync($"Reserva");
            return JsonSerializer.Deserialize<IEnumerable<Reserva>>(resp, options);
        }

        public async Task<IEnumerable<Reserva>> GetByDepartamento(int idDepto)
        {
            var resp = await client.PostAsJsonAsync($"Reserva/Buscar", new { idServicios = idDepto });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Reserva>>(respString, options);
        }

        public async Task<Reserva> GetById(int id)
        {
            string resp = await client.GetStringAsync($"Reserva/{id}");
            return JsonSerializer.Deserialize<Reserva>(resp, options);
        }
    }
}
