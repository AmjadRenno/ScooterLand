using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Client.Services
{
    public interface IFakturaService
    {
        Task<Faktura[]> GetAllFakturaer();
        Task<Faktura?> GetFaktura(int id);
        Task<int> AddFaktura(Faktura faktura);
        Task<int> DeleteFaktura(int id);
        Task<int> UpdateFaktura(Faktura faktura);
    }
}
