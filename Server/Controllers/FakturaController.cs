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
        public ActionResult<List<Faktura>> GetFakturaer()
        {
            return _repository.GetAllFakturaer();
        }

        [HttpGet("{id}")]
        public ActionResult<Faktura> GetFaktura(int id)
        {
            var faktura = _repository.GetFaktura(id);
            if (faktura == null)
            {
                return NotFound();
            }
            return faktura;
        }

        [HttpPost]
        public ActionResult AddFaktura(Faktura faktura)
        {
            _repository.AddFaktura(faktura);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateFaktura(Faktura faktura)
        {
            if (_repository.UpdateFaktura(faktura))
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteFaktura(int id)
        {
            if (_repository.DeleteFaktura(id))
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
