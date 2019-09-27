using BusinessModels.CGC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModels.ViewModel
{
    public class CustomerBillingModel
    {
        public MasterTable _masTable { get; set; }
        public IEnumerable<MasterTable> _GetMasterData { get; set; }
        public IEnumerable<Country> _GetCountryData { get; set; }



    }
}
