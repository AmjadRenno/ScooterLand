namespace BlazorAppClientServer.Shared.Models
{
	public class Ordre
	{
		public int OrdreId { get; set; }
		public DateTime OdreDate { get; set; }
		public bool Status { get; set; }

		public int YdelseListeId { get; set; }
		public YdelseListe YdelseListe { get; set; }

		public int KundeId { get; set; }
		public Kunde Kunde { get; set; }

		public int MekanikerId { get; set; }
		public Mekaniker Mekaniker { get; set; }

        public ICollection<YdelseListe> YdelseListers { get; set; } = new List<YdelseListe>();

    }
}
