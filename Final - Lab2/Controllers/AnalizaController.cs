using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    [Authorize(Roles = "Admin,Doctor,User,Nurses,Receotionist")]
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
       
    }
}
