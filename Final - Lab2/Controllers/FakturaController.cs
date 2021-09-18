using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    [Authorize]
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
            Faktura faktura = new Faktura();

            

            return View(faktura);
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
