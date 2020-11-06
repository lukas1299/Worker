using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Worker.Application.Queries;
using Worker.Infrastructure.Queries.Handlers;

namespace Worker.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        private readonly IAboutMeHandler _aboutMeHandler;

        public HomeController(IAboutMeHandler aboutMeHandler)
        {
            _aboutMeHandler = aboutMeHandler;
        }

        public async Task<ActionResult> GetDate() => Ok(DateTime.Now.ToString(CultureInfo.InvariantCulture));

        [HttpGet("about-me")]
        public async Task<ActionResult> GetAboutMe() => Ok(await _aboutMeHandler.QueryAsync(new AboutMe()));
    }
}