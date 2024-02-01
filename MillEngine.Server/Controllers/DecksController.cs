using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MillEngine.Shared.Models.DTOs;

namespace MillEngine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecksController : ControllerBase
    {
        private readonly LibraryDbContext _context;
        
        public DecksController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeckEntry>>> GetDecks()
        {
            return await _context.LibraryDecks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeckEntry>> GetDeck(int id)
        {
            var deck = await _context.LibraryDecks.FindAsync(id);

            if (deck == null)
                return NotFound();

            return deck;
        }

        [HttpPost]
        public async Task<ActionResult<DeckEntry>> CreateDeck(DeckEntry deck)
        {
            _context.LibraryDecks.Add(deck);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDeck), new {id = deck.Id}, deck);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DeckEntry>> DeleteDeck(int id)
        {
            var deck = await _context.LibraryDecks.FindAsync(id);
            if (deck == null) return NotFound();

            _context.LibraryDecks.Remove(deck);
            await _context.SaveChangesAsync();

            return deck;
        }
        
    }
}
