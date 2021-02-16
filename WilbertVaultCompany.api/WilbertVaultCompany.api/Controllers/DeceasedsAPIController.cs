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
    public class DeceasedsAPIController : ControllerBase
    {
        private readonly wilbertdbContext _context;

        public DeceasedsAPIController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: api/Deceaseds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deceased>>> GetDeceased()
        {
            return await _context.Deceased.ToListAsync();
        }

        // GET: api/Deceaseds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deceased>> GetDeceased(int id)
        {
            var deceased = await _context.Deceased.FindAsync(id);

            if (deceased == null)
            {
                return NotFound();
            }

            return deceased;
        }

        // PUT: api/Deceaseds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeceased(int id, Deceased deceased)
        {
            if (id != deceased.DeceasedId)
            {
                return BadRequest();
            }

            _context.Entry(deceased).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeceasedExists(id))
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

        // POST: api/Deceaseds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Deceased>> PostDeceased(Deceased deceased)
        {
            _context.Deceased.Add(deceased);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeceased", new { id = deceased.DeceasedId }, deceased);
        }

        // DELETE: api/Deceaseds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeceased(int id)
        {
            var deceased = await _context.Deceased.FindAsync(id);
            if (deceased == null)
            {
                return NotFound();
            }

            _context.Deceased.Remove(deceased);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeceasedExists(int id)
        {
            return _context.Deceased.Any(e => e.DeceasedId == id);
        }
    }
}
