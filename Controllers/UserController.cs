using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [Route("api/[user]")]
    [ApiController]
    public class UserController : AbstractController<User>
    {
       

        // public UserController(ILogger<AbstractController<User>> logger) : base(logger)
        // {
        // }
    }
}


