using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    [Authorize(Roles = "Admin,Doctor,User,Nurses,Receotionist")]
    public class DetajetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DetajetController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Detajet> detajets;
            detajets = _context.Detajets.ToList();
            return View(detajets);
        }
    }
}
