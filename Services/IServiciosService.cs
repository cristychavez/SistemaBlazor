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
        Task<IEnumerable<Servicio>> GetAll();
        Task<IEnumerable<Servicio>> GetByServicios(int idReserav);
        Task<Servicio> GetById(int id);
    }
}
