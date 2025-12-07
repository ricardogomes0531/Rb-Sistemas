using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Models.Cliente;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Repository.Models;

namespace Web.Controllers
{
    public class ServicosController : Controller
    {
        private readonly ILogger<ServicosController> _logger;
        private readonly IClienteRepository _repo;

        public ServicosController(ILogger<ServicosController> logger,
            IClienteRepository repo
            )
        {
            _logger = logger;
            _repo = repo;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Novo()
        {
            return View();
        }

        [Authorize]
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
                Sexo = request.Sexo,
                UsuarioAlteracao = request.UsuarioAlteracao,
                UsuarioInsersao = request.UsuarioInsersao

            };
            var insereResult = await _repo.Inserir(insereRequest);
            return Json(new { });
        }
    }
}