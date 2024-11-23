using BlazorAppClientServer.Shared.Models;
using System.Collections;

namespace BlazorAppClientServer.Client.Services
{
	public interface IOrdreYdelseService
	{
		Task<OrdreYdelse[]?> GetAllOrdreYdelser();
		Task<OrdreYdelse?> GetOrdreYdelse(int id);
		Task<int> AddOrdreYdelse(OrdreYdelse ordreYdelse);
		Task<int> DeleteOrdreYdelse(int id);
	}
}
