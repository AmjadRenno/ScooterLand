using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Models
{
	public class MyDBContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(local);DataBase=ScooterlandDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Ydelse> Ydelser { get; set; }
		public DbSet<Ordre> Ordrer { get; set; }
		public DbSet<YdelseTilOrdre> YdelseTilOrdrer {  get; set; }
		public DbSet<Faktura> Fakturaer { get; set; }
		public DbSet<Kunde> Kunder { get; set; }
		public DbSet<Mærke> Mærker { get; set; }
		public DbSet<Mekaniker> Mekanikers { get; set; }
		public DbSet<Værkfører> Værkførers { get; set; }
		public DbSet<KontorDame> KontorDamer { get; set; }
	}
}
