using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
     class AbstractController<T> : ControllerBase
    {
        public readonly ILogger _logger;


        // public AbstractController(ILogger logger)
        // {
        //    _logger = logger;
        // }

        [HttpGet("")]
        public ActionResult<IEnumerable<T>> GetTModels()
        {
            return new List<T> { };
        }

        [HttpGet("{id}")]
        public ActionResult<T> GetTModelById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public ActionResult<T> PostTModel(User model)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutTModel(int id, T model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<T> DeleteTModelById(int id)
        {
            return null;
        }
    }
}