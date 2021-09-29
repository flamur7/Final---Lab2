using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    [Authorize(Roles = "Admin,Doctor,User,Nurses")]
    public class KontrollaMjeksoreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KontrollaMjeksoreController(ApplicationDbContext context)
        {
            _context = context;


        }
        public IActionResult Index()
        {
            List<KontrollaMjeksore> kontrollaMjeksores;
            kontrollaMjeksores = _context.KontrollaMjeksores.ToList();
            return View(kontrollaMjeksores);
        }
    }
}
