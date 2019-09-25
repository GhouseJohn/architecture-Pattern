using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.BusinessLogic;
using BusinessModels.CGC;

namespace Presentation.Controllers
{
    public class DepartmentController : Controller
    {
        IEmployee _objEmployee;

        public DepartmentController()
        {
            this._objEmployee = new Employee();
        }
        [HttpGet]

        public ActionResult Index()
        {
           var x= _objEmployee.GetCountry();
            return Json(x,JsonRequestBehavior.AllowGet);
        }



        [HttpGet]

        public ActionResult GetMasterData()
        {
           
            var x = _objEmployee.GetMasterData();
            return Json(x, JsonRequestBehavior.AllowGet);
        }
    }
}