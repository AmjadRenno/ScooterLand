using Azure.Core.GeoJson;
using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

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

		public async void AddOrdre(Ordre ordre) // ???? :(
		{
			var ydelser = await db.Ydelser.ToListAsync();

			foreach (var ydelse in ydelser)
			{
				if(ordre.YdelseListe.Any(o => o.YdelseId == ydelse.YdelseId))
				{
					var untracked = ordre.YdelseListe.First(o => o.YdelseId == ydelse.YdelseId);
					ordre.YdelseListe.Remove(untracked);
					ordre.YdelseListe.Add(ydelse);
				}
			}
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
				foundOrdre.KundeId = ordre.KundeId;
				foundOrdre.MekanikerId = ordre.MekanikerId;
				foundOrdre.YdelseListe = ordre.YdelseListe;
				db.SaveChanges();
				return true;
			}
			else return false;
		}
	}
}
