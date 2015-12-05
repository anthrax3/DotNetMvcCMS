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

        public ActionResult Slider()
        {
            return View();
        }
        #region LeftSide
        public ActionResult LeftSideCategory()
        {
            return View();
        }

        public ActionResult LeftSideBrand()
        {
            return View();
        }

        public ActionResult LeftSidePrice()
        {
            return View();
        }

        public ActionResult LeftSideImage()
        {
            return View();
        }
#endregion

        #region RightContent
        public ActionResult RightBoxItems()
        {
            return View();
        }

        public ActionResult RightBoxItemsWithSlider()
        {
            return View();
        }
        #endregion

        public ActionResult ItemDetail()
        {
            return View();
        }

        public ActionResult RightBoxItemsWithCategoryTab()
        {
            return View();
        }

        public ActionResult Footer()
        {
            return View();
        }
	}
}