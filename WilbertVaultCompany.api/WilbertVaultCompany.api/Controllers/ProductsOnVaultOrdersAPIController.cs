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
    public class ProductsOnVaultOrdersAPIController : ControllerBase
    {
        private readonly wilbertdbContext _context;

        public ProductsOnVaultOrdersAPIController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: api/ProductsOnVaultOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsOnVaultOrder>>> GetProductsOnVaultOrder()
        {
            return await _context.ProductsOnVaultOrder.ToListAsync();
        }

        // GET: api/ProductsOnVaultOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductsOnVaultOrder>> GetProductsOnVaultOrder(int id)
        {
            var productsOnVaultOrder = await _context.ProductsOnVaultOrder.FindAsync(id);

            if (productsOnVaultOrder == null)
            {
                return NotFound();
            }

            return productsOnVaultOrder;
        }

        // PUT: api/ProductsOnVaultOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductsOnVaultOrder(int id, ProductsOnVaultOrder productsOnVaultOrder)
        {
            if (id != productsOnVaultOrder.ProductsOnVaultOrderId)
            {
                return BadRequest();
            }

            _context.Entry(productsOnVaultOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsOnVaultOrderExists(id))
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

        // POST: api/ProductsOnVaultOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductsOnVaultOrder>> PostProductsOnVaultOrder(ProductsOnVaultOrder productsOnVaultOrder)
        {
            _context.ProductsOnVaultOrder.Add(productsOnVaultOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductsOnVaultOrder", new { id = productsOnVaultOrder.ProductsOnVaultOrderId }, productsOnVaultOrder);
        }

        // DELETE: api/ProductsOnVaultOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductsOnVaultOrder(int id)
        {
            var productsOnVaultOrder = await _context.ProductsOnVaultOrder.FindAsync(id);
            if (productsOnVaultOrder == null)
            {
                return NotFound();
            }

            _context.ProductsOnVaultOrder.Remove(productsOnVaultOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductsOnVaultOrderExists(int id)
        {
            return _context.ProductsOnVaultOrder.Any(e => e.ProductsOnVaultOrderId == id);
        }
    }
}
