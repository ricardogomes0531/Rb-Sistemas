using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository;

namespace Web.Shared.Ioc
{
    public static class RepositoryServices
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services
                .AddScoped<IUserRepository, UserRepository>()
                                .AddScoped<IFornecedorRepository, FornecedorRepository>()
                                .AddScoped<IClienteRepository, ClienteRepository>()
                ;
            return services;
        }
    }
}
