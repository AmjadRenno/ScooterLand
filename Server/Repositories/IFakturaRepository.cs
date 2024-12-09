using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
    public interface IFakturaRepository
    {
        List<Faktura> GetAllFakturaer();
        Faktura? SearchFakturaByID(int searchId, bool isOrdreId);
        void AddFaktura(Faktura faktura);
        bool DeleteFakturaWithSql(int fakturaId);
        bool MarkOrderAsCompleted(int fakturaId);

    }
}


