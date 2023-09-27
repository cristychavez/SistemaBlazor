using SistemaDeREserva.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public interface IReservaService
    {
        Task<IEnumerable<Reserva>> GetAll();
        Task<IEnumerable<Reserva>> GetByDepartamento(int idDepto);
        Task<Reserva> GetById(int id);
    }
}
