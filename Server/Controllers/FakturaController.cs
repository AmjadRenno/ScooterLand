using BlazorAppClientServer.Server.Repositories;
using BlazorAppClientServer.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlazorAppClientServer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakturaController : ControllerBase
    {
        private readonly IFakturaRepository Repository;

        public FakturaController(IFakturaRepository fakturaRepository)
        {
            Repository = fakturaRepository ?? throw new ArgumentNullException(nameof(fakturaRepository));
            Console.WriteLine("Repository initialized");
        }

        [HttpGet]
        public IActionResult GetAllFakturaer()
        {
            return Ok(Repository.GetAllFakturaer());
        }

        [HttpGet("search/{searchId}/{isOrdreId}")]
        public IActionResult SearchFakturaByID(int searchId, bool isOrdreId)
        {
            var faktura = Repository.SearchFakturaByID(searchId, isOrdreId);
            if (faktura != null)
            {
                return Ok(faktura);
            }
            return NotFound();
        }
    

        [HttpPost]
        public IActionResult AddFaktura([FromBody] Faktura faktura)
        {
            if (faktura == null)
            {
                return BadRequest("Fakturadata er tomme.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ordreExists = Repository.GetAllFakturaer().Any(f => f.OrdreId == faktura.OrdreId);
            if (!ordreExists)
            {
                ModelState.AddModelError("OrdreId", "Ordre-id er ugyldigt.");
                return BadRequest(ModelState);
            }

            Repository.AddFaktura(faktura);
            return CreatedAtAction(nameof(SearchFakturaByID), new { id = faktura.FakturaId }, faktura);
        }


        [HttpDelete("delete-with-sql/{id}")]
        public IActionResult DeleteFakturaWithSql(int id)
        {
            if (Repository.DeleteFakturaWithSql(id))
            {
                return NoContent();
            }
            return NotFound("Faktura not found or could not be deleted.");
        }


        [HttpPost("mark-completed/{id}")]
        public IActionResult MarkOrderAsCompleted(int id)
        {
            if (Repository.MarkOrderAsCompleted(id))
            {
                return NoContent();
            }
            return NotFound();
        }

    }
}


