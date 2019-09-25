using BusinessModels.CGC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalLayer.DataBaseLogic
{
   public interface IRepo
    {
        IEnumerable<Country> GetCountryList();
        IEnumerable<MasterTable> GetMasterList();

    }
}
