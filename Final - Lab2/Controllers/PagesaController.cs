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
    }
}
