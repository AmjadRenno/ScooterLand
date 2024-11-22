using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Client.Services
{
	public interface IMekanikerService
	{
		Task<Mekaniker[]?> GetAllMekaniker();
		Task<Mekaniker?> GetMekaniker(int id);
		Task<int> AddMekaniker(Mekaniker mekaniker);
		Task<int> DeleteMekaniker(int id);
		Task<int> UpdateMekaniker(Mekaniker mekaniker);
	}
}
