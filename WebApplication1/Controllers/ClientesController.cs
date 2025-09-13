using Microsoft.AspNetCore.Mvc;
using Web.Models.Fornecedor;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository.Models;

namespace Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IFornecedorRepository _repo;

        public ClientesController(ILogger<ClientesController> logger,
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

        public async Task<IActionResult> Novo()
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