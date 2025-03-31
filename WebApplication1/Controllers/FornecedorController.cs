using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Filtros;
using Web.Shared.Repository.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly ILogger<FornecedorController> _logger;
        private readonly IUserRepository _repo;

        public FornecedorController(ILogger<FornecedorController> logger,
            IUserRepository repo
            )
        {
            _logger = logger;
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Cadastrar()
        {
            return View();
        }
    }
}