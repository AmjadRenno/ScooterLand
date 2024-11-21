using BlazorAppClientServer.Shared.Models;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace BlazorAppClientServer.Client.Services
{
	public class OrdreService : IOrdreService
	{
		private readonly HttpClient httpClient;

		public OrdreService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<Ordre[]?> GetAllOrdre()
		{
			var result = await httpClient.GetFromJsonAsync<Ordre[]>("api/ordreapi");
			return result;
		}
		public async Task<Ordre?> GetOrdre(int id)
		{
			var result = await httpClient.GetFromJsonAsync<Ordre>("api/ordreapi" + id);
			return result;
		}

		public async Task<int> AddOrdre(Ordre ordre)
		{
			var response = await httpClient.PostAsJsonAsync("api/ordreapi", ordre);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}

		public async Task<int> DeleteOrdre(int id)
		{
			var response = await httpClient.DeleteAsync("api/ordreapi/" + id);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;

		}
		public async Task<int> UpdateOrdre(Ordre ordre)
		{
			var response = await httpClient.PutAsJsonAsync("api/ordreapi", ordre);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}
	}
}
