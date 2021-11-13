using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pluralsight.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        private readonly ILogger<NamesController> _logger;

        public NamesController(ILogger<NamesController> logger)
        {
            _logger = logger;
        }
        // GET: api/<NamesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { Environment.MachineName };
        }

        // GET api/<NamesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NamesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NamesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
