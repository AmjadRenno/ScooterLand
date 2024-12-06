using BlazorAppClientServer.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Client.Services
{
    public class MærkeService : IMærkeService
    {
        private readonly HttpClient httpClient;

        public MærkeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Mærke[]?> GetAllMærker()
        {
			var result = await httpClient.GetFromJsonAsync<Mærke[]>("api/maerkeapi");
			return result;
        }

        public async Task<Mærke> GetMærkeById(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Mærke>($"api/maerkeapi/{id}");
            return result;
        }

        public async Task<bool> AddMærke(Mærke mærke)
        {
            var response = await httpClient.PostAsJsonAsync("api/maerkeapi", mærke);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateMærke(Mærke mærke)
        {
            var response = await httpClient.PutAsJsonAsync("api/maerkeapi", mærke);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteMærke(int id)
        {
            var response = await httpClient.DeleteAsync($"api/maerkeapi/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
