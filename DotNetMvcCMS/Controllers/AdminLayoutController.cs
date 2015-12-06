using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMvcCMS.Controllers
{
    public class AdminLayoutController : Controller
    {
        //
        // GET: /AdminLayout/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TopBar()
        {
            return View();
        }

        public ActionResult BreadScrumbs()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult MainContent()
        {
            return View();
        }

        public ActionResult Setting()
        {
            return View();
        }
	}
}