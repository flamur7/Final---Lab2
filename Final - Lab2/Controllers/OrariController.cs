using Final___Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class OrariController : Controller
    {
        private readonly ApplicationDbContext _context;



        public OrariController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Orari> oraris;
            oraris = _context.Oraris.ToList();
            return View(oraris);
        }
        public IActionResult Create()
        {
            Orari oraris = new Orari();

            return View(oraris);
        }

        [HttpPost]
        public IActionResult Create(Orari oraris)
        {

            _context.Add(oraris);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
