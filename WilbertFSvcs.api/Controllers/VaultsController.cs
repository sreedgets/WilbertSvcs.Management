using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WilbertFSvcs.Models.Entities;
using WilbertFSvcs.api.Data;

namespace WilbertFSvcs.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaultsController : ControllerBase
    {
        private readonly WilbertDbContext _context;

        public VaultsController(WilbertDbContext context)
        {
            _context = context;
        }

        // GET: api/Vaults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vault>>> GetVault()
        {
            return await _context.Vault.ToListAsync();
        }

        // GET: api/Vaults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vault>> GetVault(int id)
        {
            var vault = await _context.Vault.FindAsync(id);

            if (vault == null)
            {
                return NotFound();
            }

            return vault;
        }

        // PUT: api/Vaults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVault(int id, Vault vault)
        {
            if (id != vault.VaultId)
            {
                return BadRequest();
            }

            _context.Entry(vault).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VaultExists(id))
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

        // POST: api/Vaults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vault>> PostVault(Vault vault)
        {
            _context.Vault.Add(vault);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVault", new { id = vault.VaultId }, vault);
        }

        // DELETE: api/Vaults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vault>> DeleteVault(int id)
        {
            var vault = await _context.Vault.FindAsync(id);
            if (vault == null)
            {
                return NotFound();
            }

            _context.Vault.Remove(vault);
            await _context.SaveChangesAsync();

            return vault;
        }

        private bool VaultExists(int id)
        {
            return _context.Vault.Any(e => e.VaultId == id);
        }
    }
}
