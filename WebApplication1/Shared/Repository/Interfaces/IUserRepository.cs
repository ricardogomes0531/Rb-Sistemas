using Web.Shared.Domain;

namespace Web.Shared.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IList<User>> GetUserByIdAsync(int id);
    }
}
