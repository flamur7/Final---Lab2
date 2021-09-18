using Final___Lab2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public DoctorController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;

        }

        public IActionResult Index()
        {
            List<Doctor> doctors;
            doctors = _context.Doctors.ToList();
            return View(doctors);
        }

        public IActionResult Create()
        {
            Doctor doctor = new Doctor();


            doctor.Appointments.Add(new Appointment() { AppointmentId = 1 });
            doctor.Appointments.Add(new Appointment() { AppointmentId = 2 });
            doctor.KontrollaMjeksores.Add(new KontrollaMjeksore() { KontrollaMjesoreId = 2 });
            

            return View(doctor);
        }

        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {

            

            _context.Add(doctor);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
