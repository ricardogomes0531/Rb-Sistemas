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

        public async Task<IEnumerable<Fornecedor>> ListarTodos()
        {
            var fornecedores = new List<Fornecedor>();
            try
            {
                fornecedores = _connection.QueryAsync<Fornecedor>(FornecedorQuery.ListarTodos()).Result.ToList();


            }
            
            catch(Exception ex)
            {
                var message = ex.Message;
            }
            return fornecedores;
        }
        public async Task<bool> Inserir(FornecedorModel model)
        {
            var result = false;
            try
            {

                var query = await _connection.ExecuteAsync(FornecedorQuery.Inserir(), new
                {
                    model.Nome,
                    model.Descricao,
                    model.Email,
                    model.DddCelular,
                    model.Celular,
                    model.DddTelefone,
                    model.Telefone,
                    model.Documento,
                    model.Endereco,
                    model.Bairro,
                    model.Cidade,
                    model.Uf,
                    model.Cep,
                                        model.FormaPagamentoPrincipal
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
