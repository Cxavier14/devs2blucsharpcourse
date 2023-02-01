using Devs2Blu.Exercicio2CsharpMVC.Models;
using Devs2Blu.Exercicio2CsharpMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.Exercicio2CsharpMVC.Controllers
{
    [Route("personagens")]
    public class BobsBurguerController : Controller
    {
        private readonly ServiceApi _serviceApi;

        public BobsBurguerController()
        {
            _serviceApi = new ServiceApi();
        }
                
        public async Task<IActionResult> Index()
        {
            var personagens = await _serviceApi.GetCharacters();
            return View(personagens);
        }

        [Route("burguers")]
        public async Task<IActionResult> Burguers()
        {
            var burguers = await _serviceApi.GetBurguers();
            return View(burguers);
        }

        [Route("burguerdodia")]
        public async Task<PartialViewResult> BurguerdoDia()
        {
            var burguer = await _serviceApi.GetBurguerOfTheDay();
            return PartialView(burguer);
        }

        [Route("search/{name}")]
        public async Task<IActionResult> SearchCharacter(string name)
        {
            var character = await _serviceApi.GetCharacterByName(name);
            return PartialView(character);
        }
    }
}
