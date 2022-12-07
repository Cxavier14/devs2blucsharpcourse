using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>()
            {
                new User {Id = 1, Name = "Eduardo", Login = "eduX"},
                new User {Id = 2, Name = "Andre", Login = "andy"},
                new User {Id = 3, Name = "Flavio", Login = "naio"},
                new User {Id = 4, Name = "Suzano", Login = "suzz"},
                new User {Id = 5, Name = "Freitas", Login = "freitas"},
                new User {Id = 6, Name = "Rogerio", Login = "roger"}
            };
            return View(users);
        }

        [Route("indicadores")]
        [Route("numbers")]
        public IActionResult Indicadores()
        {
            return View();
        }

        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            return PartialView();
        }
    }
}
