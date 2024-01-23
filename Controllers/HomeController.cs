using Microsoft.AspNetCore.Mvc;
using PartialViewwithASPCore.Models;
using System.Diagnostics;

namespace PartialViewwithASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            { 
                new Product() {Id=101,Name="HeadPhone",Description="Description1",Price=500.00,Image="~/Images/HeadPhone.jpg"},
                new Product() {Id=102,Name="Camera",Description="Description2",Price=5000.00,Image="~/Images/Camera.jpg"},
                new Product() {Id=103,Name="Shoes",Description="Description3",Price=6000.00,Image="~/Images/Shoes.jpg"},

            };
            return View(products);
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