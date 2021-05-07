﻿using EnglishExamOnline.ClientSite.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    [RedirectingAction]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
