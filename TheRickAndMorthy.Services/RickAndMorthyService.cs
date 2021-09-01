using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TheRickAndMorthy.Models;

namespace TheRickAndMorthy.Services
{
    public class RickAndMorthyService
    {
        readonly HttpClient httpClient;
        public RickAndMorthyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Response<Character>> GetCharactersAsync()
        {
            var content = await this.httpClient.GetStringAsync("character");
            return JsonSerializer.Deserialize<Response<Character>>(content);
        }
    }
}
