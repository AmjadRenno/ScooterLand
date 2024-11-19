using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
	public interface IOrdreRepository
	{
		List<Ordre> GetAllOrdre();
		Ordre GetOrdre(int id);
		void AddOrdre(Ordre ordre);
		bool DeleteOrdre(int id);
		bool UpdateOrdre(Ordre ordre);
	}
}
