using BlazorAppClientServer.Shared.Models;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Client.Services
{
    public interface IFakturaService
    {
        Task<List<Faktura>> GetAllFakturaer();
        Task<Faktura?> SearchFakturaByID(int searchId, bool isOrdreId);
        Task<int> AddFaktura(Faktura faktura);
        Task<int> DeleteFakturaWithSql(int fakturaId);
        Task<int> MarkOrderAsCompleted(int fakturaId);

    }
}

