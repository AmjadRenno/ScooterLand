using Azure.Core.GeoJson;
using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Repositories
{
	internal class OrdreYdelseRepository : IOrdreYdelseRepository
	{
		MyDBContext db = new MyDBContext();

		static OrdreYdelseRepository()
		{

		}

		public List<OrdreYdelse> GetAllOrdreYdelse()
		{
			return db.OrdreYdelser.ToList();
		}

		public OrdreYdelse GetOrdreYdelse(int id)
		{
			OrdreYdelse foundOrdreYdelse = db.OrdreYdelser.Single(i => i.OrdrerYdelseId == id);
			if (foundOrdreYdelse != null)
			{
				return foundOrdreYdelse;
			}
			else return null;
		}

		public void AddOrdreYdelse(OrdreYdelse newOrdreYdelse) 
		{
			db.OrdreYdelser.Add(newOrdreYdelse);
			db.SaveChanges();
		}

		public bool DeleteOrdreYdelse(int id)
		{
			OrdreYdelse foundOrdreYdelse = db.OrdreYdelser.Single(i => i.OrdrerYdelseId == id);
			if (foundOrdreYdelse != null)
			{
				db.OrdreYdelser.Remove(foundOrdreYdelse);
				db.SaveChanges();
				return true;
			}
			else return false;
		}
	}
}
