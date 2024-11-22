using Microsoft.AspNetCore.Mvc;
using BlazorAppClientServer.Shared.Models;
using BlazorAppClientServer.Server.Repositories;
using System.Net;

namespace BlazorAppClientServer.Server.Controllers
{
	[ApiController]
	[Route("api/mekanikerapi")]

	public class MekanikerController : ControllerBase
	{
		private readonly IMekanikerRepository Repository = new MekanikerRepository();

		public MekanikerController(IMekanikerRepository mekanikerRepository) 
		{ 
			if (Repository == null && mekanikerRepository != null)
			{
				Repository = mekanikerRepository;
				Console.WriteLine("Repository initialized");
			}
		}
		[HttpGet]
		public List<Mekaniker> GetAllMekaniker()
		{
			return Repository.GetAllMekaniker();
		}

		[HttpGet("{id:int}")]
		public Mekaniker GetMekaniker(int id)
		{
			Mekaniker result = Repository.GetMekaniker(id);
			return result;
		}

		[HttpPost]
		public void AddMekaniker(Mekaniker mekaniker)
		{
			Console.WriteLine("Add mekaniker called: " + mekaniker.ToString());
			Repository.AddMekaniker(mekaniker);
		}

		[HttpDelete("{id:int}")]
		public StatusCodeResult DeleteMekaniker(int id)
		{
			Console.WriteLine("Server: Delete mekaniker called: id = " + id);

			bool deleted = Repository.DeleteMekaniker(id);
			if (deleted)
			{
				Console.WriteLine("Server: Mekaniker deleted succces");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Mekaniker deleted fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

		[HttpPut]
		public StatusCodeResult UpdateMekaniker(Mekaniker mekaniker)
		{
			Console.WriteLine("Server: Update mekaniker called = " + mekaniker.Navn);

			bool updated = Repository.UpdateMekaniker(mekaniker);
			if (updated)
			{
				Console.WriteLine("Server: Mekaniker update success");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Mekaniker update fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

	}
}
