﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Project_1.Controllers
{
    public class MVCController : Controller
    {
        // GET: MVC
        public ActionResult Index()
        { 
            return View();
        }
    }
}