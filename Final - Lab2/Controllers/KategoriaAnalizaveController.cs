using Final___Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{

    

    public class KategoriaAnalizaveController : Controller
    {
        private readonly ApplicationDbContext _context;



        public KategoriaAnalizaveController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<KategoritAnalizave> kategoritAnalizaves;
            kategoritAnalizaves = _context.KategoritAnalizaves.ToList();
            return View(kategoritAnalizaves);
        }
        public IActionResult Create()
        {
            KategoritAnalizave kategoritAnalizaves = new KategoritAnalizave();

            return View(kategoritAnalizaves);
        }

        [HttpPost]
        public IActionResult Create(KategoritAnalizave kategoritAnalizaves)
        {

            _context.Add(kategoritAnalizaves);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
