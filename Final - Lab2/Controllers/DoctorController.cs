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

        [Authorize(Roles = "Admin,Doctor,User,Receotionist")]
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

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Doctor doctor = _context.Doctors.Where(p => p.DoctorId == Id).FirstOrDefault();
            return View(doctor);
        }
        [HttpPost]
        public IActionResult Edit(Doctor doctor)
        {
            _context.Attach(doctor);
            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        
    }
}
