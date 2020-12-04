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
    public class ParentFuneralHomesController : ControllerBase
    {
        private readonly wilbertdbContext _context;

        public ParentFuneralHomesController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: api/ParentFuneralHomes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParentFuneralHome>>> GetParentFuneralHomes()
        {
            return await _context.ParentFuneralHomes.ToListAsync();
        }

        // GET: api/ParentFuneralHomes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParentFuneralHome>> GetParentFuneralHome(int id)
        {
            var parentFuneralHome = await _context.ParentFuneralHomes.FindAsync(id);

            if (parentFuneralHome == null)
            {
                return NotFound();
            }

            return parentFuneralHome;
        }

        // PUT: api/ParentFuneralHomes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParentFuneralHome(int id, ParentFuneralHome parentFuneralHome)
        {
            if (id != parentFuneralHome.Id)
            {
                return BadRequest();
            }

            _context.Entry(parentFuneralHome).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParentFuneralHomeExists(id))
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

        // POST: api/ParentFuneralHomes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ParentFuneralHome>> PostParentFuneralHome(ParentFuneralHome parentFuneralHome)
        {
            _context.ParentFuneralHomes.Add(parentFuneralHome);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParentFuneralHome", new { id = parentFuneralHome.Id }, parentFuneralHome);
        }

        // DELETE: api/ParentFuneralHomes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ParentFuneralHome>> DeleteParentFuneralHome(int id)
        {
            var parentFuneralHome = await _context.ParentFuneralHomes.FindAsync(id);
            if (parentFuneralHome == null)
            {
                return NotFound();
            }

            _context.ParentFuneralHomes.Remove(parentFuneralHome);
            await _context.SaveChangesAsync();

            return parentFuneralHome;
        }

        private bool ParentFuneralHomeExists(int id)
        {
            return _context.ParentFuneralHomes.Any(e => e.Id == id);
        }
    }
}
