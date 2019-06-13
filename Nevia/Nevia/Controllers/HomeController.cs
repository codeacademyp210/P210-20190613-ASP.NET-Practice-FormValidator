using Nevia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nevia.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewModelHome model = new ViewModelHome();

            model.Setting = Setting;
            model.Blogs = db.Blogs.ToList();
            model.Services = db.Services.ToList();
            model.Slider = db.SliderWorks.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}