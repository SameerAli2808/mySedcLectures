﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sedc.PizzApp.WebDemo.Controllers
{
    public class SedcController : Controller
    {
        public IActionResult IsItSedcDay()
        {
            return View();
        }

        //public IActionResult IsItSedcDay()
        //{
        //    return View("~/Views/Sedc/IsItSedcDay.cshtml");
        //}
    }
}