using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Filtros;
using Web.Models.Fornecedor;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly ILogger<FornecedorController> _logger;
        private readonly IFornecedorRepository _repo;

        public FornecedorController(ILogger<FornecedorController> logger,
            IFornecedorRepository repo
            )
        {
            _logger = logger;
            _repo = repo;
        }
        
        public async Task<IActionResult> Index()
        {
            var fornecedor = await _repo.ListarTodos();
            return View(fornecedor);
        }

        public async Task<IActionResult> Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public async Task<JsonResult> Cadastrar(FornecedorRequest request)
        {
            var insereRequest = new FornecedorModel()
            {
                 Celular = request.Celular,
                  DddCelular = request.DddCelular,
                   DddTelefone = request.DddTelefone,
                     Descricao = request.Descricao,
                      Email = request.Email,
                       FormaPagamentoPrincipal = request.FormaPagamentoPrincipal,
                        Nome = request.Nome,
                         Telefone = request.Telefone,
                         Documento = request.Documento,
                          Bairro = request.Bairro,
                           Cep = request.Cep,
                            Cidade = request.Cidade,
                             Endereco = request.Endereco,
                                                        Uf = request.Uf
            };
            var insereResult = await _repo.Inserir(insereRequest);
            return Json(new { });
        }
    }
}