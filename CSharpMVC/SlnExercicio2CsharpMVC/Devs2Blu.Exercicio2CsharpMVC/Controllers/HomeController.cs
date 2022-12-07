using Devs2Blu.Exercicio2CsharpMVC.Models;
using Devs2Blu.Exercicio2CsharpMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.Exercicio2CsharpMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServiceApi _serviceApi;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _serviceApi = new ServiceApi();
        }

        public IActionResult Index()
        {
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