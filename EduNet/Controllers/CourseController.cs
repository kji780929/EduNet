using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EduNet.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Elementary()
        {
            ViewBag.Message = "초등학교 교과";

            return View();
        }

        public ActionResult Middle()
        {
            ViewBag.Message = "중학교 교과";

            return View();
        }

        public ActionResult High()
        {
            ViewBag.Message = "고등학교 교과";

            return View();
        }

    }
}
