using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppClientServer.Shared.Models
{
	public class Ydelse
	{
		public int YdelseId { get; set; }
		[Required (ErrorMessage = "Navnefeltet er påkrævet")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Navnet skal være mellem 3 og 50 tegn")]
		public string Navn { get; set; }
		[Required (ErrorMessage = "Prisfeltet er påkrævet")]
		[Range(0, int.MaxValue, ErrorMessage = "Prisen skal være et positivt nummer")]
		public double Pris {  get; set; }
		[Required (ErrorMessage = "Artfeltet er påkrævet")]
		[StringLength(50)]
		public string Art {  get; set; }
		public double? Timer { get; set; }
		public override string ToString()
		{
			return $"{Navn}";
		}


	}
}
