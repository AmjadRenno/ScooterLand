using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppClientServer.Shared.Models
{
	public class LejetScooter
	{
		public int YdelseId { get; set; } = 13;
		public double LejePris { get; set; }
		public int DageLejet { get; set; }
		public double Forskikring { get; set; }
		public double KørtKilometer { get; set; }
		public bool Skadet { get; set; }

		public double GetLejeScooterTotalPris()
		{
			if (Skadet)
			{
				totalPris = (LejePris * DageLejet) + Forskikring + (KørtKilometer * kmPris) + selvRisiko;
			}
			else
			{
				totalPris = (LejePris * DageLejet) + Forskikring + (KørtKilometer * kmPris);
			}
			return totalPris;
		}

		double totalPris;
		double kmPris = 0.53;
		double selvRisiko = 1000;
		
	}
}
