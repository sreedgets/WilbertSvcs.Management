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
    public class CemetariesAPIController : ControllerBase
    {
        private readonly wilbertdbContext _context;

        public CemetariesAPIController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: api/CemetariesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cemetary>>> GetCemetary()
        {
            return await _context.Cemetary.ToListAsync();
        }

        // GET: api/CemetariesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cemetary>> GetCemetary(int id)
        {
            var cemetary = await _context.Cemetary.FindAsync(id);

            if (cemetary == null)
            {
                return NotFound();
            }

            return cemetary;
        }

        // PUT: api/CemetariesAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCemetary(int id, Cemetary cemetary)
        {
            if (id != cemetary.CemetaryId)
            {
                return BadRequest();
            }

            _context.Entry(cemetary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CemetaryExists(id))
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

        // POST: api/CemetariesAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cemetary>> PostCemetary(Cemetary cemetary)
        {
            _context.Cemetary.Add(cemetary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCemetary", new { id = cemetary.CemetaryId }, cemetary);
        }

        // DELETE: api/CemetariesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCemetary(int id)
        {
            var cemetary = await _context.Cemetary.FindAsync(id);
            if (cemetary == null)
            {
                return NotFound();
            }

            _context.Cemetary.Remove(cemetary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CemetaryExists(int id)
        {
            return _context.Cemetary.Any(e => e.CemetaryId == id);
        }
    }
}
