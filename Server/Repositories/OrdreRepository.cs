using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
	internal class OrdreRepository : IOrdreRepository
	{
		MyDBContext db = new MyDBContext();

		public List<Ordre> GetAllOrdre()
		{
			return db.Ordrer.ToList();
		}

		public Ordre GetOrdre(int id)
		{
			Ordre foundOrdre = db.Ordrer.Single(i => i.OrdreId == id);
			if (foundOrdre != null)
			{
				return foundOrdre;
			}
			else return null;
		}

		public void AddOrdre(Ordre ordre)
		{
			db.Ordrer.Add(ordre);
			db.SaveChanges();
		}

		public bool DeleteOrdre(int id)
		{
			Ordre foundOrdre = db.Ordrer.Single(i => i.OrdreId == id);
			if (foundOrdre != null)
			{
				db.Ordrer.Remove(foundOrdre);
				db.SaveChanges();
				return true;
			}
			else return false;
		}


		public bool UpdateOrdre(Ordre ordre)
		{
			Ordre foundOrdre = db.Ordrer.Single(i => i.OrdreId == ordre.OrdreId);
			if (foundOrdre != null)
			{
				foundOrdre.OrdreDate = ordre.OrdreDate;
				foundOrdre.Status = ordre.Status;
				foundOrdre.YdelseListeId = ordre.YdelseListeId;
				foundOrdre.KundeId = ordre.KundeId;
				foundOrdre.MekanikerId = ordre.MekanikerId;
				db.SaveChanges();
				return true;
			}
			else return false;
		}
	}
}
