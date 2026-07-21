using Microsoft.AspNetCore.Mvc;

namespace WebApi_Handson1.Controllers
{
    [Route("api/Emp")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Value1", "Value2" };
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Value : " + id;
        }

        // POST: api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return "Received : " + value;
        }

        // PUT: api/values/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            return $"Updated Id {id} with {value}";
        }

        // DELETE: api/values/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return $"Deleted Id {id}";
        }
    }
}