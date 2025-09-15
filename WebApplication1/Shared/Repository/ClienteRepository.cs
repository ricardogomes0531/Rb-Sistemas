using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using Web.Shared.Domain;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository.Models;
using Web.Shared.Repository.Querys;

namespace Web.Shared.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public IDbConnection _connection;
        public readonly IConfiguration _configuration;

        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new MySqlConnection(configuration.GetSection("Default").Value);
            _connection.Open();
        }

        public async Task<IEnumerable<Cliente>> ListarTodos()
        {
            var clientes = new List<Cliente>();
            try
            {
                clientes = [.. _connection.QueryAsync<Cliente>(ClienteQuery.ListarTodos()).Result];


            }

            catch (Exception ex)
            {
                var message = ex.Message;
            }
            return clientes;
        }

        public async Task<bool> Inserir(ClienteModel model)
        {
            var result = false;
            try
            {

                var query = await _connection.ExecuteAsync(ClienteQuery.Inserir(), new
                {
                    model.Nome,
                    model.Email,
                    model.DddCelular,
                                        model.Celular,
                                        model.DataNascimento,
                                        model.DataInsersao,
                                        model.UsuarioInsersao,
                                        model.DataAlteracao,
                                        model.UsuarioAlteracao
                                                                            });
                if (query > 0)
                {
                    result = true;
                }
            }

            catch (Exception ex)
            {
                var resultEx = ex.Message;
            }
            return result;
        }



    }
}
