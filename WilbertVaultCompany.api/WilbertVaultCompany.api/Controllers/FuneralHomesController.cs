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
    public class FuneralHomesController : ControllerBase
    {
        private readonly WilbertFSDatabaseContext _context;

        public FuneralHomesController(WilbertFSDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/FuneralHomes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuneralHome>>> GetFuneralHomes()
        {
            return await _context.FuneralHomes.ToListAsync();
        }

        // GET: api/FuneralHomes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FuneralHome>> GetFuneralHome(int id)
        {
            var funeralHome = await _context.FuneralHomes.FindAsync(id);

            if (funeralHome == null)
            {
                return NotFound();
            }

            return funeralHome;
        }

        // PUT: api/FuneralHomes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuneralHome(int id, FuneralHome funeralHome)
        {
            if (id != funeralHome.FuneralHomeId)
            {
                return BadRequest();
            }

            _context.Entry(funeralHome).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuneralHomeExists(id))
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

        // POST: api/FuneralHomes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FuneralHome>> PostFuneralHome(FuneralHome funeralHome)
        {
            _context.FuneralHomes.Add(funeralHome);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuneralHome", new { id = funeralHome.FuneralHomeId }, funeralHome);
        }

        // DELETE: api/FuneralHomes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FuneralHome>> DeleteFuneralHome(int id)
        {
            var funeralHome = await _context.FuneralHomes.FindAsync(id);
            if (funeralHome == null)
            {
                return NotFound();
            }

            _context.FuneralHomes.Remove(funeralHome);
            await _context.SaveChangesAsync();

            return funeralHome;
        }

        private bool FuneralHomeExists(int id)
        {
            return _context.FuneralHomes.Any(e => e.FuneralHomeId == id);
        }
    }
}
