using Microsoft.AspNetCore.Mvc;
using PFMBackend.Models;

namespace PFMBackend.Controllers
{
    [ApiController]
    [Route("/transactions")]
    public class Transactions
    {
        [HttpGet]
        public async Task<IActionResult> getTransactions()
        {
            return Ok("Test uspesni transakcii");
        }

        [HttpPost("import")]
        //[Consumes("application/csv")]
        public async Task<IActionResult> import(Transaction transactions)
        {

            return Ok(transactions.ToString());
        }

        private IActionResult Ok(string? v)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{id}/split")]
        public async Task<IActionResult> split([FromRoute] string id)
        {
            return Ok(id + " split");
        }

        [HttpPost("{id}/categorize")]
        public async Task<IActionResult> categorize([FromRoute] string id)
        {
            return Ok(id + " categories");
        }

        [HttpPost("auto-categorize")]
        public async Task<IActionResult> auto_categorize()
        {
            return Ok("auto-categories");
        }
    }
}
