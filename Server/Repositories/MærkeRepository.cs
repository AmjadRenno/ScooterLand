using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAppClientServer.Server.Repositories
{
    internal class MærkeRepository : IMærkeRepository
    {
        MyDBContext db = new MyDBContext();

        public List<Mærke> GetAllMærker()
        {
            return db.Mærker.ToList();
        }

        public Mærke GetMærkeById(int id)
        {
            Mærke foundMærke = db.Mærker.Single(m => m.MærkeId == id);
            if (foundMærke != null)
            {
                return foundMærke;
            }
            else return null;
        }

        public bool AddMærke(Mærke mærke)
        {
            try
            {
                db.Mærker.Add(mærke);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateMærke(Mærke mærke)
        {
            try
            {
                var existingMærke = db.Mærker.Single(m => m.MærkeId == mærke.MærkeId);
                if (existingMærke != null)
                {
                    existingMærke.Navn = mærke.Navn;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMærke(int id)
        {
            try
            {
                var mærke = db.Mærker.Single(m => m.MærkeId == id);
                if (mærke != null)
                {
                    db.Mærker.Remove(mærke);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
