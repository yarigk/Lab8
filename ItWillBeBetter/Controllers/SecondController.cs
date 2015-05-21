using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItWillBeBetter.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            ViewBag.message = DateTime.Now;
            return View();
        }
    }
}