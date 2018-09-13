using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarouselTest2.Controllers
{
    public class CarouselController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Carousel";

            return View();
        }
    }
}
