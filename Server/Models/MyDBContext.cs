using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Models
{
	public class MyDBContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(local);DataBase=ScooterlandDB2;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.Entity<OrdreYdelse>()
			//	.HasKey(oy => new { oy.OrdrerYdelseId, oy.YdelseOrdrerId });

			//modelBuilder.Entity<OrdreYdelse>()
			//	.HasOne(oy => oy.Ordre)
			//	.WithMany(oy => oy.OrdreYdelser)
			//	.HasForeignKey(oy => oy.OrdrerYdelseId);

			//modelBuilder.Entity<OrdreYdelse>()
			//	.HasOne(oy => oy.Ydelse)
			//	.WithMany(oy => oy.OrdreYdelser)
			//	.HasForeignKey(oy => oy.YdelseOrdrerId);
		}

		public DbSet<Ydelse> Ydelser { get; set; }
		public DbSet<Ordre> Ordrer { get; set; }
		//public DbSet<OrdreYdelse> OrdreYdelser { get; set; }
		public DbSet<YdelseItem> YdelseItems {  get; set; }
		public DbSet<Faktura> Fakturaer { get; set; }
		public DbSet<Kunde> Kunder { get; set; }
		public DbSet<Mærke> Mærker { get; set; }
		public DbSet<Mekaniker> Mekanikers { get; set; }
		public DbSet<Værkfører> Værkførers { get; set; }
		public DbSet<KontorDame> KontorDamer { get; set; }
	}
}
