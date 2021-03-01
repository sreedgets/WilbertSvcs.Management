using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Enums;
using WilbertVaultCompany.api.Models;

namespace WilbertVaultCompany.api.Data
{
    public class FuneralHomeRepo : IFuneralHomesRepo
    {
        private readonly wilbertdbContext _context;

        public FuneralHome GetFuneralHomeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FuneralHome>> ListAllFuneralHomesAsync()
        {
            //Get list of funeral homes
            IQueryable<FuneralHome> fhList = from fh in _context.FuneralHomes
                                             orderby fh.Name
                                             select fh;
            _context.Database.CloseConnection();
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
                    if (p.PlantId == item.PlantId)
                    {
                        item.Plants.Add(p);
                        item.PlantName = p.PlantName;
                    }
                }
                item.State = Enum.GetName(typeof(States), Int32.Parse(item.State));
            }
            return fhList;

        }
    }
}
