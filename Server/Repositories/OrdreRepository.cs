using Azure.Core.GeoJson;
using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Repositories
{
	internal class OrdreRepository : IOrdreRepository
	{
		MyDBContext db = new MyDBContext();

		static OrdreRepository()
		{

		}

		public List<Ordre> GetAllOrdre()
		{
			return db.Ordrer.Include(o => o.YdelseTilOrdre).ThenInclude(y => y.Ydelse).ToList();
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

		public async void AddOrdre(Ordre newOrdre)
		{
			//var ydelser = await db.Ydelser.ToListAsync();

			//ydelser.ForEach(y =>
			//{
			//	if (newOrdre.OrdreYdelser.Any(o => o.YdelseOrdrerId == y.YdelseId))
			//	{
			//		var untracked = newOrdre.OrdreYdelser.First(o => o.YdelseOrdrerId == y.YdelseId);
			//		newOrdre.OrdreYdelser.Remove(untracked);
			//		newOrdre.OrdreYdelser.Add();
			//	}
			//});
			db.Ordrer.Add(newOrdre);
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
				foundOrdre.KundeId = ordre.KundeId;
				foundOrdre.MekanikerId = ordre.MekanikerId;
				db.SaveChanges();
				return true;
			}
			else return false;
		}
	}
}
