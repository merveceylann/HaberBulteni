using HaberPortal.Models.DTOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace HaberPortal.ApiService
{
    public class RootApiService
    {
        private readonly HttpClient _httpClient;
        public RootApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Rootobject> GetAllAsync()
        {
            Rootobject itemlistDtos;
            var response = await _httpClient.GetAsync("http://turkmedya.com.tr/anasayfa.json");
            if (response.IsSuccessStatusCode)
            {
                itemlistDtos = JsonConvert.DeserializeObject<Rootobject>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                itemlistDtos = null;
            }
            return itemlistDtos;
        }
    }
}
