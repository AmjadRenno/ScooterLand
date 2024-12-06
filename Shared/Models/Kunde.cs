namespace BlazorAppClientServer.Shared.Models
{
	public class Kunde
	{
        public int KundeId { get; set; }
		public string Navn { get; set; }
		public string Adresse {  get; set; }
		public int TelefonNummer { get; set; }

		public int? MekanikerId { get; set; }
		public Mekaniker? Mekaniker { get; set; }

		public int? MærkeId { get; set; }
		public Mærke? Mærke {  get; set; } 
	}
}
