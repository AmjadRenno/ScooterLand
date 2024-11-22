using BlazorAppClientServer.Shared.Models;
using System.Collections;

namespace BlazorAppClientServer.Client.Services
{
	public interface IOrdreService
	{
		Task<Ordre[]?> GetAllOrdre();
		Task<Ordre?> GetOrdre(int id);
		Task<int> AddOrdre(Ordre odre);
		Task<int> DeleteOrdre(int id);
		Task<int> UpdateOrdre(Ordre odre);
        Task<List<Ordre>> GetOrdersByMechanicAsync(int mechanicId);
    }
}
