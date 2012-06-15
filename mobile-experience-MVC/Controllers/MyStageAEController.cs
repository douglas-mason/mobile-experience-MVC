using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mobile_experience_MVC.Models;

namespace mobile_experience_MVC.Controllers
{
    public class MyStageAEController : Controller
    {
        //
        // GET: /MyStageAE/

        StageDB _db = new StageDB();

        public ActionResult Index(int id)
        {
            //var userEventId = _db.UserEvents.Where(e => e.userId == id).Select(i => id).ToArray<int>();
            var userEventId = (from uEvent in _db.UserEvents
                           where uEvent.userId == id
                           select uEvent.eventId).ToArray<int>();

            var model = (from stageEvents in _db.StageAEEvents
                         where userEventId.Contains(stageEvents.Id)
                         select stageEvents).ToList();
                        
            return View(model);
        }
    }
}
