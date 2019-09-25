using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModels.CGC;
using System.Data.Entity;

namespace LogicalLayer.DataBaseLogic
{
    public class Repo : IRepo
    {
        Mycoonection _db = new Mycoonection();
        public IEnumerable<Country> GetCountryList()
        {
            var x = (from n in _db.Country
                     orderby n.Cnt_Id
                     select n).AsNoTracking().ToList();
            return x;
        }

        public IEnumerable<MasterTable> GetMasterList()
        {
            var x = (from n in _db.MasterTable
                     orderby n.Id
                     select n).AsNoTracking().ToList();
            return x;
        }
    }
}
