using System.Diagnostics;
using CoffeeShop.Models;
using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        public HomeController (IProductRepository productRepositor)
        {
            this.productRepository = productRepositor;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View(productRepository.GetTrendingProducts());
        }

    }
}
