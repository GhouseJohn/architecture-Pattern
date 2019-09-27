using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.BusinessLogic;
using BusinessModels.CGC;
using BusinessModels.ViewModel;

namespace Presentation.Controllers
{
    public class DepartmentController : Controller
    {
        IEmployee _objEmployee;
        CustomerBillingModel _objbilling=new CustomerBillingModel();

        public DepartmentController()
        {
            this._objEmployee = new Employee();
        }
        [HttpGet]

        public ActionResult Index()
        {

           var x= _objEmployee.GetMasterData();
            _objbilling._GetMasterData = x;
            // return Json(x,JsonRequestBehavior.AllowGet);

            return View(_objbilling);

        }



        public ActionResult GetDataTable()
        {
            var x = _objEmployee.GetMasterData();
            _objbilling._GetMasterData = x;
            return View(_objbilling);
        }



        public ActionResult GetNestedDataTable()
        {
            var x = _objEmployee.GetMasterData();
            var _CountryData = _objEmployee.GetCountry();
            _objbilling._GetMasterData = x;
            _objbilling._GetCountryData = _CountryData;
            return View(_objbilling);
        }


        public JsonResult hhh()
        {
            return Json("");
        }
         
        public JsonResult GetCustomers(string sord,string word, int page, int rows, string searchString)
        {
            // Setting Paging 
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;

            var _data = _objEmployee.GetMasterData();
            //Get Total Row Count 
            int totalRecords = _data.Count();
            var totalPages =(int)Math.Ceiling((float)totalRecords / (float)rows);

            if(sord.ToUpper() == "DESC")
            {
                _data = _data.OrderByDescending(s => s.Id);
                _data = _data.Skip(pageIndex * pageSize).Take(pageSize);
            }
            else
            {
                _data = _data.OrderBy(s => s.Id);
                _data = _data.Skip(pageIndex * pageSize).Take(pageSize);
            }
            var jsonobj = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = _data
            };
            return Json(jsonobj, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetMasterData()
        {
           
            var x = _objEmployee.GetMasterData();
            return Json(x, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CreateCustomer([Bind(Exclude = "CustomerID")] MasterTable customers)
        {
            return Json("");
        }
    }
}