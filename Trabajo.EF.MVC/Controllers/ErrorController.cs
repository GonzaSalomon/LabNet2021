﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trabajo.EF.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(Exception ex)
        {
            ViewBag.Message = "Mensaje de error: " + ex.Message;
            return View();
        }
    }
}