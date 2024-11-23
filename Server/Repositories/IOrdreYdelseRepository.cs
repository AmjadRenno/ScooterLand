using BlazorAppClientServer.Server.Models;
using BlazorAppClientServer.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace BlazorAppClientServer.Server.Repositories
{
	public interface IOrdreYdelseRepository
	{
		List<OrdreYdelse> GetAllOrdreYdelse();
		OrdreYdelse GetOrdreYdelse(int id);
		void AddOrdreYdelse(OrdreYdelse ordreYdelse);
		bool DeleteOrdreYdelse(int id);
	}
}
