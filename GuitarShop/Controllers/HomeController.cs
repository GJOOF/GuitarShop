using GuitarShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productRepository;

        public HomeController()
        {
            productRepository = new ProductRepository();
        }

        public string Index()
        {
            List<Product> products = productRepository.GetProducts();
            return string.Join("\n\n", products);
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
