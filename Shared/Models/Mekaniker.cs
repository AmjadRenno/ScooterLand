using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppClientServer.Shared.Models
{
	public class Mekaniker
	{
		public int MekanikerId { get; set; }
		public required string Navn { get; set; }
		[Required(ErrorMessage = "Email er påkrævet")]
		[EmailAddress(ErrorMessage = "Ikke en gyldig Email adresse")]
		public required string Email { get; set; }
		[Required(ErrorMessage = "Password er påkrævet")]
		[DataType(DataType.Password)]
		public required string Password { get; set; }

		public List<Ordre> OrdreListe { get; set; } = new List<Ordre>();

		public List<Mærke> MærkeListe { get; set; } = new List<Mærke>();

	}
}
