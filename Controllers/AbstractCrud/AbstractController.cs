using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    abstract class AbstractController : ControllerBase
    {
        private readonly ILogger<AbstractController> _logger;


        public AbstractController(ILogger<AbstractController> logger)
        {
           this._logger = logger;

        }
    }
}