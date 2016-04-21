using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3WithPartialview_14Sep2014.EF;

namespace Mvc3WithPartialview_14Sep2014.Controllers
{
    public class EmpController : Controller
    {
        //
        // GET: /Emp/
        abhiEntities db;
        public EmpController()
        {
            db = new abhiEntities();
        }
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult GetEmployee()
        {
            return PartialView("pv_Index");
        }
        public JsonResult showData()
        {
            return Json(db.Employees,JsonRequestBehavior.AllowGet);
        }

    }
}
