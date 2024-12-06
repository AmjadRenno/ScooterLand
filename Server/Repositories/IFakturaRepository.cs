using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
    public interface IFakturaRepository
    {
        List<Faktura> GetAllFakturaer();
        Faktura? GetFaktura(int id);
        void AddFaktura(Faktura faktura);
        bool DeleteFaktura(int id);
        bool UpdateFaktura(Faktura faktura);
        bool MarkOrderAsCompleted(int fakturaId);
    }
}
