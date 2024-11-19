namespace BlazorAppClientServer.Shared.Models
{
	public class Ordre
	{
		public int OrdreId { get; set; }
		public DateTime OrdreDate { get; set; }
		public bool Status { get; set; }

		public int? YdelseListeId { get; set; }
		public YdelseListe? YdelseListe { get; set; }

		public int? KundeId { get; set; }
		public Kunde? Kunde { get; set; }

		public int? MekanikerId { get; set; }
		public Mekaniker? Mekaniker { get; set; }

		public override string ToString()
		{
			return $"Id: {OrdreId}. OrdreDate: {OrdreDate}. Status: {Status}";
		}

	}
}
