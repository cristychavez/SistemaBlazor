using SistemaDeREserva.ClienteBlazor.Models;
using SistemaDeREserva.ClienteBlazor.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public interface IServiciosService
    {
        Task<IEnumerable<Servicios>> GetAll();
        Task<IEnumerable<Servicios>> GetByServicios(int idReserav);
        Task<Servicios> GetById(int id);
    }
}
