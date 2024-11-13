using Microsoft.AspNetCore.Mvc;
using BlazorAppClientServer.Shared.Models;
using BlazorAppClientServer.Server.Repositories;
using System.Net;

namespace BlazorAppClientServer.Server.Controllers
{
	[ApiController]
	[Route("api/ydelseapi")]

	public class YdelseController : ControllerBase
	{
		private readonly IYdelseRepository Repository = new YdelseRepository();

		public YdelseController(IYdelseRepository ydelseRepository) 
		{ 
			if (Repository == null && ydelseRepository != null)
			{
				Repository = ydelseRepository;
				Console.WriteLine("Repository initialized");
			}
		}
		[HttpGet]
		public List<Ydelse> GetYdelses()
		{
			return Repository.GetYdelses();
		}

		[HttpGet("{id:int}")]
		public Ydelse GetYdelse(int id)
		{
			Ydelse result = Repository.GetYdelse(id);
			return result;
		}

		[HttpPost]
		public void AddYdelse(Ydelse ydelse)
		{
			Console.WriteLine("Add ydelse called: " + ydelse.ToString());
			Repository.AddYdelse(ydelse);
		}

		[HttpDelete("{id:int}")]
		public StatusCodeResult DeleteYdelse(int id)
		{
			Console.WriteLine("Server: Delete ydelse called: id = " + id);

			bool deleted = Repository.DeleteYdelse(id);
			if (deleted)
			{
				Console.WriteLine("Server: Ydelse deleted succces");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Ydelse deleted fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

		[HttpPut]
		public StatusCodeResult UpdateYdelse(Ydelse ydelse)
		{
			Console.WriteLine("Server: Update item called = " + ydelse.YdelseId);

			bool updated = Repository.UpdateYdelse(ydelse);
			if (updated)
			{
				Console.WriteLine("Server: Ydelse update success");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: Ydelse update fail - not found");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

	}
}
