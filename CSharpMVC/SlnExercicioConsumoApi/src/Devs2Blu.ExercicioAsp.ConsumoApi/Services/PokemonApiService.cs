using Devs2Blu.ExercicioAsp.ConsumoApi.Models;

namespace Devs2Blu.ExercicioAsp.ConsumoApi.Services
{
    public class PokemonApiService
    {
        private readonly ConsumoApiService _consumoApiService;
        const string URL_API_POKEMON = "https://pokeapi.co/api/v2/pokemon/";

        public PokemonApiService()
        {
            _consumoApiService = new ConsumoApiService();
        }

        public async Task<Pokemon> GetPokemon()
        {
            return await _consumoApiService.GetApi<Pokemon>(URL_API_POKEMON);
        }
    }
}
