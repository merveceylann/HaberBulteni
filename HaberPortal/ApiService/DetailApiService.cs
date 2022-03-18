using HaberPortal.Models.DetailDtos;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace HaberPortal.ApiService
{
    public class DetailApiService
    {
        private readonly HttpClient _httpClient;
        public DetailApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Root> GetAllAsync()
        {
            Root itemlistDtos;
            var response = await _httpClient.GetAsync("http://turkmedya.com.tr/detay.json");
            if (response.IsSuccessStatusCode)
            {
                itemlistDtos = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                itemlistDtos = null;
            }
            return itemlistDtos;
        }
    }
}
