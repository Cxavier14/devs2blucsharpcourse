using Devs2Blu.Exercicio2CsharpMVC.Models;

namespace Devs2Blu.Exercicio2CsharpMVC.Services
{
    public class ServiceApi
    {
        private readonly HttpClient _httpClient;

        public ServiceApi()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<BobsBurguer>> GetCharacters()
        {
            var response = await GetList<BobsBurguer>($"{URL_BOBS_BURGUER}?limit=20");
            return response;
        }

        public async Task<List<Burguer>> GetBurguers()
        {
            var response = await GetList<Burguer>($"{URL_BURGUERS}?limit=20");
            return response;
        }

        public async Task<List<Burguer>> GetBurguerOfTheDay()
        {
            Random rd = new Random();
            var response = await GetList<Burguer>($"{URL_BURGUERS}/{rd.Next(1,333)}");
            return response;
        }

        public async Task<BobsBurguer> GetCharacterByName(string nome)
        {
            var urlScr = $"{URL_BOBS_BURGUER}?={nome}";
            var response = await Get<BobsBurguer>(urlScr);
            return response;
        }

        #region BaseMethods
        public async Task<T> Get<T>(string url)
        {
            var objHttp = await GetAsync(url);

            if (!objHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await objHttp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }
        #endregion

        #region CONSTS
        private const string URL_BOBS_BURGUER = "https://bobsburgers-api.herokuapp.com/characters";        
        private const string URL_BURGUERS = "https://bobsburgers-api.herokuapp.com/burgerOfTheDay";
        #endregion
    }
}
