using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class NursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
