using SistemaDeREserva.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public interface IServiciosService
    {
        Task<IEnumerable<Servicio>> GetAll();

    }
}
