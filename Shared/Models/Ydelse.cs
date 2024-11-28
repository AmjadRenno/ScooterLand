using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppClientServer.Shared.Models
{
	public class Ydelse
	{
		public int YdelseId { get; set; }
		public string Navn { get; set; }
		public double Pris {  get; set; }
		public string Art {  get; set; }
		public double? Timer { get; set; }
		public override string ToString()
		{
			return $"{Navn}";
		}


	}
}
