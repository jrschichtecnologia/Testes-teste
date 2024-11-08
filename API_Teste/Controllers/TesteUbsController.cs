using Microsoft.AspNetCore.Mvc;

namespace API_Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteUbsController : ControllerBase
    {
        // GET: api/<TesteUbsController>
        [HttpGet("Teste")]
        public ActionResult<string> Get(string portifolio)
        {
            try
            {
                var lst = new BLL.Regras().Executar(portifolio);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<TesteUbsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TesteUbsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TesteUbsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TesteUbsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
