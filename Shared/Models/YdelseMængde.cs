using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Shared.Models
{
	public class YdelseMængde
	{
		public int YdelseMængdeId {  get; set; }
		public int YdelseId { get; set; }
		public Ydelse? Ydelse { get; set; }
		public int Mængde { get; set; }
	}
}
