using Web.Shared.Domain;
using Web.Shared.Repository.Models;

namespace Web.Shared.Repository.Interfaces
{
    public interface IFornecedorRepository
    {
        Task<IEnumerable<Fornecedor>> ListarTodos();
        Task<bool> Inserir(FornecedorModel model);
    }
}
