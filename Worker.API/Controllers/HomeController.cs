using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Worker.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        public async Task<ActionResult> GetDate() => Ok(DateTime.Now.ToString());
    }
}