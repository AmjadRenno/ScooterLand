using Microsoft.AspNetCore.Mvc;
using BlazorAppClientServer.Shared.Models;
using BlazorAppClientServer.Server.Repositories;
using System.Net;

namespace BlazorAppClientServer.Server.Controllers
{
	[ApiController]
	[Route("api/kundeapi")]

	public class KundeController : ControllerBase
	{
		private readonly IKundeRepository Repository = new KundeRepository();

		public KundeController(IKundeRepository kundeRepository) 
		{ 
			if (Repository == null && kundeRepository != null)
			{
				Repository = kundeRepository;
				Console.WriteLine("Repository initialized");
			}
		}
		[HttpGet]
		public List<Kunde> GetKunder()
		{
			return Repository.GetKunder();
		}

		[HttpGet("{id:int}")]
		public Kunde GetKunde(int id)
		{
			Kunde result = Repository.GetKunde(id);
			return result;
		}

		[HttpPost]
		public void AddKunde(Kunde kunde)
		{
			Console.WriteLine("Add kunde called: " + kunde.ToString());
			Repository.AddKunde(kunde);
		}

		[HttpDelete("{id:int}")]
		public StatusCodeResult DeleteKunde(int id)
		{
			Console.WriteLine("Server: Delete kunde called: id = " + id);

			bool deleted = Repository.DeleteKunde(id);
			if (deleted)
			{
				Console.WriteLine("Server: Kunde deleted succces");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Kunde deleted fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

		[HttpPut]
		public StatusCodeResult UpdateKunde(Kunde kunde)
		{
			Console.WriteLine("Server: Update kunde called = " + kunde.Navn);

			bool updated = Repository.UpdateKunde(kunde);
			if (updated)
			{
				Console.WriteLine("Server: Kunde update success");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Kunde update fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

	}
}
