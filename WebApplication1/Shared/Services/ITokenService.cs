using Web.Shared.Domain.Authorization;

namespace Web.Shared.Services
{
    public interface ITokenService
    {
        string Generate(AuthUser user);
    }
}