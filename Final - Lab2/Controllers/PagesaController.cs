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
    [Authorize(Roles = "Admin,User,Receotionist")]
    public class PagesaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PagesaController(ApplicationDbContext context)
        {
            _context = context;


        }
        public IActionResult Index()
        {
            List<Pagesa> pagesas;
            pagesas = _context.Pagesas.ToList();
            return View(pagesas);
        }
        public IActionResult Create()
        {
            Pagesa pagesa = new Pagesa();


            //appointment.Doctors.Add(new Doctor() { Id = 1 });
            //appointment.Doctors.Add(new Doctor() { Id = 2 });


            return View(pagesa);
        }
        [HttpPost]
        public IActionResult Create(Pagesa pagesa)
        {



            _context.Add(pagesa);

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int Id)
        {
            Pagesa pagesa = _context.Pagesas.Where(p => p.Id == Id).FirstOrDefault();
            return View(pagesa);
        }
        [HttpPost]
        public IActionResult Edit(Pagesa pagesa)
        {
            _context.Attach(pagesa);
            _context.Entry(pagesa).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Pagesa pagesa = _context.Pagesas.Where(p => p.Id == Id).FirstOrDefault();
            return View(pagesa);
        }
        [HttpPost]
        public IActionResult Delete(Pagesa pagesa)
        {
            _context.Attach(pagesa);
            _context.Entry(pagesa).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("index");
        }


    }
}
