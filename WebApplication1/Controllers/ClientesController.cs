using Microsoft.AspNetCore.Mvc;
using Web.Models.Cliente;
using Web.Models.Fornecedor;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository.Models;

namespace Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IClienteRepository _repo;

        public ClientesController(ILogger<ClientesController> logger,
            IClienteRepository repo
            )
        {
            _logger = logger;
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
         var cliente = await _repo.ListarTodos();
            return View(cliente);
        }

        public async Task<IActionResult> Novo()
        {
            return View();
        }


        [HttpPost]
        public async Task<JsonResult> Cadastrar(ClienteRequest request)
        {
            var insereRequest = new ClienteModel()
            {
                 Celular = request.Celular,
                  DataAlteracao = request.DataAlteracao,
                   DataInsersao = request.DataInsersao,
                    DataNascimento = request.DataNascimento,
                     DddCelular = request.DddCelular,
                      Email = request.Email,
                       Nome = request.Nome,
                        UsuarioAlteracao = request.UsuarioAlteracao,
                         UsuarioInsersao = request.UsuarioInsersao

            };
            var insereResult = await _repo.Inserir(insereRequest);
            return Json(new { });
        }
    }
}