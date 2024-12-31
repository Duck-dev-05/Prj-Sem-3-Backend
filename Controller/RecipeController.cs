using Microsoft.AspNetCore.Mvc;
using JamesThew.Model;

namespace JamesThew.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult AddRecipe(Recipe recipe)
        {
            return Ok("Recipe added");
        }

        [HttpGet("list")]
        public IActionResult ListRecipes()
        {
            //Logic for listing recipes
            return Ok("Listing recipes");
        }
    }
}