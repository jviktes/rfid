﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_server.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View("Index");
        }

        public void Upload(string data)
        {
            //uložení dat:
            //ViewData["RFID"] = data;
            //return View("Index");
        }
    }
}