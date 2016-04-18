using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WebApplication22;

namespace WebApplication22.Controllers
{
    public class POPUPController : Controller
    {
        //
        // GET: /POPUP/
  
         
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 0)]
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult chget()
        {

            mvc5Entities2 db = new mvc5Entities2();
            var a = db.angcontrs.ToList();
            //string Msg = ccls.challanoutvalidate(bill_no, c_date, country, "SIM", simno, AlotUser, sessid, branchcode, givento);
            return Json(a, JsonRequestBehavior.AllowGet);
        }
	}
}