using BlazorAppClientServer.Shared.Models;
using BlazorAppClientServer.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace BlazorAppClientServer.Server.Controllers
{
    [ApiController]
    [Route("api/maerkeapi")]
    public class MærkeController : ControllerBase
    {

        private readonly IMærkeRepository Repository = new MærkeRepository();

        public MærkeController(IMærkeRepository mærkeRepository)
        {
            if (Repository == null && mærkeRepository != null)
            {
                Repository = mærkeRepository;
                Console.WriteLine("Repository initialized");
            }
        }

        [HttpGet]
        public List<Mærke> GetAllMærker()
        {
            return Repository.GetAllMærker();
        }

        [HttpGet("{id:int}")]
        public Mærke GetMærkeById(int id)
        {
            Mærke result = Repository.GetMærke(id);
            return result;
        }

        [HttpPost]
        public void AddMærke(Mærke mærke)
        {
            Console.WriteLine("Add mærke called: " + mærke.ToString());
            Repository.AddMærke(mærke);
        }

        [HttpPut]
        public StatusCodeResult UpdateMærke(Mærke mærke)
        {
            Console.WriteLine("Server: Update mekaniker called = " + mærke.Navn);

            bool updated = Repository.UpdateMærke(mærke);
            if (updated)
            {
                Console.WriteLine("Server: Mærke update success");
                int code = (int)HttpStatusCode.OK;
                return new StatusCodeResult(code);
            }
            else
            {
                Console.WriteLine("Server: Mærke update fail - not found");
                int code = (int)HttpStatusCode.NotFound;
                return new StatusCodeResult(code);
            }
        }

        [HttpDelete("{id}")]
        public StatusCodeResult DeleteMærke(int id)
        {
            Console.WriteLine("Server: Delete mærke called: id = " + id);

            bool deleted = Repository.DeleteMærke(id);
            if (deleted)
            {
                Console.WriteLine("Server: Mærke deleted succces");
                int code = (int)HttpStatusCode.OK;
                return new StatusCodeResult(code);
            }
            else
            {
                Console.WriteLine("Server: Mærke deleted fail - not found");
                int code = (int)HttpStatusCode.NotFound;
                return new StatusCodeResult(code);
            }
        }
    }
}
