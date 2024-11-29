using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Repositories
{
    public class FakturaRepository : IFakturaRepository
    {
        private readonly MyDBContext db;

        public FakturaRepository(MyDBContext context)
        {
            db = context;
        }

        public List<Faktura> GetAllFakturaer()
        {
            return db.Fakturaer.Include(f => f.Ordre)
                                     .ThenInclude(o => o.Kunde)
                                     .Include(f => f.Ordre.Mekaniker)
                                     .Include(f => f.Ordre.YdelseTilOrdre)
                                     .ThenInclude(y => y.Ydelse)
                                     .ToList();
        }

        public Faktura? GetFaktura(int id)
        {
            return db.Fakturaer.Include(f => f.Ordre)
                                     .ThenInclude(o => o.Kunde)
                                     .Include(f => f.Ordre.Mekaniker)
                                     .Include(f => f.Ordre.YdelseTilOrdre)
                                     .ThenInclude(y => y.Ydelse)
                                     .FirstOrDefault(f => f.FakturaId == id);
        }

        public void AddFaktura(Faktura faktura)
        {
            db.Fakturaer.Add(faktura);
            db.SaveChanges();
        }

        public bool DeleteFaktura(int id)
        {
            var faktura = db.Fakturaer.Find(id);
            if (faktura != null)
            {
                db.Fakturaer.Remove(faktura);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateFaktura(Faktura faktura)
        {
            var existingFaktura = db.Fakturaer.Find(faktura.FakturaId);
            if (existingFaktura != null)
            {
                existingFaktura.OrdreId = faktura.OrdreId;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool MarkOrderAsCompleted(int fakturaId)
        {
            var faktura = db.Fakturaer.Include(f => f.Ordre).FirstOrDefault(f => f.FakturaId == fakturaId);
            if (faktura?.Ordre != null)
            {
                faktura.Ordre.Status = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
