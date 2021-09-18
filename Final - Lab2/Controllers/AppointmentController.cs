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
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
           

        }
        public IActionResult Index()
        {
            List<Appointment> appointments;
            appointments = _context.Appointments.ToList();
            return View(appointments);
        }
        public IActionResult Create()
        {
            Appointment appointment = new Appointment();


            //appointment.Doctors.Add(new Doctor() { Id = 1 });
            //appointment.Doctors.Add(new Doctor() { Id = 2 });
            

            return View(appointment);
        }
        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {



            _context.Add(appointment);

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
