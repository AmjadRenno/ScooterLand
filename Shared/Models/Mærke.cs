namespace BlazorAppClientServer.Shared.Models
{
	public class Mærke
	{
		public int MærkeId { get; set; }
		public string Navn {  get; set; }

        public int? MekanikerId { get; set; }
        public Mekaniker? Mekaniker { get; set; }
    }
}
