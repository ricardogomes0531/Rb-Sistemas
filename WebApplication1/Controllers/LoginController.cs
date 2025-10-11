using Microsoft.AspNetCore.Mvc;
using Web.Shared.Repository.Interfaces;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IClienteRepository _repo;

        public LoginController(
            ILogger<LoginController> logger,
            IClienteRepository repo
                        )
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
