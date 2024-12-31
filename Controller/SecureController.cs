using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    //Public endpoint 
    [HttpGet("public")]
    public IActionResult PublicEndpoint()
    {
        return Ok("This is public endpoint accessible to everyone");
    }

    //Protected endpoint - required authencation
    [Authorize]
    [HttpGet("protected")]
    public IActionResult ProtectedEndpoint()
    {
        return Ok("This is a protected endpoint. You are authenticated");
    }

    //Role-based protected endpoint - requires Admin role
    [Authorize(Policy = "AdminOnly")]
    [HttpGet("admin")]
    public IActionResult AdminEndpoint()
    {
        return Ok("This is an Admin-only endpoint. You have the required role");
    }
}