using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> Index()
        {
            var resultado = await _repo.GetUserByIdAsync(1);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
