using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Client.Services
{
	public interface IKundeService
	{
		Task<Kunde[]?> GetAllKunder();
		Task<Kunde?> GetKunde(int id);
		Task<int> AddKunde(Kunde kunde);
		Task<int> DeleteKunde(int id);
		Task<bool> UpdateKunde(Kunde kunde);
	}
}
