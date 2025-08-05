using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Server.Repositories
{
	internal class MekanikerRepository : IMekanikerRepository
	{
		private readonly MyDBContext db;

		public MekanikerRepository(MyDBContext context)
		{
			db = context;
		}

		public List<Mekaniker> GetAllMekaniker()
		{
			return db.Mekanikers.ToList();
		}

		public Mekaniker GetMekaniker(int id)
		{
			Mekaniker foundMekaniker = db.Mekanikers.Single(i => i.MekanikerId == id);
			if (foundMekaniker != null)
			{
				return foundMekaniker;
			}
			else return null;
		}

		public void AddMekaniker(Mekaniker mekaniker)
		{
			try
			{
				Console.WriteLine("Repository: Adding mekaniker - " + mekaniker.Navn + ", " + mekaniker.Email);
				db.Mekanikers.Add(mekaniker);
				int result = db.SaveChanges();
				Console.WriteLine("Repository: SaveChanges result - " + result + " rows affected");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Repository Error: " + ex.Message);
				if (ex.InnerException != null)
				{
					Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
				}
				throw;
			}
		}

		public bool DeleteMekaniker(int id)
		{
			Mekaniker foundMekaniker = db.Mekanikers.Single(i => i.MekanikerId == id);
			if (foundMekaniker != null)
			{
				db.Mekanikers.Remove(foundMekaniker);
				db.SaveChanges();
				return true;
			}
			else return false;
		}


		public bool UpdateMekaniker(Mekaniker mekaniker)
		{
			Mekaniker foundMekaniker = db.Mekanikers.Single(i => i.MekanikerId == mekaniker.MekanikerId);
			if (foundMekaniker != null)
			{
				foundMekaniker.Email = mekaniker.Email;
				foundMekaniker.Navn = mekaniker.Navn;
				db.SaveChanges();
				return true;
			}
			else return false;
		}
	}
}
