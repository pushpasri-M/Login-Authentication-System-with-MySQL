using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Account()
        {

            return View();
        }
        public ActionResult Data()
        {
            return View();
        }
    }
}