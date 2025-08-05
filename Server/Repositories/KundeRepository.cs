using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Repositories
{
	internal class KundeRepository : IKundeRepository
	{
		private readonly MyDBContext db;

		public KundeRepository(MyDBContext context)
		{
			db = context;
		}

		public List<Kunde> GetKunder()
		{
			return db.Kunder.Include(k => k.Mærke).ThenInclude(k => k.Mekaniker).ToList();
		}

		public Kunde GetKunde(int id)
		{
			Kunde foundKunde = db.Kunder.Single(i => i.KundeId == id);
			if (foundKunde != null)
			{
				return foundKunde;
			}
			else return null;
		}

		public void AddKunde(Kunde kunde)
		{
			db.Kunder.Add(kunde);
			db.SaveChanges();
		}

		public bool DeleteKunde(int id)
		{
			Kunde foundKunde = db.Kunder.Single(i => i.KundeId == id);
			if (foundKunde != null)
			{
				db.Kunder.Remove(foundKunde);
				db.SaveChanges();
				return true;
			}
			else return false;
		}


		public bool UpdateKunde(Kunde kunde)
		{
			Kunde foundKunde = db.Kunder.Single(i => i.KundeId == kunde.KundeId);
			if (foundKunde != null)
			{
				foundKunde.Navn = kunde.Navn;
				foundKunde.Adresse = kunde.Adresse;
				foundKunde.Adresse = kunde.Adresse;
				foundKunde.MekanikerId = kunde.MekanikerId;
				foundKunde.MærkeId = kunde.MærkeId;
				db.SaveChanges();
				return true;
			}
			else return false;
		}
	}
}
