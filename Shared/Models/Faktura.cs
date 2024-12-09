namespace BlazorAppClientServer.Shared.Models
{
	public class Faktura
	{
		public int FakturaId {  get; set; }
		[Required(ErrorMessage = "Ordre-ID er påkrævet")]
		public int? OrdreId { get; set; }
		public Ordre? Ordre { get; set; }
	}
}
