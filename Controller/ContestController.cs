using Microsoft.AspNetCore.Mvc;
using JamesThew.Model;

namespace JamesThew.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContestController : ControllerBase
    {
        [HttpPost("create")]
        public IActionResult CreateContest(Contest contest)
        {
            // Logic for creating contest
            return Ok("Contest created");
        }

        [HttpPost("announce")]
        public IActionResult AnnounceWinner(int contestId, string winner)
        {
            // Logic for announcing winner
            return Ok("Winner announced");
        }
    }
}