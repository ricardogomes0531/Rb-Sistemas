using Microsoft.AspNetCore.Mvc;
using Web.Models.Login;
using Web.Shared.Repository.Interfaces;
using Web.Shared.Services;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginRepository _repo;
        private readonly ITokenService _tokenService;

        public LoginController(
            ILogger<LoginController> logger,
            ILoginRepository repo,
            ITokenService tokenService
                                    )
        {
            _logger = logger;
            _repo = repo;
            _tokenService = tokenService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            var token = string.Empty;
            var usuarioValido = _repo.Validar(request.Email, request.Senha).Result;
            if (usuarioValido is not null && usuarioValido.Id > default(int))
            {
                var roles = new string[1];
                roles[0] = usuarioValido.Perfil;
                var tokenGerado = _tokenService.Generate(new Shared.Domain.Authorization.AuthUser { Name = usuarioValido.Nome, Id = usuarioValido.Id, IdEmpresa = usuarioValido.CodigoEmpresa, Roles = roles });
                token = tokenGerado;
            }
            return Json(new { token = token });
        }

    }
}