using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.Exercicio01MVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
