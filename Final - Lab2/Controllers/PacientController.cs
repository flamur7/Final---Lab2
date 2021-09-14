using Final___Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class PacientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PacientController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Pacient> pacients;
            pacients = _context.Pacients.ToList();
            return View(pacients);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Pacient pacient = new Pacient();

            
            pacient.Terapis.Add(new Terapi() { TerapiId = 1 });
            pacient.Terapis.Add(new Terapi() { TerapiId = 2 });
            pacient.Terapis.Add(new Terapi() { TerapiId = 3 });

            return View(pacient);
        }

        [HttpPost]
        public IActionResult Create(Pacient pacient)
        {
            _context.Add(pacient);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
