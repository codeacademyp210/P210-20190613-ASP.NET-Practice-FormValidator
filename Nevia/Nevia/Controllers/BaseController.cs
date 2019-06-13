using Nevia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nevia.Controllers
{
    public class BaseController : Controller
    {
        protected NeviaEntities db;
        protected Setting Setting;

        public BaseController()
        {
            db = new NeviaEntities();
            Setting = db.Settings.FirstOrDefault();
        }

    }
}