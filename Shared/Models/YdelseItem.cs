using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Shared.Models
{
	public class YdelseItem
	{
		public int YdelseId { get; set; }
		public Ydelse? Ydelse { get; set; }
		public int Quantity { get; set; }
	}
}
