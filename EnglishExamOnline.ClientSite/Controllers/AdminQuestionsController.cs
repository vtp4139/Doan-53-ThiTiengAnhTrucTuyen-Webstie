using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Controllers
{
    public class AdminQuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
