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
    public class VaultOrdersAPIController : ControllerBase
    {
        private readonly wilbertdbContext _context;

        public VaultOrdersAPIController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: api/VaultOrdersAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VaultOrder>>> GetVaultOrder()
        {
            return await _context.VaultOrder.ToListAsync();
        }

        // GET: api/VaultOrdersAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VaultOrder>> GetVaultOrder(int id)
        {
            var vaultOrder = await _context.VaultOrder.FindAsync(id);

            if (vaultOrder == null)
            {
                return NotFound();
            }

            return vaultOrder;
        }

        // PUT: api/VaultOrdersAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVaultOrder(int id, VaultOrder vaultOrder)
        {
            if (id != vaultOrder.VaultOrderId)
            {
                return BadRequest();
            }

            _context.Entry(vaultOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VaultOrderExists(id))
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

        // POST: api/VaultOrdersAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VaultOrder>> PostVaultOrder(VaultOrder vaultOrder)
        {
            _context.VaultOrder.Add(vaultOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVaultOrder", new { id = vaultOrder.VaultOrderId }, vaultOrder);
        }

        // DELETE: api/VaultOrdersAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaultOrder(int id)
        {
            var vaultOrder = await _context.VaultOrder.FindAsync(id);
            if (vaultOrder == null)
            {
                return NotFound();
            }

            _context.VaultOrder.Remove(vaultOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VaultOrderExists(int id)
        {
            return _context.VaultOrder.Any(e => e.VaultOrderId == id);
        }
    }
}
