using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
	internal class YdelseRepository : IYdelseRepository
	{
		MyDBContext db = new MyDBContext();

		public List<Ydelse> GetYdelses()
		{
			return db.Ydelser.ToList();
		}

		public Ydelse GetYdelse(int id)
		{
			Ydelse foundYdelse = db.Ydelser.Single(i => i.YdelseId == id);
			if (foundYdelse != null)
			{
				return foundYdelse;
			}
			else return null;
		}

		public void AddYdelse(Ydelse ydelse)
		{
			db.Ydelser.Add(ydelse);
			db.SaveChanges();
		}

		public bool DeleteYdelse(int id)
		{
			Ydelse foundYdelse = db.Ydelser.Single(i => i.YdelseId == id);
			if (foundYdelse != null)
			{
				db.Ydelser.Remove(foundYdelse);
				db.SaveChanges();
				return true;
			}
			else return false;
		}


		public bool UpdateYdelse(Ydelse ydelse)
		{
			Ydelse foundYdelse = db.Ydelser.Single(i => i.YdelseId == ydelse.YdelseId);
			if (foundYdelse != null)
			{
				foundYdelse.Navn = ydelse.Navn;
				foundYdelse.Pris = ydelse.Pris;
				foundYdelse.Art = ydelse.Art;
				foundYdelse.Timer = ydelse.Timer;
				foundYdelse.YdelseListId = ydelse.YdelseListId;
				db.SaveChanges();
				return true;
			}
			else return false;
		}
	}
}
