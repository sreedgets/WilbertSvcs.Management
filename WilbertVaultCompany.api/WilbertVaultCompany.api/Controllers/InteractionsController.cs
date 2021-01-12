using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WilbertVaultCompany.api.Models;

namespace WilbertVaultCompany.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteractionsController : ControllerBase
    {
        private readonly wilbertdbContext _context;

        public InteractionsController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: api/Interactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interaction>>> GetInteractions()
        {
            return await _context.Interactions.ToListAsync();
        }

        // GET: api/Interactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interaction>> GetInteraction(int id)
        {
            var interaction = await _context.Interactions.FindAsync(id);

            if (interaction == null)
            {
                return NotFound();
            }

            return interaction;
        }

        // PUT: api/Interactions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInteraction(int id, Interaction interaction)
        {
            if (id != interaction.InteractionId)
            {
                return BadRequest();
            }

            _context.Entry(interaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InteractionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Interactions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Interaction>> PostInteraction(Interaction interaction)
        {
            _context.Interactions.Add(interaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInteraction", new { id = interaction.InteractionId }, interaction);
        }

        // DELETE: api/Interactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInteraction(int id)
        {
            var interaction = await _context.Interactions.FindAsync(id);
            if (interaction == null)
            {
                return NotFound();
            }

            _context.Interactions.Remove(interaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InteractionExists(int id)
        {
            return _context.Interactions.Any(e => e.InteractionId == id);
        }
    }
}
