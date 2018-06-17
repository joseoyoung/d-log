using d_log.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace d_log.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Join()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Cuser cuser)
        {
            int tmpBool;
            tmpBool = CInstance.theUserManager.AddUser(ref cuser);
            if (tmpBool == 1)
            {
                return (RedirectToAction("main", cuser));
            }
            return View(cuser);

        }
        public ActionResult main(Cuser aUser)
        {
            return View(aUser);
        }
    }
}