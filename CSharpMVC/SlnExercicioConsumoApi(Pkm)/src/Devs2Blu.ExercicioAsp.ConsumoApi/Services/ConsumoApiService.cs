namespace Devs2Blu.ExercicioAsp.ConsumoApi.Services
{
    public class ConsumoApiService
    {
        private readonly HttpClient _httpClient;

        public ConsumoApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> GetApi<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                throw new Exception("Ocorreu um problema! Por favor, contate o suporte!");

            return await listHttp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<List<T>> GetListApi<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();
        }

        private async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }
    }
}
