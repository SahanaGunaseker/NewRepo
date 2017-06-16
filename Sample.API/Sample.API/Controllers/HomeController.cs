using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.API.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Route("")]
        [Route("ReturnString")]
        [HttpGet]
        public string ReturnString()
        {
            string str = "Hello World";
            return str;
            //return Json(new { str }, JsonRequestBehavior.AllowGet);
        }

    }
}