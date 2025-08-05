using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlazorAppClientServer.Server.Repositories
{
    internal class FakturaRepository : IFakturaRepository
    {
        private readonly MyDBContext db;

        public FakturaRepository(MyDBContext context)
        {
            db = context;
        }

        public List<Faktura> GetAllFakturaer()
        {
            return db.Fakturaer
                     .Include(f => f.Ordre)
                         .ThenInclude(o => o.Kunde)
                     .Include(f => f.Ordre)
                         .ThenInclude(o => o.Mekaniker)
                     .Include(f => f.Ordre)
                         .ThenInclude(o => o.YdelseTilOrdre)
                             .ThenInclude(y => y.Ydelse)
                     .ToList();
        }

        public Faktura? SearchFakturaByID(int searchId, bool isOrdreId)
        {
            IQueryable<Faktura> query = db.Fakturaer
                .Include(f => f.Ordre)
                    .ThenInclude(o => o.Kunde)
                .Include(f => f.Ordre)
                    .ThenInclude(o => o.Mekaniker)
                .Include(f => f.Ordre)
                    .ThenInclude(o => o.YdelseTilOrdre)
                        .ThenInclude(y => y.Ydelse);

            if (isOrdreId)
            {
                return query.FirstOrDefault(f => f.OrdreId == searchId);
            }
            else
            {
                return query.FirstOrDefault(f => f.FakturaId == searchId);
            }
        }

        public void AddFaktura(Faktura faktura)
        {
            db.Fakturaer.Add(faktura);
            db.SaveChanges();
        }


        public bool DeleteFakturaWithSql(int fakturaId)
        {
            string connectionString = db.Database.GetDbConnection().ConnectionString;
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Fakturaer WHERE FakturaId = @FakturaId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FakturaId", fakturaId);

                        int rowsAffected = command.ExecuteNonQuery();
                        isDeleted = rowsAffected > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return isDeleted;
        }


        public bool MarkOrderAsCompleted(int fakturaId)
        {
            var faktura = db.Fakturaer
                            .Include(f => f.Ordre)
                            .FirstOrDefault(f => f.FakturaId == fakturaId);
            if (faktura?.Ordre != null && !faktura.Ordre.Status)
            {
                faktura.Ordre.Status = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

       
    }
}


