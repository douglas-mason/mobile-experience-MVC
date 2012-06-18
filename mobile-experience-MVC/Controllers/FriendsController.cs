using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mobile_experience_MVC.Models;

namespace mobile_experience_MVC.Controllers
{
    public class FriendsController : Controller
    {
        //
        // GET: /Friends/

        StageDB _db = new StageDB();

        public ActionResult Index(int id)
        {
            var currentUser = _db.Users.Single(x => x.id == id);
            string userId = currentUser.id.ToString();
            var currentUsersFriends = _db.Users.Where(x => x.relationships.Contains(userId));
            //foreach (User friend in currentUsersFriends)
            //{

            //}
            return View(currentUsersFriends);
        }

    }
}
