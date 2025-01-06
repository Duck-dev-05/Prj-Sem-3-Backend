using Microsoft.AspNetCore.Mvc;

namespace JamesThew.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        //In-Memory Data Store for Demo
        private static List<string> Recipes = new List<string>
        {
            "Spaghetti",
            "Chicken",
            "Vegetarian"
        };

        //Get: api/recipes
        [HttpGet]
        public IActionResult GetRecipe(int id)
        {
            if (id < 0 || id >= Recipes.Count)
                return NotFound("Recipe not found");
            return Ok(Recipes[id]);
        }

        //POST: api/recipes
        [HttpPost]
        public IActionResult AddRecipe([FromBody] string recipe)
        {
            if (string.IsNullOrWhiteSpace(recipe))
               return BadRequest("Recipe name cannot be empty");
            
            Recipes.Add(recipe);
            return CreatedAtAction(nameof(GetRecipe), new {id = Recipes.Count - 1}, recipe);
        }

        //Delete
        [HttpDelete("{id}")]
        public IActionResult DeleteRecipe(int id)
        {
            if (id < 0 || id >= Recipes.Count)
               return NotFound("Recipe not found");
            
            Recipes.RemoveAt(id);
            return NoContent();
        }
    }
}