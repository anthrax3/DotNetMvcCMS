using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMvcCMS.Controllers
{
    public class HomeLayoutController : Controller
    {
        //
        // GET: /HomeLayout/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Header()
        {
            return View();
        }
	}
}