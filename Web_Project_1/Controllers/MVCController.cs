using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Project_1.Controllers
{
    public class MVCController : Controller
    {
        //protected override void HandleUnknownAction(string actionName)
        //{
        //    Response.Redirect("http://www.google.com");
        //    //base.HandleUnknownAction(actionName);
        //}
        // GET: MVC
        public ActionResult Index()
        { 
            return View();
        }
        public ActionResult ViewInfo()
        {
            ViewData["A"] = "(1). 字串A，我是ViewData[]";
            ViewBag.B = "(2). 字串B，我是ViewBag";
            TempData["C"] = "(3). 字串C，我是TempData[]";

            //Session["A"] = "Hello";  => 類似webform 狀態管理

            return View();
        }
        public ActionResult ViewError()
        {
            ViewData["XYZ"] = "** 我是ViewData[] **";
            ViewBag.XYZ = "抱歉! 改了內容，我是ViewBag";
            
            return View();
        }
        public ActionResult Test()
        {
            return View("RR");
        }
        public string result()
        {
            return "<h3>123</h3>";
        }
        public ActionResult IndexYahoo()
        {
            return Redirect("http://www.yahoo.com.tw/");
        }
    }
}