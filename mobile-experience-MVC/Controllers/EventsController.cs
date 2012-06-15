using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mobile_experience_MVC.Models;

namespace mobile_experience_MVC.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Events/
        StageDB _db = new StageDB();

        public ActionResult Index()
        {
            var model = _db.StageAEEvents;
            return View(model);
        }

    }
}
