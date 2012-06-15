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

        public ActionResult Details(int id)
        {
            //var model = from stageEvent in _db.StageAEEvents
              //           where stageEvent.Id == id
                //         select stageEvent;
            var model = _db.StageAEEvents.Single(s => s.Id == id);

            return View(model);
        }

        public ActionResult Purchase(string id)
        {
            var model = _db.StageAEEvents.Find(id);
            return View(model);
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}
