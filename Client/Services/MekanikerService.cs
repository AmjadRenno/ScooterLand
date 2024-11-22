using BlazorAppClientServer.Shared.Models;
using System.Net.Http.Json;

namespace BlazorAppClientServer.Client.Services
{
	public class MekanikerService : IMekanikerService
	{
		private readonly HttpClient httpClient;

		public MekanikerService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<Mekaniker[]?> GetAllMekaniker()
		{	
			var result = await httpClient.GetFromJsonAsync<Mekaniker[]>("api/mekanikerapi");
			return result;
		}
		public async Task<Mekaniker?> GetMekaniker(int id)
		{
			var result = await httpClient.GetFromJsonAsync<Mekaniker>("api/mekanikerapi" + id);
			return result;
		}

		public async Task<int> AddMekaniker(Mekaniker mekaniker)
		{
			var response = await httpClient.PostAsJsonAsync("api/mekanikerapi", mekaniker);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}

		public async Task<int> DeleteMekaniker(int id)
		{
			var response = await httpClient.DeleteAsync("api/mekanikerapi/" + id);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;

		}
		public async Task<int> UpdateMekaniker(Mekaniker mekaniker)
		{
			var response = await httpClient.PutAsJsonAsync("api/mekanikerapi", mekaniker);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}
	}
}
