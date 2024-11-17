using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
	public interface IMekanikerRepository
	{
		List<Mekaniker> GetAllMekaniker();
		Mekaniker GetMekaniker(int id);
		void AddMekaniker(Mekaniker mekaniker);
		bool DeleteMekaniker(int id);
		bool UpdateMekaniker(Mekaniker mekaniker);
	}
}
