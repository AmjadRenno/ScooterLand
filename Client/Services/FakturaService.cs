using BlazorAppClientServer.Shared.Models;
using System.Net.Http.Json;

namespace BlazorAppClientServer.Client.Services
{
    public class FakturaService : IFakturaService
    {
        private readonly HttpClient httpClient;

        public FakturaService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Faktura>> GetAllFakturaer()
        {
            return await httpClient.GetFromJsonAsync<List<Faktura>>("api/faktura");
        }

        public async Task<Faktura?> SearchFakturaByID(int searchId, bool isOrdreId)
        {
            return await httpClient.GetFromJsonAsync<Faktura>($"api/faktura/search/{searchId}/{isOrdreId}");
        }

        public async Task<int> AddFaktura(Faktura faktura)
        {
            var response = await httpClient.PostAsJsonAsync("api/faktura", faktura);
            return (int)response.StatusCode;
        }

        public async Task<int> DeleteFakturaWithSql(int fakturaId)
        {
            var response = await httpClient.DeleteAsync($"api/faktura/delete-with-sql/{fakturaId}");
            return (int)response.StatusCode;
        }


        public async Task<int> MarkOrderAsCompleted(int fakturaId)
        {
            var response = await httpClient.PostAsync($"api/faktura/mark-completed/{fakturaId}", null);
            return (int)response.StatusCode;
        }

       
    }
}


