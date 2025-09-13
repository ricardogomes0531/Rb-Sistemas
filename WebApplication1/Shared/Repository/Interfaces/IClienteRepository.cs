using Web.Shared.Domain;
using Web.Shared.Repository.Models;

namespace Web.Shared.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> ListarTodos();
        Task<bool> Inserir(ClienteModel model);
    }
}
