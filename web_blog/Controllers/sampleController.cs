using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_blog.Controllers
{
    public class sampleController : Controller
    {
        // GET: sample
        public ActionResult Index()
        {
            // hello
            return View();
        }
    }
}