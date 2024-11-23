using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Shared.Models
{
	public class OrdreYdelse
	{
		public int OrdrerYdelseId { get; set; }
		public Ordre? Ordre {get ; set; }

		public int YdelseOrdrerId {  get; set; }
		public Ydelse? Ydelse {get; set; }

		public int Mængde { get; set; }
	}
}
