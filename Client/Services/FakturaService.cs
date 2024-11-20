using BlazorAppClientServer.Shared.Models;
using System.Net.Http.Json;

namespace BlazorAppClientServer.Client.Services
{
    public class FakturaService : IFakturaService
    {
        private readonly HttpClient _httpClient;

        public FakturaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Faktura[]> GetAllFakturaer()
        {
            return await _httpClient.GetFromJsonAsync<Faktura[]>("api/faktura");
        }

        public async Task<Faktura?> GetFaktura(int id)
        {
            return await _httpClient.GetFromJsonAsync<Faktura>($"api/faktura/{id}");
        }

        public async Task<int> AddFaktura(Faktura faktura)
        {
            var response = await _httpClient.PostAsJsonAsync("api/faktura", faktura);
            return (int)response.StatusCode;
        }

        public async Task<int> DeleteFaktura(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/faktura/{id}");
            return (int)response.StatusCode;
        }

        public async Task<int> UpdateFaktura(Faktura faktura)
        {
            var response = await _httpClient.PutAsJsonAsync("api/faktura", faktura);
            return (int)response.StatusCode;
        }
    }
}
