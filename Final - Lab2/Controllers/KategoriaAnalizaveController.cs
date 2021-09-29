using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    [Authorize(Roles = "Admin,Doctor,User,Nurses,Receotionist")]
    public class KategoriaAnalizaveController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public KategoriaAnalizaveController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;

        }

        public IActionResult Index()
        {
            List<KategoriaAnalizave> kategoriaAnalizaves;
            kategoriaAnalizaves = _context.KategoriaAnalizaves.ToList();
            return View(kategoriaAnalizaves);
        }
        [Authorize(Roles = "Admin,Doctor")]
        public IActionResult Create()
        {
            KategoriaAnalizave kategoriaAnalizave = new KategoriaAnalizave();


            kategoriaAnalizave.Analizats.Add(new Analizat() { Id = 1 });
            kategoriaAnalizave.Analizats.Add(new Analizat() { Id = 2 });


            return View(kategoriaAnalizave);
        }

        [HttpPost]
        public IActionResult Create(KategoriaAnalizave kategoriaAnalizave)
        {



            _context.Add(kategoriaAnalizave);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            KategoriaAnalizave kategoriaAnalizave = _context.KategoriaAnalizaves.Where(p => p.KategoriaAnalizaveId == Id).FirstOrDefault();
            return View(kategoriaAnalizave);
        }
        [HttpPost]
        public IActionResult Edit(KategoriaAnalizave kategoriaAnalizave)
        {
            _context.Attach(kategoriaAnalizave);
            _context.Entry(kategoriaAnalizave).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
