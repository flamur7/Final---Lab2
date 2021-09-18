using Final___Lab2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class AnalizaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnalizaController(ApplicationDbContext context)
        {
            _context = context;


        }
        public IActionResult Index()
        {
            List<Analizat> analizats;
            analizats = _context.Analizats.ToList();
            return View(analizats);
        }
        public IActionResult Create()
        {
            Analizat analizat = new Analizat();


            //appointment.Doctors.Add(new Doctor() { Id = 1 });
            //appointment.Doctors.Add(new Doctor() { Id = 2 });


            return View(analizat);
        }
        [HttpPost]
        public IActionResult Create(Analizat analizat)
        {



            _context.Add(analizat);

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
