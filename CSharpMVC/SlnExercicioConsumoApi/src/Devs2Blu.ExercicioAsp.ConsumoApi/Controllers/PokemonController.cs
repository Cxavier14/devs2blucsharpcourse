using Devs2Blu.ExercicioAsp.ConsumoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ExercicioAsp.ConsumoApi.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonApiService _service;
        
        public PokemonController()
        {
            _service = new PokemonApiService();
        }

        public async Task<IActionResult> Index()
        {
            var result = await _service.GetPokemon();
            return View(result);
        }
    }
}
