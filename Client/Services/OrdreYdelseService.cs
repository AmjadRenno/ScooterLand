using BlazorAppClientServer.Shared.Models;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace BlazorAppClientServer.Client.Services
{
	public class OrdreYdelseService : IOrdreYdelseService
	{
		private readonly HttpClient httpClient;

		public OrdreYdelseService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<OrdreYdelse[]?> GetAllOrdreYdelser()
		{
			var result = await httpClient.GetFromJsonAsync<OrdreYdelse[]>("api/ordreydelseapi");
			return result;
		}
		public async Task<OrdreYdelse?> GetOrdreYdelse(int id)
		{
			var result = await httpClient.GetFromJsonAsync<OrdreYdelse>("api/ordreydelseapi" + id);
			return result;
		}

		public async Task<int> AddOrdreYdelse(OrdreYdelse ordreYdelse)
		{
			var response = await httpClient.PostAsJsonAsync("api/ordreydelseapi", ordreYdelse);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}

		public async Task<int> DeleteOrdreYdelse(int id)
		{
			var response = await httpClient.DeleteAsync("api/ordreydelseapi/" + id);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;

		}
	}
}
