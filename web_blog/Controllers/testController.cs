using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_blog.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            //THis is 3rd changes
            return View();
        }
        public int anything { get; set; }
    }
}