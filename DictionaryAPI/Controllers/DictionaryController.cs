using Microsoft.AspNetCore.Mvc;
using DictionaryAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DictionaryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryController : ControllerBase
    {
        private readonly DictionaryContext _context;

        public DictionaryController(DictionaryContext context)
        {
            _context = context;
        }

        // GET api/dictionary/translate?word=hello
        [HttpGet("translate")]
        public async Task<IActionResult> Translate([FromQuery] string word)
        {
            var entry = await _context.Dictionary
                .FirstOrDefaultAsync(e => e.English_Word == word);  // Updated to use PascalCase

            if (entry != null)
            {
                return Ok(entry.Hungarian_Translation);  // Updated to use PascalCase
            }
            else
            {
                return NotFound("Translation not found.");
            }
        }
    }
}
