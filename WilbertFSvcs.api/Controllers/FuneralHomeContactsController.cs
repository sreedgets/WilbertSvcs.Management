using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WilbertFSvcs.Model.Entities;
using WilbertFSvcs.api.Data;

namespace WilbertFSvcs.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuneralHomeContactsController : ControllerBase
    {
        private readonly WilbertDbContext _context;

        public FuneralHomeContactsController(WilbertDbContext context)
        {
            _context = context;
        }

        // GET: api/FuneralHomeContacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuneralHomeContact>>> GetFuneralHomeContact()
        {
            return await _context.FuneralHomeContact.ToListAsync();
        }

        // GET: api/FuneralHomeContacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FuneralHomeContact>> GetFuneralHomeContact(int id)
        {
            var funeralHomeContact = await _context.FuneralHomeContact.FindAsync(id);

            if (funeralHomeContact == null)
            {
                return NotFound();
            }

            return funeralHomeContact;
        }

        // PUT: api/FuneralHomeContacts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuneralHomeContact(int id, FuneralHomeContact funeralHomeContact)
        {
            if (id != funeralHomeContact.FuneralHomeContactId)
            {
                return BadRequest();
            }

            _context.Entry(funeralHomeContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuneralHomeContactExists(id))
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

        // POST: api/FuneralHomeContacts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FuneralHomeContact>> PostFuneralHomeContact(FuneralHomeContact funeralHomeContact)
        {
            _context.FuneralHomeContact.Add(funeralHomeContact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuneralHomeContact", new { id = funeralHomeContact.FuneralHomeContactId }, funeralHomeContact);
        }

        // DELETE: api/FuneralHomeContacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FuneralHomeContact>> DeleteFuneralHomeContact(int id)
        {
            var funeralHomeContact = await _context.FuneralHomeContact.FindAsync(id);
            if (funeralHomeContact == null)
            {
                return NotFound();
            }

            _context.FuneralHomeContact.Remove(funeralHomeContact);
            await _context.SaveChangesAsync();

            return funeralHomeContact;
        }

        private bool FuneralHomeContactExists(int id)
        {
            return _context.FuneralHomeContact.Any(e => e.FuneralHomeContactId == id);
        }
    }
}
