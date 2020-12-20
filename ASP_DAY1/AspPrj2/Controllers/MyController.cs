using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspPrj2.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult MyPage()
        {
            return View();
        }

        //public string MyPage()
        //{
        //    return "hello world";
        //}
    }
}