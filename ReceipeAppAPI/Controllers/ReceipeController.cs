using Microsoft.AspNetCore.Mvc;
using ReceipeAppAPI.Models;

namespace ReceipeAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReceipeController : ControllerBase
    {
        private IRepository repository;
        public ReceipeController(IRepository rep)
        {
            repository = rep;
        }

        [HttpGet("{key}")]
        public ActionResult<Repository> Get(string key)
        {
            if (key == "")
            {
                return BadRequest("Value must be passed in the request body");
            }
            return Ok(repository.Receipe(key));
        }
    }
}
