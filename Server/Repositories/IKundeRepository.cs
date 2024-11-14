using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
	public interface IKundeRepository
	{
		List<Kunde> GetKunder();
		Kunde GetKunde(int id);
		void AddKunde(Kunde kunde);
		bool DeleteKunde(int id);
		bool UpdateKunde(Kunde kunde);
	}
}
