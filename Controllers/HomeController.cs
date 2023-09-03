using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Diagnostics;

namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductsDbContext productsDbContext;

        public HomeController(ILogger<HomeController> logger, ProductsDbContext productsDbContext)
        {
            _logger = logger;
            this.productsDbContext = productsDbContext;
        }

        public IActionResult Index()
        {
            var products = productsDbContext.Products.ToList();

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