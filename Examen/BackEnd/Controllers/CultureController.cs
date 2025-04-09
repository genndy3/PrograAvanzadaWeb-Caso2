using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CultureController : ControllerBase
    {

        ICultureService _cultureService;
        public CultureController(ICultureService cultureService)
        {
            _cultureService = cultureService;
        }

        // GET: api/<CultureController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_cultureService.GetAll());
        }

        // GET api/<CultureController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return Ok(_cultureService.Get(id));
        }

        // POST api/<CultureController>
        [HttpPost]
        public void Post([FromBody] CultureDTO culture)
        {
            _cultureService.Add(culture);
        }

        // PUT api/<CultureController>/5
        [HttpPut]
        public void Put([FromBody] CultureDTO culture)
        {
            _cultureService.Update(culture);
        }

        // DELETE api/<CultureController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cultureService.Delete(id);
        }
    }
}
