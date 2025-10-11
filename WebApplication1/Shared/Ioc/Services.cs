using Web.Shared.Services;

namespace Web.Shared.Ioc
{
    public static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            return
                service.AddScoped<ITokenService, TokenService>();

        }

    }
}
