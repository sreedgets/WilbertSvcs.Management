using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Models;

namespace WilbertVaultCompany.api.Data
{
    public interface IFuneralHomesRepo
    {
        public Task< IEnumerable<FuneralHome> > ListAllFuneralHomesAsync();

        public FuneralHome GetFuneralHomeById(int id);
    }
}
