namespace BlazorAppClientServer.Shared.Models
{
	public class Faktura
	{
		public int FakturaId {  get; set; }

		public int? OrdreId { get; set; }
		public Ordre? Ordre { get; set; }
	}
}
