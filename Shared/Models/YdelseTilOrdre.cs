namespace BlazorAppClientServer.Shared.Models
{
	public class YdelseTilOrdre
	{
		public int YdelseTilOrdreId { get; set; }
		public int YdelseId { get; set; }
		public Ydelse? Ydelse { get; set; }
		public int Mængde { get; set; }
		public double AktuelPris { get; set; }
		public double TotalPris {  
			get => pris;
			set { pris = AktuelPris * Mængde;}
			}
		double pris;
		
		public double? GetTimer() 
		{
			return Ydelse?.Timer;
		}
	}
}
