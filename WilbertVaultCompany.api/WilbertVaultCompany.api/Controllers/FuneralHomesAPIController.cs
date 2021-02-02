using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WilbertVaultCompany.api.Enums;
using WilbertVaultCompany.api.Models;

namespace WilbertVaultCompany.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuneralHomesAPIController : ControllerBase
    {
        private readonly wilbertdbContext _context;

        public FuneralHomesAPIController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: api/FuneralHomes
        [HttpGet]
        public async Task<IQueryable<FuneralHome>> GetFuneralHomes()
        {
            //Get list of funeral homes
            IQueryable<FuneralHome> fhList = from fh in _context.FuneralHomes
                                             select fh;

            //Iterate through each item in the list
            foreach (var item in fhList)
            {
                //Instantiate a parent
                var pfh = new ParentFuneralHome();
                if (item.ParentFuneralHomeId != 0 && item.ParentFuneralHomeId != null)
                    pfh = await _context.ParentFuneralHomes.FindAsync(item.ParentFuneralHomeId);

                if (item.ParentName != null)
                {
                    if (pfh != null)
                        item.ParentName = pfh.ParentFuneralhomeName.Trim();
                }

                // Get Plants
                //var additives = p.Additives.ToList();
                var plants = item.Plants.ToList();

                foreach (var p in plants)
                {
                    if (p.PlantId ==item.PlantId)
                    {
                        item.Plants.Add(p);
                        item.PlantName = p.PlantName;
                    }
                }
                
                item.State = Enum.GetName(typeof(States), Int32.Parse(item.State));
            }
            return fhList;
        }

        // GET: api/FuneralHomes/5
        [HttpGet("{id}")]
        public async Task<FuneralHome> GetFuneralHome(int id)
        {
            var funeralHome = await _context.FuneralHomes
                      .FirstOrDefaultAsync(m => m.FuneralHomeId == id);

            funeralHome.State = Enum.GetName(typeof(States), Int32.Parse(funeralHome.State));

            funeralHome.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType1)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType1));
            funeralHome.PhoneType2 = Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType2)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType2));
            funeralHome.PhoneType3 = Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType3)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType3));



            return funeralHome;
        }

        // PUT: api/FuneralHomes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<FuneralHome> PostFuneralHome(FuneralHome funeralHome)
        {
            return CreatedAtAction("GetFuneralHome", new { id = funeralHome.FuneralHomeId }, funeralHome);
        }

        // DELETE: api/FuneralHomes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFuneralHome(int id)
        {
            var funeralHome = await _context.FuneralHomes.FindAsync(id);
            if (funeralHome == null)
            {
                return NotFound();
            }

            _context.FuneralHomes.Remove(funeralHome);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FuneralHomeExists(int id)
        {
            return _context.FuneralHomes.Any(e => e.FuneralHomeId == id);
        }
    }
}
