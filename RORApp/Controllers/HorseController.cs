using RORApp.Model;
using RORApp.Orchestrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;


namespace RORApp.Controllers

{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HorseController : ApiController
    {
        private  IHorseOrchestrator _horseOrchestrator;


        public HorseController(IHorseOrchestrator horseOrchestrator)
        {
            _horseOrchestrator = horseOrchestrator;
        }



        [Route("horses/connection")]
        [HttpGet]
        public  IHttpActionResult GetConnection()
        {
            var result = _horseOrchestrator.getConnection();
            //var result = await _horseOrchestrator.getConnection();
            //return Ok(result);

            return Ok(result);
        }

        [Route("horses/{hName}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetHorse(string hName)
        {

            var result = await _horseOrchestrator.GetHorses(hName);
            return Ok(result);

            //var product = products.FirstOrDefault((p) => p.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            //return Ok();
        }



        [Route("horses/isAvailable/{hName}")]
        [HttpGet]
        public async Task<HorseStatus> GetHorseStatus(string hName)
        {

            var result = await _horseOrchestrator.GetHorseStatus(hName);
            return result;// Ok(result);

            //var product = products.FirstOrDefault((p) => p.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            //return Ok();
        }
    }
}
