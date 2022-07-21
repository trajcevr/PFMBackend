using Microsoft.AspNetCore.Mvc;

namespace PFMBackend.Controllers
{
    [ApiController]
    [Route("/categories")]
    public class Categories
    {
        [HttpGet]
        public async Task<IActionResult> getCategories()
        {
            return Ok("Test uspesnii transakcii");
        }

        private IActionResult Ok(string v)
        {
            throw new NotImplementedException();
        }

        [HttpPost("import")]
        public async Task<IActionResult> import([FromBody] IFormFile file)
        {
            return Ok("Test import categories");
        }
    }
}
