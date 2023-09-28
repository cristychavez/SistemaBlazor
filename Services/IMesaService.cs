using SistemaDeREserva.ClienteBlazor.Models;

namespace SistemaDeREserva.ClienteBlazor.Services
{
    public interface IMesaService
    {
        Task<IEnumerable<Mesa>> GetAll();
        Task<IEnumerable<Mesa>> GetByServicios(int idReserav);
        Task<Mesa> GetById(int id);
    }
}
