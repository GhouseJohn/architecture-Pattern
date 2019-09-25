using BusinessModels.CGC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
   public interface IEmployee
    {
        IEnumerable<Country> GetCountry();
        IEnumerable<MasterTable> GetMasterData();
    }
}
