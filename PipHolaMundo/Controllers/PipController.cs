using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PipHolaMundo.Controllers
{
    public class PipController : Controller
    {
        // GET: Pip
        public ActionResult Index()
        {
            return View();
        }
    }
}