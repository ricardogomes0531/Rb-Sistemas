using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Filtros;
using Web.Shared.Repository.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _repo;

        public HomeController(ILogger<HomeController> logger,
            IUserRepository repo
            )
        {
            _logger = logger;
            _repo = repo;
        }
        [Authorize]
                        public async Task<IActionResult> Index()
        {
            Response.Cookies.Append("login", "ej.ricardogomes@gmail.com");
            ViewData["valor"] = "oi "+Request.Cookies["login"];
            return View();
        }

        [PermissoesFilters]
        public IActionResult Privacy()
        {
            ViewData["valor"] = "oi " + Request.Cookies["login"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
