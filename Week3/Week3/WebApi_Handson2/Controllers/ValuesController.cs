using Microsoft.AspNetCore.Mvc;

namespace WebApi_Handson2.Controllers
{
    [ApiController]
    [Route("api/Emp")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Value1", "Value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Value : {id}";
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return $"Received : {value}";
        }

        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            return $"Updated {id} with {value}";
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return $"Deleted {id}";
        }
    }
}