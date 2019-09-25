using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessModels.CGC
{
    public class Country
    {
        [Key]
        public int Cnt_Id { get; set; }
        public string Cnt_Name { get; set; }
    }
}
