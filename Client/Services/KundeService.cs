using BlazorAppClientServer.Shared.Models;
using System.Net.Http.Json;

namespace BlazorAppClientServer.Client.Services
{
	public class KundeService : IKundeService
	{
		private readonly HttpClient httpClient;

		public KundeService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<Kunde[]?> GetAllKunder()
		{
			var result = await httpClient.GetFromJsonAsync<Kunde[]>("api/kundeapi");
			return result;
		}
		public async Task<Kunde?> GetKunde(int id)
		{
			var result = await httpClient.GetFromJsonAsync<Kunde>("api/kundeapi" + id);
			return result;
		}

		public async Task<int> AddKunde(Kunde kunde)
		{
			var response = await httpClient.PostAsJsonAsync("api/kundeapi", kunde);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}

		public async Task<int> DeleteKunde(int id)
		{
			var response = await httpClient.DeleteAsync("api/kundeapi/" + id);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;

		}
		public async Task<int> UpdateKunde(Kunde kunde)
		{
			var response = await httpClient.PutAsJsonAsync("api/kundeapi", kunde);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}
	}
}
