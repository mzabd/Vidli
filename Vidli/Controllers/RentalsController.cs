﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidli.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }
    }
}