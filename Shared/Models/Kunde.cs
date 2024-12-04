using System.ComponentModel.DataAnnotations;

namespace BlazorAppClientServer.Shared.Models
{
	public class Kunde
	{
		public int KundeId { get; set; }

		[Required(ErrorMessage = "Navnefeltet er påkrævet")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Navn skal være mellem 2 og 50 tegn")]
		public string Navn { get; set; }
		[Required(ErrorMessage = "Adressefeltet er påkrævet")]
		public string Adresse {  get; set; }
		[Required(ErrorMessage = "Telefonnummerfeltet er påkrævet")]
		[StringLength(8, MinimumLength = 8, ErrorMessage = "Ikke et gyldig telefon nummer")]
		public int TelefonNummer { get; set; }

		public int? MekanikerId { get; set; }
		public Mekaniker? Mekaniker { get; set; }

		public int? MærkeId { get; set; }
		public Mærke? Mærke {  get; set; } 
	}
}
