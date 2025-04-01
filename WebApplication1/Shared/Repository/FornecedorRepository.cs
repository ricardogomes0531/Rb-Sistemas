using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using Web.Shared.Domain;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository.Querys;

namespace Web.Shared.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public IDbConnection _connection;
        public readonly IConfiguration _configuration;

        public FornecedorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new MySqlConnection(configuration.GetSection("Default").Value);
            _connection.Open();
        }

        public async Task<IList<User>> GetUserByIdAsync(int id)
        {
            var query = await _connection.QueryAsync<User>(UserQuery.GetUserByIdQuery(), new
            {
                id
            });
            return query.ToList();
        }



    }
}
