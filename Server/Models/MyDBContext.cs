using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppClientServer.Server.Models
{
	public class MyDBContext : DbContext
	{
		private readonly IConfiguration _configuration;

		public MyDBContext(DbContextOptions<MyDBContext> options, IConfiguration configuration) : base(options)
		{
			_configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Ydelse> Ydelser { get; set; }
		public DbSet<Ordre> Ordrer { get; set; }
		public DbSet<YdelseTilOrdre> YdelseMængder {  get; set; }
		public DbSet<Faktura> Fakturaer { get; set; }
		public DbSet<Kunde> Kunder { get; set; }
		public DbSet<Mærke> Mærker { get; set; }
		public DbSet<Mekaniker> Mekanikers { get; set; }
		public DbSet<Værkfører> Værkførers { get; set; }
		public DbSet<KontorDame> KontorDamer { get; set; }
	}
}
