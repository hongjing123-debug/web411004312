using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411004312.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SingUp(string name, string account, string password)
        {
            return View();
        }
    }
}