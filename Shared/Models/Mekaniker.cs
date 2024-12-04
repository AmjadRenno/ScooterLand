using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppClientServer.Shared.Models
{
	public class Mekaniker
	{
		public int MekanikerId { get; set; }
		public required string Navn { get; set; }
		public required string Email { get; set; }
		public required string Password { get; set; }

		public List<Ordre> OrdreListe { get; set; } = new List<Ordre>();

		public List<Mærke> MærkeListe { get; set; } = new List<Mærke>();

	}
}
