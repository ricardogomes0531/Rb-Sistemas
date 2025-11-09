using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using Web.Models;
using Web.Shared.Domain;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository.Models;
using Web.Shared.Repository.Querys;

namespace Web.Shared.Repository
{
    public class LoginRepository : ILoginRepository
    {
        public IDbConnection _connection;
        public readonly IConfiguration _configuration;

        public LoginRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new MySqlConnection(configuration.GetSection("Default").Value);
            _connection.Open();
        }

        public async Task<UsuarioModel> Validar(string email, string senha)
        {
            var usuario = new UsuarioModel();
            try
            {
                usuario = _connection.QueryAsync<UsuarioModel>(LoginQuery.Buscar(),
                    new
                    {
                        email,
                        senha
                    }
                                        ).Result.FirstOrDefault();
                                                }

            catch (Exception ex)
            {
                var message = ex.Message;
            }
            return usuario;
        }
    }
}