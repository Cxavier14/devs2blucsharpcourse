using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("consulta")]
    public class ConsultaApiController : Controller
    {
        private readonly PokemonAPIService _service = new();
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetPokemons();
            return View(result);
        }
               
        [Route("pokemons")]
        public PartialViewResult Pokemons()
        {
            
            return PartialView();
        }
    }
}
