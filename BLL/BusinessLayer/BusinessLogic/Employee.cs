using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModels.CGC;
using LogicalLayer.DataBaseLogic;

namespace BusinessLayer.BusinessLogic
{
    public class Employee : IEmployee
    {
        IRepo _objrepo;

        public Employee (){
          this._objrepo = new Repo();
            }
        public IEnumerable<Country> GetCountry()
        {
            return _objrepo.GetCountryList();
        }

        public IEnumerable<MasterTable> GetMasterData()
        {
            return _objrepo.GetMasterList();
        }
    }
}
