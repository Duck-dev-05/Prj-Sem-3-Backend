using Microsoft.AspNetCore.Mvc;
using JamesThew.Model;

namespace JamesThew.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register (User user)
        {
            //Logic for register
            return Ok("User registered");
        }

        [HttpPost("login")]
        public IActionResult Login(string Email,string Password)
        {
            //Logic for login
            return Ok ("User logged in");
        }
    }
}