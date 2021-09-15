using Final___Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class FakturaController : Controller
    {
        private readonly ApplicationDbContext _context;
        


        public FakturaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Faktura> fakturas;
            fakturas = _context.Fakturas.ToList();
            return View(fakturas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Faktura pacient = new Faktura();


            pacient.Faturimis.Add(new Faturimi() { FaturimiId = 1 });
            pacient.Faturimis.Add(new Faturimi() { FaturimiId = 2 });

            return View(pacient);
        }

        [HttpPost]
        public IActionResult Create(Faktura faktura)
        {

            _context.Add(faktura);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
