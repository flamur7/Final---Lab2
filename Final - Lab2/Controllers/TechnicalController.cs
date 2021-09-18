using Final___Lab2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class TechnicalController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public TechnicalController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;

        }
        public IActionResult Index()
        {
            List<Technical> technicals;
            technicals = _context.Technicals.ToList();
            return View(technicals);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Technical technical = new Technical();


            technical.OrariPunes.Add(new OrariPune() { OrariPuneId = 1 });
            technical.OrariPunes.Add(new OrariPune() { OrariPuneId = 2 });
            technical.OrariPunes.Add(new OrariPune() { OrariPuneId = 3 });
            //technical.Analizats.Add(new Analizat() { Id = 4 });
            //technical.Analizats.Add(new Analizat() { Id = 5 });

            return View(technical);
        }
        [HttpPost]
        public IActionResult Create(Technical technical)
        {

            

            _context.Add(technical);
            
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
