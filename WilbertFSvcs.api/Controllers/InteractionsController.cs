using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WilbertFSvcs.Models.Misc;
using WilbertFSvcs.api.Data;

namespace WilbertFSvcs.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteractionsController : ControllerBase
    {
        private readonly WilbertDbContext _context;

        public InteractionsController(WilbertDbContext context)
        {
            _context = context;
        }

        // GET: api/Interactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interaction>>> GetInteraction()
        {
            return await _context.Interaction.ToListAsync();
        }

        // GET: api/Interactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interaction>> GetInteraction(int id)
        {
            var interaction = await _context.Interaction.FindAsync(id);

            if (interaction == null)
            {
                return NotFound();
            }

            return interaction;
        }

        // PUT: api/Interactions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Interaction>> PostInteraction(Interaction interaction)
        {
            _context.Interaction.Add(interaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInteraction", new { id = interaction.InteractionId }, interaction);
        }

        // DELETE: api/Interactions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Interaction>> DeleteInteraction(int id)
        {
            var interaction = await _context.Interaction.FindAsync(id);
            if (interaction == null)
            {
                return NotFound();
            }

            _context.Interaction.Remove(interaction);
            await _context.SaveChangesAsync();

            return interaction;
        }

        private bool InteractionExists(int id)
        {
            return _context.Interaction.Any(e => e.InteractionId == id);
        }
    }
}
