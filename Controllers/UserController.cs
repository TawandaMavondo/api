using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<User>> GetTModels()
        {
            return new List<User> { };
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetTModelById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public ActionResult<User> PostTModel(User model)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutTModel(int id, User model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<User> DeleteTModelById(int id)
        {
            return null;
        }
    }
}


