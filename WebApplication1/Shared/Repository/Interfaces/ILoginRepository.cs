using Web.Shared.Domain;
using Web.Shared.Repository.Models;

namespace Web.Shared.Repository.Interfaces
{
    public interface ILoginRepository
    {
        Task<UsuarioModel> Validar(string email, string senha);
    }
}
