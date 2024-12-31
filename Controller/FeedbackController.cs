using Microsoft.AspNetCore.Mvc;
using JamesThew.Model;

namespace JamesThew.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        [HttpPost("sumbit")]
        public IActionResult SumbitFeedback (Feedback feedback)
        {
            //Logic for sumbitting feedback
            return Ok("Feedback sumbitted");
        }
    }
}