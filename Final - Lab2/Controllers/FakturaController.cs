using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    [Authorize(Roles = "Admin,User,Nurses,Receotionist")]
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

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Faktura faktura = _context.Fakturas.Where(p => p.Id == Id).FirstOrDefault();
            return View(faktura);
        }
        [HttpPost]
        public IActionResult Edit(Faktura faktura)
        {
            _context.Attach(faktura);
            _context.Entry(faktura).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Faktura faktura = _context.Fakturas.Where(p => p.Id == Id).FirstOrDefault();
            return View(faktura);
        }
        [HttpPost]
        public IActionResult Delete(Faktura faktura)
        {
            _context.Attach(faktura);
            _context.Entry(faktura).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("index");
        }


    }
}
