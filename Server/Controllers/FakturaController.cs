using BlazorAppClientServer.Server.Repositories;
using BlazorAppClientServer.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppClientServer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakturaController : ControllerBase
    {
        private readonly IFakturaRepository _repository;

        public FakturaController(IFakturaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllFakturaer()
        {
            return Ok(_repository.GetAllFakturaer());
        }

        [HttpGet("{id}")]
        public IActionResult GetFaktura(int id)
        {
            var faktura = _repository.GetFaktura(id);
            if (faktura != null)
            {
                return Ok(faktura);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddFaktura([FromBody] Faktura faktura)
        {
            _repository.AddFaktura(faktura);
            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFaktura(int id)
        {
            if (_repository.DeleteFaktura(id))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFaktura(int id, [FromBody] Faktura faktura)
        {
            if (_repository.UpdateFaktura(faktura))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpPost("mark-completed/{id}")]
        public IActionResult MarkOrderAsCompleted(int id)
        {
            if (_repository.MarkOrderAsCompleted(id))
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
