using SistemaDeREserva.ClienteBlazor.Models;
using SistemaDeREserva.ClienteBlazor.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaDeREserva.ClienteBlazor.Services
{
    public class IMesasService
    {
        Task<IEnumerable<Mesas>> GetAll();
        Task<IEnumerable<Mesas>> GetByServicios(int idReserav);
        Task<Mesas> GetById(int id);
    }
}
