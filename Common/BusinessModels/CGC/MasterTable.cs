using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModels.CGC
{
    public class MasterTable
    {
        /// <summary>
        /// mahesh
        /// </summary>
        [Key]
        public int Id { get; set; }
        public string Master_Token { get; set; }
        [Required(ErrorMessage = "Please Enter Master_Name")]
        public string Master_Name { get; set; }
        [Required(ErrorMessage = "Please Enter You Master_Email")]
        public string Master_Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "Please Enter Your ImagId")]
        public int ImageId { get; set; }
        [Required(ErrorMessage = "Field is required.")]
        public Nullable<int> ContryId { get; set; }
        [Required(ErrorMessage = "Please Enter Your StateId")]
        public Nullable<int> StateId { get; set; }
        [Required(ErrorMessage = "Please Enter Your CityId")]
        public Nullable<int> CityId { get; set; }
        //  [Required(ErrorMessage = "Please Enter Country Name")]
      //  public List<SelectListItem> statelist { get; set; }

       // public HttpPostedFile HelloFile { get; set; }

    }
}
