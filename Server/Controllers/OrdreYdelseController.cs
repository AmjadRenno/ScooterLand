using Microsoft.AspNetCore.Mvc;
using BlazorAppClientServer.Shared.Models;
using BlazorAppClientServer.Server.Repositories;
using System.Net;

namespace BlazorAppClientServer.Server.Controllers
{
	[ApiController]
	[Route("api/ordreydelseapi")]


	public class OdreYdelseController : ControllerBase
	{
		private readonly IOrdreYdelseRepository Repository = new OrdreYdelseRepository();

		public OdreYdelseController(IOrdreYdelseRepository ordreYdelseRepository)
		{
			if (Repository == null && ordreYdelseRepository != null)
			{
				Repository = ordreYdelseRepository;
				Console.WriteLine("Repository initialized");
			}
		}

		[HttpGet]
		public List<OrdreYdelse> GetAllOrdreYdelse()
		{
			return Repository.GetAllOrdreYdelse();
		}



		[HttpGet("{id:int}")]
		public OrdreYdelse GetOrdreYdelse(int id)
		{
			OrdreYdelse result = Repository.GetOrdreYdelse(id);
			return result;
		}

		[HttpPost]
		public async Task<IActionResult> AddOrdreYdelse([FromBody] OrdreYdelse ordreYdelse)
		{
			Console.WriteLine("Add ordre called: " + ordreYdelse.ToString());

			Repository.AddOrdreYdelse(ordreYdelse);
			return Ok(ordreYdelse);
		}

		[HttpDelete("{id:int}")]
		public StatusCodeResult DeleteOrdreYdelse(int id)
		{
			bool deleted = Repository.DeleteOrdreYdelse(id);
			if (deleted)
			{
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

	}

}

