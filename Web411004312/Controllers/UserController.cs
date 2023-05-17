using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.AccountMessage = "請輸入帳號";
            }
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }
            if (!name.IsNullOrWhiteSpace()&& !name.IsNullOrWhiteSpace()&& !name.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "註冊成功";
            }


            return View();
        }
    }
}