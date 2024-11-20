using Microsoft.AspNetCore.Mvc;
using BlazorAppClientServer.Shared.Models;
using BlazorAppClientServer.Server.Repositories;
using System.Net;

namespace BlazorAppClientServer.Server.Controllers
{
	[ApiController]
	[Route("api/ordreapi")]

	public class OdreController : ControllerBase
	{
		private readonly IOrdreRepository Repository = new OrdreRepository();

		public OdreController(IOrdreRepository ordreRepository) 
		{ 
			if (Repository == null && ordreRepository != null)
			{
				Repository = ordreRepository;
				Console.WriteLine("Repository initialized");
			}
		}
		
		[HttpGet]
		public List<Ordre> GetAllOrdre()
		{
			return Repository.GetAllOrdre();
		}



		[HttpGet("{id:int}")]
		public Ordre GetOrdre(int id)
		{
			Ordre result = Repository.GetOrdre(id);
			return result;
		}

        [HttpGet("mekaniker/{id:int}")]
        public List<Ordre> GetOrdersByMechanic(int id)
        {
            return Repository.GetAllOrdre().Where(o => o.MekanikerId == id).ToList();
        }

		[HttpPost]
		public void AddOrdre(Ordre ordre)
		{
			Console.WriteLine("Add ordre called: " + ordre.ToString());
			Repository.AddOrdre(ordre);
		}

		[HttpDelete("{id:int}")]
		public StatusCodeResult DeleteOrdre(int id)
		{
			Console.WriteLine("Server: Delete ordre called: id = " + id);

			bool deleted = Repository.DeleteOrdre(id);
			if (deleted)
			{
				Console.WriteLine("Server: Ordre deleted succces");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Ordre deleted fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

		[HttpPut]
		public StatusCodeResult UpdateOrdre(Ordre ordre)
		{
			Console.WriteLine("Server: Update ordre called = " + ordre.OrdreId);

			bool updated = Repository.UpdateOrdre(ordre);
			if (updated)
			{
				Console.WriteLine("Server: Ordre update success");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Ordre update fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

	}

}

