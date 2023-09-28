using SistemaDeREserva.ClienteBlazor.Models;
using SistemaDeREserva.ClienteBlazor.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public interface IReservaService
    {
        Task<IEnumerable<Reserva>> GetAll();
        Task<IEnumerable<Reserva>> GetByServicios(int idServicio);
        Task<Reserva> GetById(int id);
    }
}
